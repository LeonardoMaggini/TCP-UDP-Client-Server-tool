using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace NetworkProtocolServices
    {
    
    /// <summary>
    /// esta clase representa a un cliente que ha establecido
    /// una conexion con el servidor.
    /// Contiene una estructura de datos que representa el 
    /// estado de la conexion y la informacion enviada por
    /// el cliente.
    /// </summary>
   public class Client
        {
       
        #region Enums

        /// <summary>
        /// establece uno de los posibles estados
        /// del cliente.
        /// 1. El cliente ha iniciado su sesion y esta en uso.
        /// 2. El cliente ha finalizado su sesion.
        /// </summary>
        public enum State
            {
            loggedId = 1,
            loggedOut = 2
            }

        #endregion  
       
        #region Properties
        /// <summary>
       /// identificador univoco del cliente (id de sesion¿?)
       /// </summary>
        public int Id { get; set; }
        
       /// <summary>
        /// socket asociado al cliente
        /// </summary>
        private Socket _socket;
        public Socket Socket 
            { 
            get {
                return _socket;} 
            set {
                _socket = value;} 
            }

       /// <summary>
        /// stream de bytes recibidos como payload TCP
       /// </summary>
        public byte[] InputBuffer { get; set; }

       /// <summary>
       /// buffer que contiene el mensaje a ser enviado
       /// </summary>
        public byte[] OutputBuffer { get; set; }

       /// <summary>
       /// fecha/hora del inicion de la conexion
       /// </summary>
        public DateTime DateTimeStartConnection { get; set; }

       /// <summary>
       /// fecha/ hora del fin de la conexion
       /// </summary>
        public DateTime DateTimeEndConnection { get; set; }

        private double _connectionDuration;
       /// <summary>
       /// Duracion de la conexion (en milisegundos)
       /// </summary>
        public double ConectionDuration
            {
            get
                {
                _connectionDuration = DateTimeEndConnection.Subtract(DateTimeStartConnection).TotalMilliseconds;

                return _connectionDuration;
                }
            }

       /// <summary>
       /// devuelve el estado actual del cliente
        /// 1. El cliente ha iniciado su sesion y esta en uso.
        /// 2. El cliente ha finalizado su sesion.
       /// </summary>
        public State SocketState 
            { 
            get 
                { 
                 if(_socket.Connected)
                    {
                    return State.loggedId;
                    }
                 return State.loggedOut;
                } 
            }

        #endregion


        }
    }
