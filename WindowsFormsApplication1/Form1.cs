using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkProtocolServices;
using NetworkProtocolServices.Utilities;
using NetworkProtocolServices.TCP_Server;
using TCP_UDP_ClientServer.Utilities;
using System.Configuration;
using CUProtocol;
using ClienteConcentrador;

namespace WindowsFormsApplication1
    {
    public partial class Form1 : Form
        {

        ///declaracion de objetos Protocolo
        ClienteConcentrador.CheckUpdate chkUpdate = new CheckUpdate();

        List<TCPClient> ClientesTCP = new List<TCPClient>();


        /// <summary>
        /// mantiene el tipo de codificacion 
        /// de los mensajes que se envian y reciben
        /// </summary>
        private enum encoding
            {
            Texto = 0,
            Hex =1,
            ASCII = 2
            }

        private delegate void onNewEventHandler(string message);
       
        private event onNewEventHandler  onNewEvent;
        private event onNewEventHandler onNewTCPClientEvent;
        private event onNewEventHandler onNewUDPClientEvent;
        private event onNewEventHandler onTCPClientConnectionEstablished;
        private event onNewEventHandler onTCPClientTerminated;
        
        TCPServer server; 
        Thread thr;
        ThreadWorker w;
        Worker wo;
        Client cl;
        TCPClient con;
        UDPClient conUDP;
        Settings settings = new Settings();
        Definition config = new Definition(Application.StartupPath + "\\Config.cfg");// "D:\\TCP-UDP Client Server Config.cfg");
        
        public Form1()
            {
            InitializeComponent();
            this.onNewEvent += new onNewEventHandler(onTextUpdated);
            this.onNewTCPClientEvent += new onNewEventHandler(onText_ReceivedTCPClient);
            this.onNewUDPClientEvent += new onNewEventHandler(onText_ReceivedUPDClient);
            this.onTCPClientTerminated += new onNewEventHandler(onTCPClientConnectionTerminated);
            this.onTCPClientConnectionEstablished += new onNewEventHandler(onTCPClientEstablished);
            //persist.getObject(ref settings);

            propertyGrid_Settings.SelectedObject = settings;
            }

        private void onTCPClientEstablished(string message)
            {
            textBox_ConnectionStatus_TCPClient.AppendText(System.DateTime.Now.ToString() + " " + message + "\n");
            }

        private void onTCPClientConnectionTerminated(string message)
            {
            textBox_ConnectionStatus_TCPClient.AppendText(System.DateTime.Now.ToString() + " " + message + "\n");
            button_TCPClient_Connect.Enabled = true;
            button_TCPClient_Disconnect.Enabled = false;
            button_TCPClient_Send.Enabled = false;
            }

        /// <summary>
        /// Inicia Server TCP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
            {
            button_TCPServer_Stop.Enabled = true;
            button_TCPServer_Start.Enabled = false;
            button_Send.Enabled = true;

            server = new TCPServer(settings.TCPServer_LocalIP, settings.TCPServer_LocalPort, settings.QueueSize);
            w = new ThreadWorker();
            wo = new Worker();

            server.ReceiveTimeOut = settings.TCPServer_ReceiveTimeOut;
            server.ConnectionTimeOut = settings.TCPServer_ConnectionTimeOut;
            server.LogPath = settings.Log_Path;
            server.LogLevel = settings.LogLevel;
            server.Logger_Function = (Logger.Log.LogFunction)  settings.Logger_Function;
            

           this.server.ListenerStarted += new NetworkProtocolServices.TCP_Server.TCPServer.ListenerStartedEventHandler(this.onListenerStarted);
           this.server.NewRequestAccepted += new NetworkProtocolServices.TCP_Server.TCPServer.NewRequestAcceptedEventHandler(this.onNewRequestAccepted);
           this.server.ListenerStopped += new NetworkProtocolServices.TCP_Server.TCPServer.ListenerStoppedEventHandler(this.ListenerStopped);
            this.server.NewMessageReceived += new NetworkProtocolServices.TCP_Server.TCPServer.NewMessageReceivedEventHandler(this.w_NewMessage);
            this.server.WorkerConnectionTerminated += new TCPServer.WorkerConnectionTerminatedEventHandler(this.workerTerminated);
            //server.MaxConcurrentConnections = 2;
            //server.ReceiveTimeOut = 2000;
            //server.ConnectionTimeOut = 60000;
            //server.QueueSize = 2;
            
            thr = new Thread(server.start);
            thr.Start();


            this.wo.NewIncomingMessage += new Worker.NewIncomingMessageEventHandler(w_NewMessage);
            this.wo.ConnectionTerminated += new Worker.ConnectionTerminatedEventHandler(workerTerminated);
            
             //thr = new Thread(w.run);
             //thr.Start();

            
            }

        private void ListenerStopped(TCPServer s)
            {
            string message = "Listener detenido";
            this.textBox_ConnectionStatus_TCPServer.Invoke(onNewEvent, message);
            }

        private void onNewRequestAccepted(Worker w)
            {
            string message = "Nueva conexion creada " + w.Client.Id.ToString() + " - " + "Remote End Point " + w.Client.Socket.RemoteEndPoint.ToString(); ;
            this.textBox_ConnectionStatus_TCPServer.Invoke(onNewEvent, message);
            }

        private void onListenerStarted(TCPServer s)
            {
            string message = "Listener Iniciado";
            this.textBox_ConnectionStatus_TCPServer.Invoke(onNewEvent,message);
                      
            }

        private void workerTerminated(Worker w)
            {
            string message = "el cliente " + w.Client.Id.ToString() + " se ha desconectado";
            this.textBox_ConnectionStatus_TCPServer.Invoke(onNewEvent, message);
            }

       private  void w_NewMessage(Worker w)
            {
            wo = w;
            string message = "nuevo mensaje recibido desde " + w.Client.Socket.RemoteEndPoint.ToString() + " - " + "cliente : " + w.Client.Id + " - " + NetworkProtocolServices.Utilities.Utilities.ToString(w.Client.InputBuffer);
            try
                {
                this.textBox_ConnectionStatus_TCPServer.Invoke(onNewEvent, message);
                 
                }
            catch (Exception ex)
                {

                MessageBox.Show(ex.Message);
                }
           
            }

        

        /// <summary>
        /// Detiene el Servidor TCP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
            {
            button_TCPServer_Start.Enabled = true;
            button_TCPServer_Stop.Enabled = false;
            button_Send.Enabled = false;

            ///detiene el servidor
            server.stop();

            
            }
        /// <summary>
        /// Envia un mensaje TCP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Send_Click(object sender, EventArgs e)
            {
            wo.Client.OutputBuffer = NetworkProtocolServices.Utilities.Utilities.GetBytesBigEndian(textBox2.Text);
            try
                {
               wo.send(wo.Client); 
                }
            catch (Exception)
                {
                
                throw;
                }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void textBox2_TextChanged(object sender, EventArgs e)
            {
         
            }


        /// <summary>
        /// El cliente TCP envia un mensaje al servidor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_TCPClient_Send_Click(object sender, EventArgs e)
            {
            try
                {
                sendMessage();
                }
            
            catch (Exception)
                {
                
                throw;
                }
            }

        /// <summary>
        /// envia un mensaje codificado segun lo seleccionado en el 
        /// combobox
        /// </summary>
        private void sendMessage()
            {
            try
                {
                 ///en funcion del tipo de mensaje a enviar (texto, hex, ascii), envio el mensaje
                ///en ese formato
                switch ((encoding)comboBoxEncoding.SelectedIndex)
                    {
                    case encoding.Texto:
                        con.send(textBox_SendTCP_Data.Text);
                        break;
                    case encoding.Hex:
                        con.send(NetworkProtocolServices.Utilities.Utilities.GetBytesBigEndian(textBox_SendTCP_Data.Text));
                        break;
                    case encoding.ASCII:
                        char[] data = new char[textBox_SendTCP_Data.TextLength];
                        for (int i = 0; i < textBox_SendTCP_Data.TextLength; i++)
                            {
                            data[i] = Convert.ToChar(textBox_SendTCP_Data.Text.Substring(i, 1));
                            }
                        con.send(data);
                        break;
                    }
                }
            catch (Exception)
                {
                
                throw;
                }
            }

        /// <summary>
        /// El cliente TCP crea una conexion con el host remoto(servidor)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Connect_Click(object sender, EventArgs e)
            {
            button_TCPClient_Send.Enabled = true;
            button_TCPClient_Connect.Enabled = false;
            button_TCPClient_Disconnect.Enabled = true;

            int MaxConcurrentThreads = Convert.ToInt32(textBox_ConcurrentThreads.Text);
            ///creo un pool de threads
            //creo el pool de threads
            ThreadPool.SetMinThreads(MaxConcurrentThreads, MaxConcurrentThreads); /// Parametrizar el maximo de threads concurrentes

            for (int i = 0; i < MaxConcurrentThreads; i++)
                {
                con = new TCPClient(settings.TCPClient_RemoteIP, settings.TCPClient_RemotePort);
                TCPClient.ReceiveTimeOut = settings.TCPClient_ReceiveTimeOut;
                TCPClient.SendTimeOut = settings.TCPClient_SendTimeOut;
                con.Protocolo = System.Net.Sockets.ProtocolType.Tcp;
                con.ConnectionEstablished += new TCPClient.ConnectionEStablishedEventHandler(this.onTCPClient_ConnectionEstablished);
                con.NewMessageReceived += new TCPClient.NewMessageReceivedEventHandler(this.onNewMessageFromServer);
                con.ConnectionTerminated += new TCPClient.ConnectionTerminatedEventHandler(this.onTCPClient_ConnectionTerminated);

                ClientesTCP.Add(con);
                // con.connect();
                ThreadPool.QueueUserWorkItem(new WaitCallback(con.connect));
                }

            

            }

        private void onTCPClient_ConnectionEstablished(TCPClient connector)
            {
            string message = "El cliente ha iniciado la sesion con el host remoto.";
            this.textBox_ConnectionStatus_TCPServer.Invoke(onTCPClientConnectionEstablished, message);
            }


        private void onTCPClient_ConnectionTerminated(TCPClient connector)
            {
            string message = connector.LastErrorDescription + " - codigo de error: " + connector.LastErrorCode;
            this.textBox_ConnectionStatus_TCPServer.Invoke(onTCPClientTerminated, message);
            
            }
        
        /// <summary>
        /// El cliente TCP cierra la conexion con el host remoto(servidor)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Desconnect_Click(object sender, EventArgs e)
            {
            try
                {
                con.close();
                button_TCPClient_Disconnect.Enabled = false;
                button_TCPClient_Connect.Enabled = true;
                button_TCPClient_Send.Enabled = false;
                }
            catch (Exception ex)
                {
                
                MessageBox.Show(ex.Message);
                }
            
            }


        private void onNewMessageFromServer(Client client)
            {
            this.textBox_Received_TCP_Data.Invoke(onNewTCPClientEvent, NetworkProtocolServices.Utilities.Utilities.ToString(client.InputBuffer));
            
            }

        private void onTextUpdated(string message)
            {
            textBox_ConnectionStatus_TCPServer.AppendText(System.DateTime.Now.ToString() + " - " + message +"\n");
            }

        private void groupBox7_Enter(object sender, EventArgs e)
            {

            }


        private void onText_ReceivedTCPClient(string message)
            {
            textBox_Received_TCP_Data.AppendText(System.DateTime.Now.ToString() + " - " + message + "\n");
            textBox_Received_TCP_Data.AppendText(System.DateTime.Now.ToString() + " - " + "tiempo de respuesta: " + con.ResponseTime.ToString() + " ms" + "\n");
            }




        private void Form1_Load(object sender, EventArgs e)
            {

            config.get<Settings>(ref settings);
            propertyGrid_Settings.SelectedObject = settings;

            ///configuro los campos de las distintas solapas
            ///cliente TCP:
            textBox_TCPClient_RemoteIP.Text = settings.TCPClient_RemoteIP;
            textBox_TCPClient_RemotePort.Text = settings.TCPClient_RemotePort.ToString();
            textBox_ConcurrentThreads.Text = settings.TCPClient_ConcurrentThreads.ToString();

            ///UDP
            textBox_Local_UDPPort.Text = settings.UDP_LocalPort.ToString();
            textBox_Remote_UDPPort.Text = settings.UDP_RemotePort.ToString();
            textBox_UDP_RemoteIP.Text = settings.UDP_RemoteIP;

            ///configuro la UI
            button_TCPServer_Stop.Enabled = false;
            button_TCPClient_Disconnect.Enabled = false;
            button_UDPDisconnect.Enabled = false;
            button_Send.Enabled = false;
            button_TCPClient_Send.Enabled = false;
            button3.Enabled = false;
            comboBoxEncoding.SelectedIndex = 1;
            comboBox_ProtocolSelection.SelectedIndex = 0;
            ///configuro el tabcontrol
            tabControl1.SelectedIndex = 1;//selecciono el 2do tab por defecto
            ///cargo los iconos a cada solapa
            ImageList imageList1 = new ImageList();
           
            imageList1.Images.Add ((Bitmap)Properties.Resources.outline_settings_black_18dp);
            imageList1.Images.Add((Image)Properties.Resources.outline_computer_black_18dp);
            imageList1.Images.Add((Image)Properties.Resources.outline_desktop_windows_black_18dp);
            imageList1.Images.Add((Image)Properties.Resources.outline_build_black_18dp);
            imageList1.Images.Add((Image)Properties.Resources.outline_cloud_download_black_18dp);
            tabControl1.ImageList = imageList1;
            tabControl1.TabPages[0].ImageIndex = 4;
            tabControl1.TabPages[1].ImageIndex = 2;
            tabControl1.TabPages[2].ImageIndex = 2;
            tabControl1.TabPages[3].ImageIndex = 0;
            tabControl1.TabPages[4].ImageIndex = 3;

            }

        /// <summary>
        /// este metodo se ejecuta cuando se modifica
        /// un valor en el control propertyGrid_Settings
        /// al hacer TAB sobre el mismo
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void onSettingsUpdated(object s, PropertyValueChangedEventArgs e)
            {
            ///actualizo la informacion y/o estado de todos los controles
            ///de configuracion involucrados, asi como el archivo de config.
            settings = (Settings) propertyGrid_Settings.SelectedObject;
            config.set<Settings>(ref settings);

            textBox_ConcurrentThreads.Text = settings.TCPClient_ConcurrentThreads.ToString();
            textBox_Local_UDPPort.Text = settings.UDP_LocalPort.ToString();
            textBox_Remote_UDPPort.Text = settings.UDP_RemotePort.ToString();

            textBox_TCPClient_RemoteIP.Text = settings.TCPClient_RemoteIP;
            textBox_TCPClient_RemotePort.Text = settings.TCPClient_RemotePort.ToString();
            }

        /// <summary>
        /// estblece una conexion UDP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_UDPConnect_Click(object sender, EventArgs e)
            {
            try
                {

            conUDP = new UDPClient(settings.UDP_RemoteIP, settings.UDP_RemotePort);
            conUDP.ReceiveTimeOut = settings.UDP_ReceiveTimeOut;
            conUDP.SendTimeOut = settings.UDP_SendTimeOut;
            conUDP.NewMessageReceived += new UDPClient.NewMessageReceivedEventHandler(onNewUDPMessageFromServer);

            button_UDPConnect.Enabled = false;
            button_UDPDisconnect.Enabled = true;
            button3.Enabled = true;
            conUDP.connect();
            textBox_ConnectionStatus_UDP.AppendText("Conexion establecida con host remoto : " + settings.UDP_RemoteIP.ToString() + ", " + settings.UDP_RemotePort.ToString() + "\n");
                }
            catch (Exception ex)
                {

                textBox_ConnectionStatus_UDP.AppendText(ex.Message + "\n");
                }
            }

        /// <summary>
        /// recibe un mensaje UDP de respuesta 
        /// </summary>
        /// <param name="client"></param>
        private void onNewUDPMessageFromServer(Client client)
            {
            this.textBox_ReceivedUDP_Data.Invoke(onNewUDPClientEvent, NetworkProtocolServices.Utilities.Utilities.ToString(client.InputBuffer));
            }


        /// <summary>
        /// envia un mensaje UDP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
            {
            conUDP.send(NetworkProtocolServices.Utilities.Utilities.GetBytesBigEndian(textBox_SendUDP_Data.Text));
            }

        /// <summary>
        /// cierra una conexion UDP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_UDPDisconnect_Click(object sender, EventArgs e)
            {
            try
                {

            button_UDPConnect.Enabled = true;
            button_UDPDisconnect.Enabled = false;
            button3.Enabled = false;
            conUDP.close();
            textBox_ConnectionStatus_UDP.AppendText("Conexion cerrada" + "\n");
                }
            catch (Exception ex)
                {

                textBox_ConnectionStatus_UDP.AppendText(ex.Message + "\n");
                }
            }





        private void onText_ReceivedUPDClient(string message)
            {
            textBox_ReceivedUDP_Data.AppendText(System.DateTime.Now.ToString() + " - " + message + "\n");
            }

        /// <summary>
        /// este metodo se ejecuta cuando se cambia el valor
        /// de la IP del host remoto (server) TCP
        /// dentro del panel Cliente TCP.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onTCPRremoteIP_Changed(object sender, EventArgs e)
            {
            settings.TCPClient_RemoteIP = textBox_TCPClient_RemoteIP.Text;
            ///actualizo la informacion y/o estado de todos los controles
            ///de configuracion involucrados, asi como el archivo de config.
            propertyGrid_Settings.SelectedObject = settings;
            config.set<Settings>(ref settings);
            }

        /// <summary>
        /// este metodo se ejecuta cuando se cambia el valor
        /// del puerto del host remoto (server) TCP,
        /// dentro del panel Cliente TCP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onTCPRemotePort_Changed(object sender, EventArgs e)
            {
            settings.TCPClient_RemotePort = Convert.ToInt32( textBox_TCPClient_RemotePort.Text);
            ///actualizo la informacion y/o estado de todos los controles
            ///de configuracion involucrados, asi como el archivo de config.
            propertyGrid_Settings.SelectedObject = settings;
            config.set<Settings>(ref settings);
            }

        /// <summary>
        /// este metodo se ejecuta cuando se cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onFormClosing(object sender, FormClosingEventArgs e)
            {
            try
                {
                con.close();
                server.stop();
                conUDP.close();
                }
            catch (Exception)
                {

                Application.Exit();
                }
            }

        private void onTabIndexChanged(object sender, EventArgs e)
            {

            }

        /// <summary>
        /// este metodo se ejecuta cuando se selecciona un nuevo
        /// item de la lista de protocolos disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onProtocolSelectedIndexChanged(object sender, EventArgs e)
            {

            }

        /// <summary>
        /// este metodo se ejecuta cada vez que se selecciona
        /// una nueva solapa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void onTabControlSelected(object sender, TabControlEventArgs e)
        //    {
        //    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //    var settings = configFile.AppSettings.Settings;

        //    if (settings["LastTabControlSelected"] == null)  
        //        {
        //        settings.Add("LastTabControlSelected", e.TabPageIndex.ToString());  
        //        }  
        //        else  
        //        {
        //        settings["LastTabControlSelected"].Value = e.TabPageIndex.ToString();  
        //        }  
        //    settings["LastTabControlSelected"].Value = e.TabPageIndex.ToString();
        //    configFile.Save(ConfigurationSaveMode.Modified);
        //    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name); 
        //    }


        private void getCheckUpdate()
            {
            try
                {
                
                chkUpdate.checkUpdateEncabezado.secuencia = 1;
                chkUpdate.checkUpdateEncabezado.idEmpresa = 49;
                chkUpdate.checkUpdateEncabezado.fragmento = 0;
                chkUpdate.checkUpdateEncabezado.maxBytesRespuesta = 1024;
                //chkUpdate.
                }
            catch (Exception ex)
                {

                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString());
                }

            }

        private void button1_Click_1(object sender, EventArgs e)
            {
            Form2 frm2 = new Form2();
            frm2.Show();
            }

        /// <summary>
        /// este metodo se ejecuta cada vez que se selecciona una solapa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onTabSelected(object sender, TabControlEventArgs e)
            {
            switch (e.TabPageIndex)
                {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    ///crea un nuevo formulario de herramientas
                    Form2 calcCRC32 = new Form2();
                    ///mientras que el formlulario de herramientas
                    ///no exista, creo uno nuevo
                    if (Application.OpenForms.Count ==1)
                        {
                        calcCRC32.MdiParent = this;
                        tabControl1.TabPages[4].Controls.Add(calcCRC32);
                        calcCRC32.Dock = DockStyle.Fill;
                        calcCRC32.Show();
                        }
                    break;
                }
            }

        private void onUDP_IPRemoteHost_Changed(object sender, EventArgs e)
            {
            settings.UDP_RemoteIP = textBox_UDP_RemoteIP.Text;
            ///actualizo la informacion y/o estado de todos los controles
            ///de configuracion involucrados, asi como el archivo de config.
            propertyGrid_Settings.SelectedObject = settings;
            config.set<Settings>(ref settings);
            }

        private void onUDP_LocalPort_TextChanged(object sender, EventArgs e)
            {
            settings.UDP_LocalPort = Convert.ToInt32( textBox_Local_UDPPort.Text);
            ///actualizo la informacion y/o estado de todos los controles
            ///de configuracion involucrados, asi como el archivo de config.
            propertyGrid_Settings.SelectedObject = settings;
            config.set<Settings>(ref settings);
            }

        private void onUDP_RemotePort_TextChanged(object sender, EventArgs e)
            {
            settings.UDP_RemotePort = Convert.ToInt32(textBox_Remote_UDPPort.Text);
            ///actualizo la informacion y/o estado de todos los controles
            ///de configuracion involucrados, asi como el archivo de config.
            propertyGrid_Settings.SelectedObject = settings;
            config.set<Settings>(ref settings);
            }
        }
    }
