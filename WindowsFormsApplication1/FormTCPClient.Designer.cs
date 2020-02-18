namespace WindowsFormsApplication1
    {
    partial class FormTCPClient
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
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ConcurrentThreads = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TCPClient_RemotePort = new System.Windows.Forms.TextBox();
            this.textBox_TCPClient_RemoteIP = new System.Windows.Forms.TextBox();
            this.button_TCPClient_Connect = new System.Windows.Forms.Button();
            this.button_TCPClient_Disconnect = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_ConnectionStatus_TCPClient = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_SendTCP_Data = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Received_TCP_Data = new System.Windows.Forms.TextBox();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.textBox_ConcurrentThreads);
            this.groupBox10.Controls.Add(this.button_TCPClient_Connect);
            this.groupBox10.Controls.Add(this.button_TCPClient_Disconnect);
            this.groupBox10.Location = new System.Drawing.Point(408, 115);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(278, 134);
            this.groupBox10.TabIndex = 19;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Concurrencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "conexiones concurrentes";
            // 
            // textBox_ConcurrentThreads
            // 
            this.textBox_ConcurrentThreads.Location = new System.Drawing.Point(227, 19);
            this.textBox_ConcurrentThreads.Name = "textBox_ConcurrentThreads";
            this.textBox_ConcurrentThreads.Size = new System.Drawing.Size(41, 20);
            this.textBox_ConcurrentThreads.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBox_TCPClient_RemotePort);
            this.groupBox5.Controls.Add(this.textBox_TCPClient_RemoteIP);
            this.groupBox5.Location = new System.Drawing.Point(407, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(281, 100);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Conexion TCP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Puerto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP";
            // 
            // textBox_TCPClient_RemotePort
            // 
            this.textBox_TCPClient_RemotePort.Location = new System.Drawing.Point(45, 49);
            this.textBox_TCPClient_RemotePort.Name = "textBox_TCPClient_RemotePort";
            this.textBox_TCPClient_RemotePort.Size = new System.Drawing.Size(76, 20);
            this.textBox_TCPClient_RemotePort.TabIndex = 11;
            // 
            // textBox_TCPClient_RemoteIP
            // 
            this.textBox_TCPClient_RemoteIP.Location = new System.Drawing.Point(45, 17);
            this.textBox_TCPClient_RemoteIP.Name = "textBox_TCPClient_RemoteIP";
            this.textBox_TCPClient_RemoteIP.Size = new System.Drawing.Size(135, 20);
            this.textBox_TCPClient_RemoteIP.TabIndex = 10;
            // 
            // button_TCPClient_Connect
            // 
            this.button_TCPClient_Connect.Location = new System.Drawing.Point(193, 55);
            this.button_TCPClient_Connect.Name = "button_TCPClient_Connect";
            this.button_TCPClient_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_TCPClient_Connect.TabIndex = 8;
            this.button_TCPClient_Connect.Text = "Iniciar";
            this.button_TCPClient_Connect.UseVisualStyleBackColor = true;
            // 
            // button_TCPClient_Disconnect
            // 
            this.button_TCPClient_Disconnect.Location = new System.Drawing.Point(193, 85);
            this.button_TCPClient_Disconnect.Name = "button_TCPClient_Disconnect";
            this.button_TCPClient_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.button_TCPClient_Disconnect.TabIndex = 9;
            this.button_TCPClient_Disconnect.Text = "Detener";
            this.button_TCPClient_Disconnect.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_ConnectionStatus_TCPClient);
            this.groupBox4.Location = new System.Drawing.Point(407, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 153);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estado de conexion";
            // 
            // textBox_ConnectionStatus_TCPClient
            // 
            this.textBox_ConnectionStatus_TCPClient.Location = new System.Drawing.Point(6, 19);
            this.textBox_ConnectionStatus_TCPClient.Multiline = true;
            this.textBox_ConnectionStatus_TCPClient.Name = "textBox_ConnectionStatus_TCPClient";
            this.textBox_ConnectionStatus_TCPClient.Size = new System.Drawing.Size(263, 128);
            this.textBox_ConnectionStatus_TCPClient.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_SendTCP_Data);
            this.groupBox3.Location = new System.Drawing.Point(16, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 184);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos a enviar";
            // 
            // textBox_SendTCP_Data
            // 
            this.textBox_SendTCP_Data.Location = new System.Drawing.Point(15, 19);
            this.textBox_SendTCP_Data.Multiline = true;
            this.textBox_SendTCP_Data.Name = "textBox_SendTCP_Data";
            this.textBox_SendTCP_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SendTCP_Data.Size = new System.Drawing.Size(359, 152);
            this.textBox_SendTCP_Data.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Received_TCP_Data);
            this.groupBox2.Location = new System.Drawing.Point(16, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 208);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos recibidos";
            // 
            // textBox_Received_TCP_Data
            // 
            this.textBox_Received_TCP_Data.Location = new System.Drawing.Point(15, 19);
            this.textBox_Received_TCP_Data.Multiline = true;
            this.textBox_Received_TCP_Data.Name = "textBox_Received_TCP_Data";
            this.textBox_Received_TCP_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Received_TCP_Data.Size = new System.Drawing.Size(359, 183);
            this.textBox_Received_TCP_Data.TabIndex = 0;
            // 
            // FormTCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 416);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormTCPClient";
            this.Text = "FormTCPClient";
            this.Load += new System.EventHandler(this.FormTCPClient_Load);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ConcurrentThreads;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TCPClient_RemotePort;
        private System.Windows.Forms.TextBox textBox_TCPClient_RemoteIP;
        private System.Windows.Forms.Button button_TCPClient_Connect;
        private System.Windows.Forms.Button button_TCPClient_Disconnect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_ConnectionStatus_TCPClient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_SendTCP_Data;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Received_TCP_Data;
        }
    }