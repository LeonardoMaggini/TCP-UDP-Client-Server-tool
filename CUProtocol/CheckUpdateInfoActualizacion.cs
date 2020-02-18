using System;

namespace ClienteConcentrador
{
    public class CheckUpdateInfoActualizacion
    {
        public ushort IdTipoUpdate;

        public byte TipoDispositivo;

        public uint Version;

        private ushort Formato;

        private uint Largo;

        public Firma firma;

        private byte[] chkUpdInfoActArray;

        public ushort formato
        {
            get
            {
                return this.Formato;
            }
            set
            {
                this.Formato = value;
            }
        }

        public uint largo
        {
            get
            {
                return this.Largo;
            }
            set
            {
                this.Largo = value;
            }
        }

        public int LargoInfoActualizacion
        {
            get
            {
                return 13 + this.firma.Largo;
            }
        }

        public CheckUpdateInfoActualizacion()
        {
            this.Formato = 0;
            this.Largo = 0;
            this.firma = new Firma();
            this.chkUpdInfoActArray = new byte[this.LargoInfoActualizacion];
        }

        public byte[] GetStream()
        {
            return this.chkUpdInfoActArray;
        }

        public void SetCheckUpdateInfoActualizacionFromMsg(byte[] _msg, int _offset)
        {
            this.IdTipoUpdate = (ushort)(_msg[_offset] * 256 + _msg[_offset + 1]);
            this.TipoDispositivo = _msg[_offset + 2];
            this.Version = (uint)(_msg[_offset + 3] * 256 * 256 * 256 + _msg[_offset + 4] * 256 * 256 + _msg[_offset + 5] * 256 + _msg[_offset + 6]);
            this.Formato = (ushort)(_msg[_offset + 7] * 256 + _msg[_offset + 8]);
            this.Largo = (uint)(_msg[_offset + 9] * 256 * 256 * 256 + _msg[_offset + 10] * 256 * 256 + _msg[_offset + 11] * 256 + _msg[_offset + 12]);
            byte[] numArray = new byte[4];
            Buffer.BlockCopy(_msg, _offset + 13, numArray, 0, this.firma.Largo);
            this.firma.SetFirma(numArray, 4);
            Buffer.BlockCopy(_msg, _offset, this.chkUpdInfoActArray, 0, this.LargoInfoActualizacion);
        }

        public string ToStr(bool _textoNewLine = false, bool decPrint = false)
        {
            string str = "";
            string str1 = "\r";
            if (!_textoNewLine)
            {
                str1 = "";
            }
            str = string.Concat(str, "IdTipoUpdate:", this.IdTipoUpdate.ToString("X4"));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.IdTipoUpdate.ToString());
            }
            str = string.Concat(str, str1, "\nTipoDisposit:", this.TipoDispositivo.ToString("X2"));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.TipoDispositivo.ToString());
            }
            str = string.Concat(str, str1, "\nVersion     :", this.Version.ToString("X8"));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.Version.ToString());
            }
            str = string.Concat(str, str1, "\nFormato     :", this.Formato.ToString("X4"));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.Formato.ToString());
            }
            str = string.Concat(str, str1, "\nLargo       :", this.Largo.ToString("X8"));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.Largo.ToString());
            }
            string str2 = str;
            string[] strArrays = new string[] { str2, str1, "\nFirma       :", this.firma.ToString(), str1, "\n" };
            str = string.Concat(strArrays);
            return str;
        }

        public override string ToString()
        {
            string str = "";
            str = string.Concat(str, this.IdTipoUpdate.ToString("X4"));
            str = string.Concat(str, this.TipoDispositivo.ToString("X2"));
            str = string.Concat(str, this.Version.ToString("X8"));
            str = string.Concat(str, this.Formato.ToString("X4"));
            str = string.Concat(str, this.Largo.ToString("X8"));
            return string.Concat(str, this.firma.ToString());
        }
    }
}