using System;

namespace ClienteConcentrador
{
    public class DatosMensaje
    {
        private ushort _IdEmpresa;

        private byte _Fragmento;

        private ushort _MaximoBytesRespuesta;

        private bool _Activo_1;

        private ushort _IdTipoUpdate_1;

        private byte _TipoDispositivo_1;

        private uint _Version_1;

        public bool Activo_1
        {
            get
            {
                return this._Activo_1;
            }
            set
            {
                this._Activo_1 = value;
            }
        }

        public byte Fragmento
        {
            get
            {
                return this._Fragmento;
            }
            set
            {
                this._Fragmento = value;
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

        public ushort IdTipoUpdate_1
        {
            get
            {
                return this._IdTipoUpdate_1;
            }
            set
            {
                this._IdTipoUpdate_1 = value;
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

        public byte TipoDispositivo_1
        {
            get
            {
                return this._TipoDispositivo_1;
            }
            set
            {
                this._TipoDispositivo_1 = value;
            }
        }

        public uint Version_1
        {
            get
            {
                return this._Version_1;
            }
            set
            {
                this._Version_1 = value;
            }
        }

        public DatosMensaje()
        {
        }
    }
}