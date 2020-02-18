using System;
using System.ComponentModel;

namespace ClienteConcentrador
{
    public class Header
    {
        public const byte IDA = 1;

        public const byte VUELTA = 2;

        public const ushort LARGO_HEADER = 12;

        public byte IdSistema;

        public byte VersionProtocolo;

        public byte Comando;

        public byte TipoDispositivo;

        public uint IdTerminal;

        public ushort Longitud;

        public ushort idEmpresa;

        public byte _Fragmento;

        public ushort _MaximoBytesRespuesta;

        public int CantEstrucInfoUpdate;

        public ushort CodigoRespuesta;

        public byte sentido;

        public uint secuencia;

        private bool _modifCRC;

        [Browsable(false)]
        public int CantEstrucInfoUpd
        {
            get
            {
                return this.CantEstrucInfoUpdate;
            }
            set
            {
                if (value >= 1 && value <= 8)
                {
                    this.CantEstrucInfoUpdate = value;
                }
            }
        }

        public ushort codigoRespusta
        {
            get
            {
                return this.CodigoRespuesta;
            }
        }

        public byte comando
        {
            get
            {
                return this.Comando;
            }
            set
            {
                this.Comando = value;
            }
        }

        public bool EsRespueta
        {
            get
            {
                if (this.sentido == 2)
                {
                    return true;
                }
                return false;
            }
        }

        public ushort IdEmpresa
        {
            get
            {
                return this.idEmpresa;
            }
            set
            {
                this.idEmpresa = value;
            }
        }

        public byte idSistema
        {
            get
            {
                return this.IdSistema;
            }
            set
            {
                this.IdSistema = value;
            }
        }

        public uint idTerminal
        {
            get
            {
                return this.IdTerminal;
            }
            set
            {
                this.IdTerminal = value;
            }
        }

        public ushort longitudDatos
        {
            get
            {
                return this.Longitud;
            }
            set
            {
                this.Longitud = value;
            }
        }

        public ushort MaximoBytesRespuesta
        {
            get
            {
                return this._MaximoBytesRespuesta;
            }
            set
            {
                this._MaximoBytesRespuesta = value;
            }
        }

        public bool modificaCRC
        {
            get
            {
                return this._modifCRC;
            }
            set
            {
                this._modifCRC = value;
            }
        }

        public uint Secuencia
        {
            get
            {
                return this.secuencia;
            }
            set
            {
                this.secuencia = value;
            }
        }

        public byte tipoDispositivo
        {
            get
            {
                return this.TipoDispositivo;
            }
            set
            {
                this.TipoDispositivo = value;
            }
        }

        public byte versionProtocolo
        {
            get
            {
                return this.VersionProtocolo;
            }
            set
            {
                this.VersionProtocolo = value;
            }
        }

        public Header()
        {
            this.Inicializar();
            this.sentido = 1;
        }

        public Header(byte _sentido)
        {
            this.Inicializar();
            this.sentido = _sentido;
        }

        public uint GetSecuencia()
        {
            this.secuencia++;
            return this.Secuencia;
        }

        public byte[] GetStream()
        {
            return Utiles.StringToByteArray(this.ToString());
        }

        private void Inicializar()
        {
            int num = 0;
            byte num1 = (byte)num;
            this.TipoDispositivo = (byte)num;
            byte num2 = num1;
            byte num3 = num2;
            this.Comando = num2;
            byte num4 = num3;
            byte num5 = num4;
            this.VersionProtocolo = num4;
            this.IdSistema = num5;
            int num6 = 0;
            ushort num7 = (ushort)num6;
            this.Longitud = (ushort)num6;
            this.IdTerminal = num7;
            this.CodigoRespuesta = 0;
        }

        public bool SetHeaderFromMsg(byte _sentido, byte[] _msg)
        {
            int num = 10;
            int num1 = 3;
            this.Inicializar();
            this.sentido = _sentido;
            if (this.sentido == 2)
            {
                num = 12;
            }
            if ((int)_msg.Length < num)
            {
                return false;
            }
            this.IdSistema = _msg[0];
            this.VersionProtocolo = _msg[1];
            this.Comando = _msg[2];
            if (this.sentido == 2)
            {
                this.CodigoRespuesta = (ushort)(_msg[3] * 256 + _msg[4]);
                num1 = 5;
            }
            this.TipoDispositivo = _msg[num1];
            this.IdTerminal = (uint)(_msg[num1 + 1] * 256 * 256 * 256 + _msg[num1 + 2] * 256 * 256 + _msg[num1 + 3] * 256 + _msg[num1 + 4]);
            this.Longitud = (ushort)(_msg[num1 + 5] * 256 + _msg[num1 + 6]);
            return true;
        }

        public override string ToString()
        {
            string str = "";
            str = string.Concat(str, this.IdSistema.ToString("X2"));
            str = string.Concat(str, this.VersionProtocolo.ToString("X2"));
            str = string.Concat(str, this.Comando.ToString("X2"));
            if (this.sentido == 2)
            {
                str = string.Concat(str, this.CodigoRespuesta.ToString("X4"));
            }
            str = string.Concat(str, this.TipoDispositivo.ToString("X2"));
            str = string.Concat(str, this.IdTerminal.ToString("X8"));
            str = string.Concat(str, this.Longitud.ToString("X4"));
            return str;
        }

        public string ToString(bool _muestraNombreCampos, bool _textboxNewLine = false, bool decPrint = false)
        {
            if (!_muestraNombreCampos)
            {
                return this.ToString();
            }
            string str = "";
            string str1 = "\r";
            if (!_textboxNewLine)
            {
                str1 = "";
            }
            str = string.Concat(str, "IdSistema: ", this.IdSistema.ToString("X2"));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.IdSistema.ToString());
            }
            str = string.Concat(str, str1, "\nVersionProtocolo: ", this.VersionProtocolo.ToString("X2"));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.VersionProtocolo.ToString());
            }
            str = string.Concat(str, str1, "\nComando: ", this.Comando.ToString("X2"));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.Comando.ToString());
            }
            if (this.sentido == 2)
            {
                str = string.Concat(str, str1, "\nCodigo Rta: ", this.CodigoRespuesta.ToString("X4"));
                if (decPrint)
                {
                    str = string.Concat(str, ":", this.CodigoRespuesta.ToString());
                }
            }
            str = string.Concat(str, str1, "\nTipo dispositivo: ", this.TipoDispositivo.ToString("X2"));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.TipoDispositivo.ToString());
            }
            str = string.Concat(str, str1, "\nId Terminal: ", this.IdTerminal.ToString("X8"));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.IdTerminal.ToString());
            }
            str = string.Concat(str, str1, "\nLongitud: ", this.Longitud.ToString("X4"));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.Longitud.ToString());
            }
            return str;
        }
    }
}