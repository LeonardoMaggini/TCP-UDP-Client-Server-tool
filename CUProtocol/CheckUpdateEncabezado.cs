using System;

namespace ClienteConcentrador
{
    public class CheckUpdateEncabezado
    {
        private uint Secuencia;

        private ushort IdEmpresa;

        private byte Fragmento;

        private ushort MaximoBytesRespuesta;

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

        public ushort idEmpresa
        {
            get
            {
                return this.IdEmpresa;
            }
            set
            {
                this.IdEmpresa = value;
            }
        }

        public ushort maxBytesRespuesta
        {
            get
            {
                return this.MaximoBytesRespuesta;
            }
            set
            {
                this.MaximoBytesRespuesta = value;
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

        public CheckUpdateEncabezado()
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
            ushort num1 = (ushort)num;
            this.MaximoBytesRespuesta = (ushort)num;
            ushort num2 = num1;
            ushort num3 = num2;
            this.IdEmpresa = num2;
            this.Secuencia = num3;
            this.Fragmento = 0;
        }

        public override string ToString()
        {
            string str = "";
            if (this.Queformato == 1)
            {
                str = string.Concat(str, this.Secuencia.ToString("X8"));
            }
            str = string.Concat(str, this.IdEmpresa.ToString("X4"));
            if (this.Queformato == 1)
            {
                str = string.Concat(str, this.Fragmento.ToString("X2"));
                str = string.Concat(str, this.MaximoBytesRespuesta.ToString("X4"));
            }
            return str;
        }

        public string ToString(bool _muestraCampos)
        {
            if (!_muestraCampos)
            {
                return this.ToString();
            }
            string str = "";
            if (this.Queformato == 1)
            {
                str = string.Concat(str, "\nSecuencia: ", this.Secuencia.ToString("X8"));
            }
            str = string.Concat(str, "\nIdEmpresa: ", this.IdEmpresa.ToString("X4"));
            if (this.Queformato == 1)
            {
                str = string.Concat(str, "\nFragmento: ", this.Fragmento.ToString("X2"));
                str = string.Concat(str, "\nMax Tamaño Rta: ", this.MaximoBytesRespuesta.ToString("X4"));
            }
            return str;
        }
    }
}