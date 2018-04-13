using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Remote_Flight_Controller
{
    public delegate void dataHandler(); //delegate

    public partial class RemoteFlightController : Form
    {
        struct ControlsUpdate
        {
            public ControlsUpdate(int t, int e)
            {
                Throttle = t;
                ElevatorPitch = e;
            }
            public double Throttle;         
            public double ElevatorPitch;    
        }

        struct TelemetryUpdate
        {
            public TelemetryUpdate(int a, int s, int p, int v, int t, int e, int w)
            {
                Altitude = a;      
                Speed = s;         
                Pitch = p;         
                VerticalSpeed = v; 

                Throttle = t;      
                ElevatorPitch = e; 

                WarningCode = w;
            }
            public double Altitude;      //Altitude in ft.
            public double Speed;         //Plane's speed in Knts.
            public double Pitch;         //Plane's pitch in degrees relative to horizon. Positive is planes pointing upwards, negative plane points downwards;
            public double VerticalSpeed; //Plane's vertical speed in Feet per minute.

            public double Throttle;      //Current throttle setting as a percentage (i.e. 0% no throttle, 100% full throttle).
            public double ElevatorPitch; //Current Elevator Pitch in degrees. Positive creates upwards lift, negative downwards.

            public int WarningCode;      //Warning code: 0 - No Warnings; 1 -  Too Low (less than 1000ft); 2 - Stall.
        }

        ControlsUpdate controlUpdates = new ControlsUpdate(50, 1);
        TelemetryUpdate telementryUpdates = new TelemetryUpdate(3000, 200, 0, 0, 50, 1, 0);

        public event dataHandler dataReceivedEvent;         
        public event dataHandler dataSentEvent;              
        public event dataHandler isThereWarningEvent;        

        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //initialization of tcp socket 
        BackgroundWorker backgroundWorker = new BackgroundWorker();                                  //new thread for data transmission

        public RemoteFlightController()
        {
            InitializeComponent();
            backgroundWorker.DoWork += new DoWorkEventHandler(getData);     //backgroundworker is used for data transmission
            backgroundWorker.DoWork += new DoWorkEventHandler(sendData);
            dataReceivedEvent += new dataHandler(dataHasReceived);          //when datareceived event occurs,dataHasReceived method will invoke
            dataSentEvent += new dataHandler(dataHasSent);                       
            isThereWarningEvent += new dataHandler(invokeWarning);               
        }

        private void invokeWarning()
        {
            if (telementryUpdates.WarningCode == 0)
            {
                dataGridView2.Rows[0].Cells[0].Style.ForeColor = Color.Green;
                dataGridView2.Rows[0].Cells[0].Value = "No Warning";
            }
            else if (telementryUpdates.WarningCode == 1)
            {
                dataGridView2.Rows[0].Cells[0].Style.ForeColor = Color.Red;
                dataGridView2.Rows[0].Cells[0].Value = "Too Low";   
            }
            else if (telementryUpdates.WarningCode == 2)
            {
                dataGridView2.Rows[0].Cells[0].Style.ForeColor = Color.Red;
                dataGridView2.Rows[0].Cells[0].Value = "Stall";
            }         
        }

        private void connectBTN_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(ip_txtBox.Text);               
                IPEndPoint remoteApplication = new IPEndPoint(ipAddress, Convert.ToInt32(Port_txtBox.Text));
                socket.Connect(remoteApplication);                                   
                backgroundWorker.RunWorkerAsync();          //connection is done, data transmission with seperate tread has started
                connect_btn.Enabled = false;
                ip_txtBox.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Couldnt Connect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void dataHasSent()
        {
            
        }

        private void dataHasReceived()
        {
            dataGridView1.Rows[0].Cells[0].Value = telementryUpdates.Speed;
            dataGridView1.Rows[0].Cells[1].Value = telementryUpdates.VerticalSpeed;
            dataGridView1.Rows[0].Cells[2].Value = telementryUpdates.Pitch;
            dataGridView2.Rows[0].Cells[1].Value = telementryUpdates.Altitude;
            dataGridView2.Rows[0].Cells[2].Value = controlUpdates.Throttle;
            dataGridView2.Rows[0].Cells[3].Value = controlUpdates.ElevatorPitch;
        }

        public void getData(object sender, DoWorkEventArgs e)
        {
            string incomingData = "";                                                          //incoming data from remote application
            byte[] bytesBuffer = new Byte[256];                                                //byte array for incoming data 
            int bytesReceiveCount = socket.Receive(bytesBuffer);                               //amount of bytes stored to int 
            incomingData = Encoding.ASCII.GetString(bytesBuffer, 0, bytesReceiveCount);        //convertion from byte to string
            telementryUpdates = JsonConvert.DeserializeObject<TelemetryUpdate>(incomingData);  //json data is tranformed into struct
            dataReceivedEvent();                                                               //relevant events are invoked
            isThereWarningEvent();
            sendData(sender, e);                                                               //repeat listening to socket
        }

        public void sendData(object sender, DoWorkEventArgs e)
        {
            string sendingData = JsonConvert.SerializeObject(controlUpdates);   //data to be sent is converted to json string from struct
            byte[] bytesBuffer = Encoding.ASCII.GetBytes(sendingData);          //string is converted to byte    
            socket.Send(bytesBuffer);                                           //Sends data to remote app
            dataSentEvent();                                                    //relevant event is called
            getData(sender, e);                                                 //repeat sending
        }

        private void throttleUp_btn_Click(object sender, EventArgs e)
        {
            if(!(controlUpdates.Throttle >= 100))
            {
                controlUpdates.Throttle++;
            }     
        }

        private void throttleDown_btn_Click(object sender, EventArgs e)
        {
            if (!(controlUpdates.Throttle <= 0))
            {
                controlUpdates.Throttle--;
            }
        }

        private void elevatorUp_btn_Click(object sender, EventArgs e)
        {
            if (!(controlUpdates.ElevatorPitch >= 5))
            {
                controlUpdates.ElevatorPitch += 0.1;
            }
        }

        private void elevatorDown_btn_Click(object sender, EventArgs e)
        {
            if (!(controlUpdates.ElevatorPitch <= 0))
            {
                controlUpdates.ElevatorPitch -= 0.1;
            }
        }
    }
}
