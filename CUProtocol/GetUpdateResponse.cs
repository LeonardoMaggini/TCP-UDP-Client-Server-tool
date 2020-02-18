using System;

namespace ClienteConcentrador
{
    public class GetUpdateResponse
    {
        private uint Secuencia;

        private uint OffsetFragmento;

        private byte[] Datos;

        public GetUpdateResponse()
        {
            this.Inicializar();
        }

        public GetUpdateResponse(ushort _largoDatos)
        {
            this.Inicializar();
            this.Datos = new byte[_largoDatos];
            for (int i = 0; i < _largoDatos; i++)
            {
                Buffer.SetByte(this.Datos, i, 0);
            }
        }

        public byte[] GetDatos()
        {
            return this.Datos;
        }

        public string GetDatosAsString()
        {
            int num = 0;
            string str = "";
            if (this.Datos != null)
            {
                num = Buffer.ByteLength(this.Datos);
            }
            for (int i = 0; i < num; i++)
            {
                str = string.Concat(str, this.Datos[i].ToString("X2"));
            }
            return str;
        }

        public uint GetOffSet()
        {
            return this.OffsetFragmento;
        }

        public uint GetSecuencia()
        {
            return this.Secuencia;
        }

        public byte[] GetStream()
        {
            return Utiles.StringToByteArray(this.ToString());
        }

        private void Inicializar()
        {
            int num = 0;
            uint num1 = (uint)num;
            this.OffsetFragmento = (uint)num;
            this.Secuencia = num1;
            this.Datos = null;
        }

        public void Set(byte[] _stream, ushort _offset, ushort _largoStream)
        {
            this.Secuencia = (uint)(_stream[_offset] * 256 * 256 * 256 + _stream[_offset + 1] * 256 * 256 + _stream[_offset + 2] * 256 + _stream[_offset + 3]);
            this.OffsetFragmento = (uint)(_stream[_offset + 4] * 256 * 256 * 256 + _stream[_offset + 5] * 256 * 256 + _stream[_offset + 6] * 256 + _stream[_offset + 7]);
            this.Datos = new byte[_largoStream - 8];
            Buffer.BlockCopy(_stream, _offset + 8, this.Datos, 0, _largoStream - 8);
        }

        public void SetDatos(byte[] _stream, ushort _offset, ushort _largoStream)
        {
            this.Datos = new byte[_largoStream];
            Buffer.BlockCopy(_stream, (int)_offset, this.Datos, 0, (int)_largoStream);
        }

        public override string ToString()
        {
            int num = 0;
            string str = "";
            str = string.Concat(str, this.Secuencia.ToString("X8"));
            str = string.Concat(str, this.OffsetFragmento.ToString("X8"));
            if (this.Datos != null)
            {
                num = Buffer.ByteLength(this.Datos);
            }
            for (int i = 0; i < num; i++)
            {
                str = string.Concat(str, this.Datos[i].ToString("X2"));
            }
            return str;
        }
    }
}