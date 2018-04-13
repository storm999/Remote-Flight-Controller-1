namespace Remote_Flight_Controller
{
    partial class RemoteFlightController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connect_btn = new System.Windows.Forms.Button();
            this.ip_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Port_txtBox = new System.Windows.Forms.TextBox();
            this.port_label = new System.Windows.Forms.Label();
            this.elevatorUp_btn = new System.Windows.Forms.Button();
            this.elevatorDown_btn = new System.Windows.Forms.Button();
            this.throttleDown_btn = new System.Windows.Forms.Button();
            this.throttleUp_btn = new System.Windows.Forms.Button();
            this.Throttle_label = new System.Windows.Forms.Label();
            this.elevator_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.airSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verticalSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pitchAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(187, 26);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(110, 26);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connectBTN_Click);
            // 
            // ip_txtBox
            // 
            this.ip_txtBox.Location = new System.Drawing.Point(12, 28);
            this.ip_txtBox.Name = "ip_txtBox";
            this.ip_txtBox.Size = new System.Drawing.Size(92, 20);
            this.ip_txtBox.TabIndex = 1;
            this.ip_txtBox.Text = "77.109.163.250";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // Port_txtBox
            // 
            this.Port_txtBox.Location = new System.Drawing.Point(115, 30);
            this.Port_txtBox.Name = "Port_txtBox";
            this.Port_txtBox.Size = new System.Drawing.Size(57, 20);
            this.Port_txtBox.TabIndex = 3;
            this.Port_txtBox.Text = "9999";
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(115, 9);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(26, 13);
            this.port_label.TabIndex = 4;
            this.port_label.Text = "Port";
            // 
            // elevatorUp_btn
            // 
            this.elevatorUp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elevatorUp_btn.Location = new System.Drawing.Point(210, 95);
            this.elevatorUp_btn.Name = "elevatorUp_btn";
            this.elevatorUp_btn.Size = new System.Drawing.Size(29, 47);
            this.elevatorUp_btn.TabIndex = 5;
            this.elevatorUp_btn.Text = "↑";
            this.elevatorUp_btn.UseVisualStyleBackColor = true;
            this.elevatorUp_btn.Click += new System.EventHandler(this.elevatorUp_btn_Click);
            // 
            // elevatorDown_btn
            // 
            this.elevatorDown_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elevatorDown_btn.Location = new System.Drawing.Point(210, 148);
            this.elevatorDown_btn.Name = "elevatorDown_btn";
            this.elevatorDown_btn.Size = new System.Drawing.Size(29, 47);
            this.elevatorDown_btn.TabIndex = 6;
            this.elevatorDown_btn.Text = "↓";
            this.elevatorDown_btn.UseVisualStyleBackColor = true;
            this.elevatorDown_btn.Click += new System.EventHandler(this.elevatorDown_btn_Click);
            // 
            // throttleDown_btn
            // 
            this.throttleDown_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.throttleDown_btn.Location = new System.Drawing.Point(71, 148);
            this.throttleDown_btn.Name = "throttleDown_btn";
            this.throttleDown_btn.Size = new System.Drawing.Size(29, 47);
            this.throttleDown_btn.TabIndex = 7;
            this.throttleDown_btn.Text = "↓";
            this.throttleDown_btn.UseVisualStyleBackColor = true;
            this.throttleDown_btn.Click += new System.EventHandler(this.throttleDown_btn_Click);
            // 
            // throttleUp_btn
            // 
            this.throttleUp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.throttleUp_btn.Location = new System.Drawing.Point(71, 95);
            this.throttleUp_btn.Name = "throttleUp_btn";
            this.throttleUp_btn.Size = new System.Drawing.Size(29, 47);
            this.throttleUp_btn.TabIndex = 8;
            this.throttleUp_btn.Text = "↑";
            this.throttleUp_btn.UseVisualStyleBackColor = true;
            this.throttleUp_btn.Click += new System.EventHandler(this.throttleUp_btn_Click);
            // 
            // Throttle_label
            // 
            this.Throttle_label.AutoSize = true;
            this.Throttle_label.Location = new System.Drawing.Point(65, 71);
            this.Throttle_label.Name = "Throttle_label";
            this.Throttle_label.Size = new System.Drawing.Size(43, 13);
            this.Throttle_label.TabIndex = 9;
            this.Throttle_label.Text = "Throttle";
            // 
            // elevator_label
            // 
            this.elevator_label.AutoSize = true;
            this.elevator_label.Location = new System.Drawing.Point(201, 71);
            this.elevator_label.Name = "elevator_label";
            this.elevator_label.Size = new System.Drawing.Size(46, 13);
            this.elevator_label.TabIndex = 10;
            this.elevator_label.Text = "Elevator";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airSpeed,
            this.verticalSpeed,
            this.pitchAngle});
            this.dataGridView1.Location = new System.Drawing.Point(12, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(283, 58);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Warning,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView2.Location = new System.Drawing.Point(12, 209);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.Size = new System.Drawing.Size(283, 57);
            this.dataGridView2.TabIndex = 13;
            // 
            // airSpeed
            // 
            this.airSpeed.HeaderText = "Air Speed";
            this.airSpeed.Name = "airSpeed";
            this.airSpeed.Width = 80;
            // 
            // verticalSpeed
            // 
            this.verticalSpeed.HeaderText = "Vertical Speed";
            this.verticalSpeed.Name = "verticalSpeed";
            this.verticalSpeed.Width = 80;
            // 
            // pitchAngle
            // 
            this.pitchAngle.HeaderText = "Pitch Angle";
            this.pitchAngle.Name = "pitchAngle";
            this.pitchAngle.Width = 80;
            // 
            // Warning
            // 
            this.Warning.HeaderText = "Warning";
            this.Warning.Name = "Warning";
            this.Warning.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Altitude";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Throttle";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Elevator Pitch";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // RemoteFlightController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 393);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.elevator_label);
            this.Controls.Add(this.Throttle_label);
            this.Controls.Add(this.throttleUp_btn);
            this.Controls.Add(this.throttleDown_btn);
            this.Controls.Add(this.elevatorDown_btn);
            this.Controls.Add(this.elevatorUp_btn);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.Port_txtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ip_txtBox);
            this.Controls.Add(this.connect_btn);
            this.Name = "RemoteFlightController";
            this.Text = "Remote Plane Controller";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.TextBox ip_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Port_txtBox;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.Button elevatorUp_btn;
        private System.Windows.Forms.Button elevatorDown_btn;
        private System.Windows.Forms.Button throttleDown_btn;
        private System.Windows.Forms.Button throttleUp_btn;
        private System.Windows.Forms.Label Throttle_label;
        private System.Windows.Forms.Label elevator_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn airSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn verticalSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn pitchAngle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warning;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

