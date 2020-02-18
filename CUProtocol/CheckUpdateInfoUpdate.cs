using System;

namespace ClienteConcentrador
{
    public class CheckUpdateInfoUpdate
    {
        private ushort IdTipoUpdate;

        private byte tipoDispositivo;

        private uint Version;

        private int Queformato = 1;

        public int FormatoMensaje
        {
            get
            {
                return this.Queformato;
            }
            set
            {
                this.Queformato = value;
            }
        }

        public byte IdDispositivo
        {
            get
            {
                return this.tipoDispositivo;
            }
            set
            {
                this.tipoDispositivo = value;
            }
        }

        public ushort idTipoUpdate
        {
            get
            {
                return this.IdTipoUpdate;
            }
            set
            {
                this.IdTipoUpdate = value;
            }
        }

        public uint version
        {
            get
            {
                return this.Version;
            }
            set
            {
                this.Version = value;
            }
        }

        public CheckUpdateInfoUpdate()
        {
            this.IdTipoUpdate = 0;
            this.Version = 0;
            this.tipoDispositivo = 0;
        }

        public byte[] GetStream()
        {
            return Utiles.StringToByteArray(this.ToString());
        }

        public string ToStr(bool printTitle, bool decPrint = false)
        {
            string str = "";
            if (printTitle)
            {
                str = string.Concat(str, "\r\nId TipoUpdate: ");
            }
            str = (this.FormatoMensaje != 1 ? string.Concat(str, this.IdTipoUpdate.ToString("X2")) : string.Concat(str, this.IdTipoUpdate.ToString("X4")));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.IdTipoUpdate.ToString());
            }
            if (printTitle)
            {
                str = string.Concat(str, "\r\nTipo Dispositivo: ");
            }
            str = string.Concat(str, this.tipoDispositivo.ToString("X2"));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.tipoDispositivo.ToString());
            }
            if (printTitle)
            {
                str = string.Concat(str, "\r\nVersion: ");
            }
            str = string.Concat(str, this.Version.ToString("X8"));
            if (decPrint)
            {
                str = string.Concat(str, ":", this.Version.ToString());
            }
            if (printTitle)
            {
                str = string.Concat(str, "\r\n");
            }
            return str;
        }

        public override string ToString()
        {
            return this.ToStr(false, false);
        }

        public string ToString(bool _muestraCampos)
        {
            if (!_muestraCampos)
            {
                return this.ToString();
            }
            string str = "";
            str = (this.FormatoMensaje != 1 ? string.Concat(str, "\nId Tipo Update: ", this.IdTipoUpdate.ToString("X2")) : string.Concat(str, "\nId Tipo Update: ", this.IdTipoUpdate.ToString("X4")));
            byte idDispositivo = this.IdDispositivo;
            str = string.Concat(str, "\nTipo Dispositivo: ", idDispositivo.ToString("X2"));
            str = string.Concat(str, "\nVersion: ", this.Version.ToString("X8"));
            return str;
        }
    }
}