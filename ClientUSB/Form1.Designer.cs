namespace ClientUSB
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTimeStamp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSensorValue = new System.Windows.Forms.TextBox();
            this.lblStatusMessage = new System.Windows.Forms.Label();
            this.txtRec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVol = new System.Windows.Forms.TextBox();
            this.txtElap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Pro = new System.Windows.Forms.TextBox();
            this.txtTime_Start = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTime_End = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTimeStamp
            // 
            this.txtTimeStamp.Location = new System.Drawing.Point(150, 47);
            this.txtTimeStamp.Name = "txtTimeStamp";
            this.txtTimeStamp.Size = new System.Drawing.Size(152, 22);
            this.txtTimeStamp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "TimeStamp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Node_Value";
            // 
            // txtSensorValue
            // 
            this.txtSensorValue.Location = new System.Drawing.Point(150, 91);
            this.txtSensorValue.Name = "txtSensorValue";
            this.txtSensorValue.Size = new System.Drawing.Size(152, 22);
            this.txtSensorValue.TabIndex = 0;
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.AutoSize = true;
            this.lblStatusMessage.Location = new System.Drawing.Point(134, 214);
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(101, 16);
            this.lblStatusMessage.TabIndex = 3;
            this.lblStatusMessage.Text = "StatusMessage";
            // 
            // txtRec
            // 
            this.txtRec.Location = new System.Drawing.Point(376, 174);
            this.txtRec.Multiline = true;
            this.txtRec.Name = "txtRec";
            this.txtRec.Size = new System.Drawing.Size(380, 121);
            this.txtRec.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Voltage";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtVol
            // 
            this.txtVol.Location = new System.Drawing.Point(150, 263);
            this.txtVol.Name = "txtVol";
            this.txtVol.Size = new System.Drawing.Size(152, 22);
            this.txtVol.TabIndex = 0;
            // 
            // txtElap
            // 
            this.txtElap.Location = new System.Drawing.Point(150, 305);
            this.txtElap.Name = "txtElap";
            this.txtElap.Size = new System.Drawing.Size(152, 22);
            this.txtElap.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Elapsed";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Program";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Time_Start";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Pro
            // 
            this.txt_Pro.Location = new System.Drawing.Point(150, 351);
            this.txt_Pro.Name = "txt_Pro";
            this.txt_Pro.Size = new System.Drawing.Size(152, 22);
            this.txt_Pro.TabIndex = 0;
            // 
            // txtTime_Start
            // 
            this.txtTime_Start.Location = new System.Drawing.Point(150, 390);
            this.txtTime_Start.Name = "txtTime_Start";
            this.txtTime_Start.Size = new System.Drawing.Size(152, 22);
            this.txtTime_Start.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Time_End";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTime_End
            // 
            this.txtTime_End.Location = new System.Drawing.Point(478, 393);
            this.txtTime_End.Name = "txtTime_End";
            this.txtTime_End.Size = new System.Drawing.Size(152, 22);
            this.txtTime_End.TabIndex = 0;
            this.txtTime_End.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRec);
            this.Controls.Add(this.lblStatusMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSensorValue);
            this.Controls.Add(this.txtTime_End);
            this.Controls.Add(this.txtTime_Start);
            this.Controls.Add(this.txt_Pro);
            this.Controls.Add(this.txtElap);
            this.Controls.Add(this.txtVol);
            this.Controls.Add(this.txtTimeStamp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTimeStamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSensorValue;
        private System.Windows.Forms.Label lblStatusMessage;
        private System.Windows.Forms.TextBox txtRec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVol;
        private System.Windows.Forms.TextBox txtElap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Pro;
        private System.Windows.Forms.TextBox txtTime_Start;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTime_End;
    }
}

