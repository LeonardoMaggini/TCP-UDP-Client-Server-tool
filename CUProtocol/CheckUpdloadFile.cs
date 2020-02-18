using System;
using System.Text;

namespace ClienteConcentrador
{
    public class CheckUpdloadFile
    {
        private uint _Secuencia;

        private ushort _IdEmpresa;

        private ushort _IdTipofile;

        private byte _TipoDispositivo;

        private ushort _Formato;

        private uint _Largo;

        private Firma _firma = new Firma();

        private byte[] _Nombre = new byte[60];

        private string _path;

        private ushort _largoDatos;

        public string firma
        {
            get
            {
                return this._firma.ToString();
            }
            set
            {
                this._firma.SetFirma(value);
            }
        }

        public ushort Formato
        {
            get
            {
                return this._Formato;
            }
            set
            {
                this._Formato = value;
            }
        }

        public ushort IdEmpresa
        {
            get
            {
                return this._IdEmpresa;
            }
            set
            {
                this._IdEmpresa = value;
            }
        }

        public ushort IdTipofile
        {
            get
            {
                return this._IdTipofile;
            }
            set
            {
                this._IdTipofile = value;
            }
        }

        public uint Largo
        {
            get
            {
                return this._Largo;
            }
            set
            {
                this._Largo = value;
            }
        }

        public ushort LargoDatosAEnviar
        {
            get
            {
                return this._largoDatos;
            }
            set
            {
                this._largoDatos = value;
            }
        }

        public string Nombre
        {
            get
            {
                return Encoding.Default.GetString(this._Nombre);
            }
            set
            {
                this._Nombre = new byte[value.Trim().Length];
                this._Nombre = Encoding.UTF8.GetBytes(value.Trim());
            }
        }

        public string Path
        {
            get
            {
                return this._path;
            }
            set
            {
                this._path = value;
            }
        }

        public uint Secuencia
        {
            get
            {
                return this._Secuencia;
            }
            set
            {
                this._Secuencia = value;
            }
        }

        public byte TipoDispositivo
        {
            get
            {
                return this._TipoDispositivo;
            }
            set
            {
                this._TipoDispositivo = value;
            }
        }

        public CheckUpdloadFile()
        {
            this.Inicializar();
        }

        private string GetHexaString()
        {
            string str = "";
            uint secuencia = this.Secuencia;
            str = string.Concat(str, secuencia.ToString("X8"));
            ushort idEmpresa = this.IdEmpresa;
            str = string.Concat(str, idEmpresa.ToString("X4"));
            ushort idTipofile = this.IdTipofile;
            str = string.Concat(str, idTipofile.ToString("X4"));
            byte tipoDispositivo = this.TipoDispositivo;
            str = string.Concat(str, tipoDispositivo.ToString("X2"));
            ushort formato = this.Formato;
            str = string.Concat(str, formato.ToString("X4"));
            uint largo = this.Largo;
            str = string.Concat(str, largo.ToString("X8"));
            return string.Concat(str, this.firma);
        }

        public ushort GetLength()
        {
            return (ushort)((int)this.GetStream().Length);
        }

        public byte[] GetStream()
        {
            byte[] numArray = new byte[(int)Utiles.StringToByteArray(this.GetHexaString()).Length + this.Nombre.Length];
            Buffer.BlockCopy(Utiles.StringToByteArray(this.GetHexaString()), 0, numArray, 0, (int)Utiles.StringToByteArray(this.GetHexaString()).Length);
            Buffer.BlockCopy(this._Nombre, 0, numArray, (int)Utiles.StringToByteArray(this.GetHexaString()).Length, this.Nombre.Length);
            return numArray;
        }

        public void Inicializar()
        {
            int num = 0;
            uint num1 = (uint)num;
            this.Largo = (uint)num;
            this.Secuencia = num1;
            int num2 = 0;
            ushort num3 = (ushort)num2;
            this.Formato = (ushort)num2;
            ushort num4 = num3;
            ushort num5 = num4;
            this.IdTipofile = num4;
            this.IdEmpresa = num5;
            this.TipoDispositivo = 0;
            this.Nombre = "";
            this.firma = "";
            this.LargoDatosAEnviar = 2048;
        }

        public override string ToString()
        {
            string str = "";
            uint secuencia = this.Secuencia;
            str = string.Concat(str, secuencia.ToString("X8"));
            ushort idEmpresa = this.IdEmpresa;
            str = string.Concat(str, idEmpresa.ToString("X4"));
            ushort idTipofile = this.IdTipofile;
            str = string.Concat(str, idTipofile.ToString("X4"));
            byte tipoDispositivo = this.TipoDispositivo;
            str = string.Concat(str, tipoDispositivo.ToString("X2"));
            ushort formato = this.Formato;
            str = string.Concat(str, formato.ToString("X4"));
            uint largo = this.Largo;
            str = string.Concat(str, largo.ToString("X8"));
            str = string.Concat(str, this.firma.ToString());
            return string.Concat(str, this.Nombre);
        }
    }
}