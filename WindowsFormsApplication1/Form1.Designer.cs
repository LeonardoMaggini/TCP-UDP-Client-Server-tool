namespace WindowsFormsApplication1
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
            this.button_TCPServer_Start = new System.Windows.Forms.Button();
            this.button_TCPServer_Stop = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_ConnectionStatus_TCPServer = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.comboBox_ProtocolSelection = new System.Windows.Forms.ComboBox();
            this.comboBoxEncoding = new System.Windows.Forms.ComboBox();
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
            this.button_TCPClient_Send = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Received_TCP_Data = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Remote_UDPPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Local_UDPPort = new System.Windows.Forms.TextBox();
            this.textBox_UDP_RemoteIP = new System.Windows.Forms.TextBox();
            this.button_UDPConnect = new System.Windows.Forms.Button();
            this.button_UDPDisconnect = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox_ConnectionStatus_UDP = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox_SendUDP_Data = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_ReceivedUDP_Data = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.propertyGrid_Settings = new System.Windows.Forms.PropertyGrid();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_TCPServer_Start
            // 
            this.button_TCPServer_Start.BackColor = System.Drawing.Color.White;
            this.button_TCPServer_Start.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_TCPServer_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TCPServer_Start.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_TCPServer_Start.Location = new System.Drawing.Point(749, 30);
            this.button_TCPServer_Start.Name = "button_TCPServer_Start";
            this.button_TCPServer_Start.Size = new System.Drawing.Size(75, 23);
            this.button_TCPServer_Start.TabIndex = 0;
            this.button_TCPServer_Start.Text = "iniciar";
            this.button_TCPServer_Start.UseVisualStyleBackColor = false;
            this.button_TCPServer_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_TCPServer_Stop
            // 
            this.button_TCPServer_Stop.BackColor = System.Drawing.Color.White;
            this.button_TCPServer_Stop.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_TCPServer_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TCPServer_Stop.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_TCPServer_Stop.Location = new System.Drawing.Point(749, 82);
            this.button_TCPServer_Stop.Name = "button_TCPServer_Stop";
            this.button_TCPServer_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_TCPServer_Stop.TabIndex = 1;
            this.button_TCPServer_Stop.Text = "detener";
            this.button_TCPServer_Stop.UseVisualStyleBackColor = false;
            this.button_TCPServer_Stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 350);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(646, 42);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button_Send
            // 
            this.button_Send.BackColor = System.Drawing.Color.White;
            this.button_Send.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Send.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_Send.Location = new System.Drawing.Point(673, 350);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(70, 42);
            this.button_Send.TabIndex = 4;
            this.button_Send.Text = "Enviar";
            this.button_Send.UseVisualStyleBackColor = false;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_ConnectionStatus_TCPServer);
            this.groupBox1.Controls.Add(this.button_Send);
            this.groupBox1.Controls.Add(this.button_TCPServer_Stop);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button_TCPServer_Start);
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 409);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server TCP";
            // 
            // textBox_ConnectionStatus_TCPServer
            // 
            this.textBox_ConnectionStatus_TCPServer.Location = new System.Drawing.Point(21, 30);
            this.textBox_ConnectionStatus_TCPServer.Multiline = true;
            this.textBox_ConnectionStatus_TCPServer.Name = "textBox_ConnectionStatus_TCPServer";
            this.textBox_ConnectionStatus_TCPServer.Size = new System.Drawing.Size(722, 314);
            this.textBox_ConnectionStatus_TCPServer.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 452);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.onTabSelected);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.onTabIndexChanged);
            this.tabControl1.TabStopChanged += new System.EventHandler(this.onTabIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Server TCP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente TCP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.comboBox_ProtocolSelection);
            this.groupBox11.Controls.Add(this.comboBoxEncoding);
            this.groupBox11.Location = new System.Drawing.Point(583, 198);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(273, 86);
            this.groupBox11.TabIndex = 15;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Codificacion";
            // 
            // comboBox_ProtocolSelection
            // 
            this.comboBox_ProtocolSelection.FormattingEnabled = true;
            this.comboBox_ProtocolSelection.Items.AddRange(new object[] {
            "Protocolo Concentrador unico",
            "Protocolo ISO 8583 (TM)",
            "Protocolo LgServer"});
            this.comboBox_ProtocolSelection.Location = new System.Drawing.Point(77, 49);
            this.comboBox_ProtocolSelection.Name = "comboBox_ProtocolSelection";
            this.comboBox_ProtocolSelection.Size = new System.Drawing.Size(186, 21);
            this.comboBox_ProtocolSelection.TabIndex = 1;
            this.comboBox_ProtocolSelection.SelectedIndexChanged += new System.EventHandler(this.onProtocolSelectedIndexChanged);
            // 
            // comboBoxEncoding
            // 
            this.comboBoxEncoding.FormattingEnabled = true;
            this.comboBoxEncoding.Items.AddRange(new object[] {
            "Texto(UTF-8)",
            "Hex",
            "ASCII"});
            this.comboBoxEncoding.Location = new System.Drawing.Point(77, 19);
            this.comboBoxEncoding.Name = "comboBoxEncoding";
            this.comboBoxEncoding.Size = new System.Drawing.Size(186, 21);
            this.comboBoxEncoding.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.textBox_ConcurrentThreads);
            this.groupBox10.Location = new System.Drawing.Point(578, 113);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(278, 78);
            this.groupBox10.TabIndex = 14;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Concurrencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "conexiones concurrentes";
            // 
            // textBox_ConcurrentThreads
            // 
            this.textBox_ConcurrentThreads.Location = new System.Drawing.Point(138, 30);
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
            this.groupBox5.Controls.Add(this.button_TCPClient_Connect);
            this.groupBox5.Controls.Add(this.button_TCPClient_Disconnect);
            this.groupBox5.Location = new System.Drawing.Point(577, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(281, 100);
            this.groupBox5.TabIndex = 13;
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
            this.textBox_TCPClient_RemotePort.TextChanged += new System.EventHandler(this.onTCPRemotePort_Changed);
            // 
            // textBox_TCPClient_RemoteIP
            // 
            this.textBox_TCPClient_RemoteIP.Location = new System.Drawing.Point(45, 17);
            this.textBox_TCPClient_RemoteIP.Name = "textBox_TCPClient_RemoteIP";
            this.textBox_TCPClient_RemoteIP.Size = new System.Drawing.Size(135, 20);
            this.textBox_TCPClient_RemoteIP.TabIndex = 10;
            this.textBox_TCPClient_RemoteIP.TextChanged += new System.EventHandler(this.onTCPRremoteIP_Changed);
            // 
            // button_TCPClient_Connect
            // 
            this.button_TCPClient_Connect.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_TCPClient_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TCPClient_Connect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_TCPClient_Connect.Location = new System.Drawing.Point(194, 16);
            this.button_TCPClient_Connect.Name = "button_TCPClient_Connect";
            this.button_TCPClient_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_TCPClient_Connect.TabIndex = 8;
            this.button_TCPClient_Connect.Text = "Conectar";
            this.button_TCPClient_Connect.UseVisualStyleBackColor = true;
            this.button_TCPClient_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_TCPClient_Disconnect
            // 
            this.button_TCPClient_Disconnect.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_TCPClient_Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TCPClient_Disconnect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_TCPClient_Disconnect.Location = new System.Drawing.Point(194, 49);
            this.button_TCPClient_Disconnect.Name = "button_TCPClient_Disconnect";
            this.button_TCPClient_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.button_TCPClient_Disconnect.TabIndex = 9;
            this.button_TCPClient_Disconnect.Text = "Desconectar";
            this.button_TCPClient_Disconnect.UseVisualStyleBackColor = true;
            this.button_TCPClient_Disconnect.Click += new System.EventHandler(this.button_Desconnect_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_ConnectionStatus_TCPClient);
            this.groupBox4.Location = new System.Drawing.Point(577, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 116);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estado de conexion";
            // 
            // textBox_ConnectionStatus_TCPClient
            // 
            this.textBox_ConnectionStatus_TCPClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ConnectionStatus_TCPClient.Location = new System.Drawing.Point(6, 19);
            this.textBox_ConnectionStatus_TCPClient.Multiline = true;
            this.textBox_ConnectionStatus_TCPClient.Name = "textBox_ConnectionStatus_TCPClient";
            this.textBox_ConnectionStatus_TCPClient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ConnectionStatus_TCPClient.Size = new System.Drawing.Size(263, 85);
            this.textBox_ConnectionStatus_TCPClient.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_SendTCP_Data);
            this.groupBox3.Controls.Add(this.button_TCPClient_Send);
            this.groupBox3.Location = new System.Drawing.Point(9, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(547, 208);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos a enviar";
            // 
            // textBox_SendTCP_Data
            // 
            this.textBox_SendTCP_Data.Location = new System.Drawing.Point(15, 19);
            this.textBox_SendTCP_Data.Multiline = true;
            this.textBox_SendTCP_Data.Name = "textBox_SendTCP_Data";
            this.textBox_SendTCP_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SendTCP_Data.Size = new System.Drawing.Size(516, 152);
            this.textBox_SendTCP_Data.TabIndex = 1;
            // 
            // button_TCPClient_Send
            // 
            this.button_TCPClient_Send.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_TCPClient_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TCPClient_Send.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_TCPClient_Send.Location = new System.Drawing.Point(456, 177);
            this.button_TCPClient_Send.Name = "button_TCPClient_Send";
            this.button_TCPClient_Send.Size = new System.Drawing.Size(75, 23);
            this.button_TCPClient_Send.TabIndex = 7;
            this.button_TCPClient_Send.Text = "Enviar";
            this.button_TCPClient_Send.UseVisualStyleBackColor = true;
            this.button_TCPClient_Send.Click += new System.EventHandler(this.button_TCPClient_Send_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Received_TCP_Data);
            this.groupBox2.Location = new System.Drawing.Point(9, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 184);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos recibidos";
            // 
            // textBox_Received_TCP_Data
            // 
            this.textBox_Received_TCP_Data.Location = new System.Drawing.Point(15, 19);
            this.textBox_Received_TCP_Data.Multiline = true;
            this.textBox_Received_TCP_Data.Name = "textBox_Received_TCP_Data";
            this.textBox_Received_TCP_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Received_TCP_Data.Size = new System.Drawing.Size(516, 152);
            this.textBox_Received_TCP_Data.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(866, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cliente UDP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.textBox_Remote_UDPPort);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.textBox_Local_UDPPort);
            this.groupBox8.Controls.Add(this.textBox_UDP_RemoteIP);
            this.groupBox8.Controls.Add(this.button_UDPConnect);
            this.groupBox8.Controls.Add(this.button_UDPDisconnect);
            this.groupBox8.Location = new System.Drawing.Point(577, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(281, 100);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Conexion UDP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Puerto Remoto";
            // 
            // textBox_Remote_UDPPort
            // 
            this.textBox_Remote_UDPPort.Location = new System.Drawing.Point(104, 69);
            this.textBox_Remote_UDPPort.Name = "textBox_Remote_UDPPort";
            this.textBox_Remote_UDPPort.Size = new System.Drawing.Size(76, 20);
            this.textBox_Remote_UDPPort.TabIndex = 14;
            this.textBox_Remote_UDPPort.TextChanged += new System.EventHandler(this.onUDP_RemotePort_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Puerto local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "IP";
            // 
            // textBox_Local_UDPPort
            // 
            this.textBox_Local_UDPPort.Location = new System.Drawing.Point(104, 42);
            this.textBox_Local_UDPPort.Name = "textBox_Local_UDPPort";
            this.textBox_Local_UDPPort.Size = new System.Drawing.Size(76, 20);
            this.textBox_Local_UDPPort.TabIndex = 11;
            this.textBox_Local_UDPPort.TextChanged += new System.EventHandler(this.onUDP_LocalPort_TextChanged);
            // 
            // textBox_UDP_RemoteIP
            // 
            this.textBox_UDP_RemoteIP.Location = new System.Drawing.Point(45, 17);
            this.textBox_UDP_RemoteIP.Name = "textBox_UDP_RemoteIP";
            this.textBox_UDP_RemoteIP.Size = new System.Drawing.Size(135, 20);
            this.textBox_UDP_RemoteIP.TabIndex = 10;
            this.textBox_UDP_RemoteIP.TextChanged += new System.EventHandler(this.onUDP_IPRemoteHost_Changed);
            // 
            // button_UDPConnect
            // 
            this.button_UDPConnect.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_UDPConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UDPConnect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_UDPConnect.Location = new System.Drawing.Point(194, 16);
            this.button_UDPConnect.Name = "button_UDPConnect";
            this.button_UDPConnect.Size = new System.Drawing.Size(75, 23);
            this.button_UDPConnect.TabIndex = 8;
            this.button_UDPConnect.Text = "Conectar";
            this.button_UDPConnect.UseVisualStyleBackColor = true;
            this.button_UDPConnect.Click += new System.EventHandler(this.button_UDPConnect_Click);
            // 
            // button_UDPDisconnect
            // 
            this.button_UDPDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_UDPDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UDPDisconnect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_UDPDisconnect.Location = new System.Drawing.Point(194, 49);
            this.button_UDPDisconnect.Name = "button_UDPDisconnect";
            this.button_UDPDisconnect.Size = new System.Drawing.Size(75, 23);
            this.button_UDPDisconnect.TabIndex = 9;
            this.button_UDPDisconnect.Text = "Desconectar";
            this.button_UDPDisconnect.UseVisualStyleBackColor = true;
            this.button_UDPDisconnect.Click += new System.EventHandler(this.button_UDPDisconnect_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox_ConnectionStatus_UDP);
            this.groupBox9.Location = new System.Drawing.Point(577, 130);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(281, 116);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Estado de conexion";
            // 
            // textBox_ConnectionStatus_UDP
            // 
            this.textBox_ConnectionStatus_UDP.Location = new System.Drawing.Point(6, 19);
            this.textBox_ConnectionStatus_UDP.Multiline = true;
            this.textBox_ConnectionStatus_UDP.Name = "textBox_ConnectionStatus_UDP";
            this.textBox_ConnectionStatus_UDP.Size = new System.Drawing.Size(263, 85);
            this.textBox_ConnectionStatus_UDP.TabIndex = 8;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox_SendUDP_Data);
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Location = new System.Drawing.Point(8, 207);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(553, 211);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Datos a enviar";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // textBox_SendUDP_Data
            // 
            this.textBox_SendUDP_Data.Location = new System.Drawing.Point(15, 19);
            this.textBox_SendUDP_Data.Multiline = true;
            this.textBox_SendUDP_Data.Name = "textBox_SendUDP_Data";
            this.textBox_SendUDP_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SendUDP_Data.Size = new System.Drawing.Size(521, 152);
            this.textBox_SendUDP_Data.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(461, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Enviar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox_ReceivedUDP_Data);
            this.groupBox6.Location = new System.Drawing.Point(8, 11);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(553, 184);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Datos recibidos";
            // 
            // textBox_ReceivedUDP_Data
            // 
            this.textBox_ReceivedUDP_Data.Location = new System.Drawing.Point(15, 19);
            this.textBox_ReceivedUDP_Data.Multiline = true;
            this.textBox_ReceivedUDP_Data.Name = "textBox_ReceivedUDP_Data";
            this.textBox_ReceivedUDP_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ReceivedUDP_Data.Size = new System.Drawing.Size(521, 152);
            this.textBox_ReceivedUDP_Data.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.propertyGrid_Settings);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(866, 426);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Configuracion";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // propertyGrid_Settings
            // 
            this.propertyGrid_Settings.Location = new System.Drawing.Point(8, 12);
            this.propertyGrid_Settings.Name = "propertyGrid_Settings";
            this.propertyGrid_Settings.Size = new System.Drawing.Size(350, 382);
            this.propertyGrid_Settings.TabIndex = 0;
            this.propertyGrid_Settings.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.onSettingsUpdated);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(866, 426);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Herramientas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(866, 426);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "test";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(47, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 58);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 452);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "TCP/ UDP (Cliente-Servidor) ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onFormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
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
            this.tabPage3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Button button_TCPServer_Start;
        private System.Windows.Forms.Button button_TCPServer_Stop;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_TCPClient_Disconnect;
        private System.Windows.Forms.Button button_TCPClient_Connect;
        private System.Windows.Forms.TextBox textBox_ConnectionStatus_TCPClient;
        private System.Windows.Forms.TextBox textBox_ConnectionStatus_TCPServer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TCPClient_RemotePort;
        private System.Windows.Forms.TextBox textBox_TCPClient_RemoteIP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_SendTCP_Data;
        private System.Windows.Forms.Button button_TCPClient_Send;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Received_TCP_Data;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox_SendUDP_Data;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_ReceivedUDP_Data;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Remote_UDPPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Local_UDPPort;
        private System.Windows.Forms.TextBox textBox_UDP_RemoteIP;
        private System.Windows.Forms.Button button_UDPConnect;
        private System.Windows.Forms.Button button_UDPDisconnect;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBox_ConnectionStatus_UDP;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PropertyGrid propertyGrid_Settings;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ConcurrentThreads;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox comboBoxEncoding;
        private System.Windows.Forms.ComboBox comboBox_ProtocolSelection;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBox1;
        }
    }

