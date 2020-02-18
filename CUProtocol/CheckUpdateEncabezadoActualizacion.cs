using System;

namespace ClienteConcentrador
{
    public class CheckUpdateEncabezadoActualizacion
    {
        private uint Secuencia;

        private uint Timestamp;

        private byte Fragmento;

        public byte[] Token = new byte[11];

        public int LargoEncabezadoActualizacion = 20;

        public byte fragmento
        {
            get
            {
                return this.Fragmento;
            }
            set
            {
                this.Fragmento = value;
            }
        }

        public uint secuencia
        {
            get
            {
                return this.Secuencia;
            }
            set
            {
                this.Secuencia = value;
            }
        }

        public uint timeStamp
        {
            get
            {
                return this.Timestamp;
            }
            set
            {
                this.Timestamp = value;
            }
        }

        public CheckUpdateEncabezadoActualizacion()
        {
            this.Inicializar();
        }

        public byte[] GetStream()
        {
            return Utiles.StringToByteArray(this.ToString());
        }

        private void Inicializar()
        {
            int num = 0;
            uint num1 = (uint)num;
            this.Timestamp = (uint)num;
            this.Secuencia = num1;
            this.Fragmento = 0;
            for (int i = 0; i < 11; i++)
            {
                this.Token[i] = 0;
            }
        }

        public void SetCheckUpdateEncabezadoActualizacionFromMsg(byte[] _msg, int _offset)
        {
            this.secuencia = (uint)(_msg[_offset] * 256 * 256 * 256 + _msg[_offset + 1] * 256 * 256 + _msg[_offset + 2] * 256 + _msg[_offset + 3]);
            this.timeStamp = (uint)(_msg[_offset + 4] * 256 * 256 * 256 + _msg[_offset + 5] * 256 * 256 + _msg[_offset + 6] * 256 + _msg[_offset + 7]);
            this.fragmento = _msg[_offset + 8];
            Buffer.BlockCopy(_msg, _offset + 9, this.Token, 0, 11);
        }

        public override string ToString()
        {
            string str = "";
            str = string.Concat(str, this.Secuencia.ToString("X8"));
            str = string.Concat(str, this.Timestamp.ToString("X8"));
            str = string.Concat(str, this.Fragmento.ToString("X2"));
            for (int i = 0; i < 11; i++)
            {
                str = string.Concat(str, this.Token[i].ToString("X2"));
            }
            return str;
        }
    }
}