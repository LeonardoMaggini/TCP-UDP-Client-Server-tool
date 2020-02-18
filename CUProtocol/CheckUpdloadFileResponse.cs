using System;

namespace ClienteConcentrador
{
    public class CheckUpdloadFileResponse
    {
        public uint Secuencia;

        public ushort IdTipofile;

        public byte TipoDispositivo;

        public uint FileDescriptor;

        public uint OffsetInicial;

        public byte[] Token = new byte[11];

        public CheckUpdloadFileResponse()
        {
            this.Inicializar();
        }

        public byte[] GetStream()
        {
            return Utiles.StringToByteArray(this.ToString());
        }

        public void Inicializar()
        {
            int num = 0;
            uint num1 = (uint)num;
            this.OffsetInicial = (uint)num;
            uint num2 = num1;
            uint num3 = num2;
            this.FileDescriptor = num2;
            this.Secuencia = num3;
            this.IdTipofile = 0;
            this.TipoDispositivo = 0;
            for (int i = 0; i < 11; i++)
            {
                this.Token[i] = 0;
            }
        }

        public void Set(byte[] _stream, ushort _offset)
        {
            this.Secuencia = (uint)(_stream[_offset] * 256 * 256 * 256 + _stream[_offset + 1] * 256 * 256 + _stream[_offset + 2] * 256 + _stream[_offset + 3]);
            this.FileDescriptor = (uint)(_stream[_offset + 4] * 256 * 256 * 256 + _stream[_offset + 5] * 256 * 256 + _stream[_offset + 6] * 256 + _stream[_offset + 7]);
            this.OffsetInicial = (uint)(_stream[_offset + 8] * 256 * 256 * 256 + _stream[_offset + 9] * 256 * 256 + _stream[_offset + 10] * 256 + _stream[_offset + 11]);
            Buffer.BlockCopy(_stream, _offset + 12, this.Token, 0, 11);
        }

        public string ToStr(bool textBoxNewLine = false)
        {
            string str = "";
            string str1 = "";
            if (textBoxNewLine)
            {
                str1 = "\r";
            }
            str = string.Concat(str, str1, "\nSecuencia :", this.Secuencia.ToString("X8"));
            str = string.Concat(str, str1, "\nFileDescri:", this.FileDescriptor.ToString("X8"));
            str = string.Concat(str, str1, "\nOffsetInic:", this.OffsetInicial.ToString("X8"));
            str = string.Concat(str, str1, "\nToken:");
            for (int i = 0; i < 11; i++)
            {
                str = string.Concat(str, this.Token[i].ToString("X2"));
            }
            return str;
        }

        public override string ToString()
        {
            string str = "";
            str = string.Concat(str, this.Secuencia.ToString("X8"));
            str = string.Concat(str, this.FileDescriptor.ToString("X8"));
            str = string.Concat(str, this.OffsetInicial.ToString("X8"));
            for (int i = 0; i < 11; i++)
            {
                str = string.Concat(str, this.Token[i].ToString("X2"));
            }
            return str;
        }
    }
}