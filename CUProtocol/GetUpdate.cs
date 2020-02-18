using System;

namespace ClienteConcentrador
{
    public class GetUpdate
    {
        private uint _secuencia;

        private ushort _idempresa;

        private ushort _idtipoupdate;

        private byte _tipodispositivo;

        private uint _version;

        private uint _offsetfragmento;

        private ushort _largofragmento;

        public bool inicio = true;

        public ushort IdEmpresa
        {
            get
            {
                return this._idempresa;
            }
            set
            {
                this._idempresa = value;
            }
        }

        public ushort IdTipoUpdate
        {
            get
            {
                return this._idtipoupdate;
            }
            set
            {
                this._idtipoupdate = value;
            }
        }

        public ushort LargoFragmento
        {
            get
            {
                return this._largofragmento;
            }
            set
            {
                this._largofragmento = value;
            }
        }

        public uint OffsetFragmento
        {
            get
            {
                return this._offsetfragmento;
            }
            set
            {
                this._offsetfragmento = value;
            }
        }

        public uint Secuencia
        {
            get
            {
                return this._secuencia;
            }
            set
            {
                this._secuencia = value;
            }
        }

        public byte TipoDispositivo
        {
            get
            {
                return this._tipodispositivo;
            }
            set
            {
                this._tipodispositivo = value;
            }
        }

        public uint Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }

        public GetUpdate()
        {
            this.Inicializar();
        }

        public int GetLargo()
        {
            return 19;
        }

        public uint GetNewOffset(uint nextFrag)
        {
            if (nextFrag == 0)
            {
                this.OffsetFragmento = 0;
                this.inicio = true;
                return this.OffsetFragmento;
            }
            if (!this.inicio)
            {
                this.OffsetFragmento = this.OffsetFragmento + nextFrag;
            }
            this.inicio = false;
            return this.OffsetFragmento;
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
            uint num2 = num1;
            uint num3 = num2;
            this.Version = num2;
            this.Secuencia = num3;
            int num4 = 0;
            ushort num5 = (ushort)num4;
            this.LargoFragmento = (ushort)num4;
            ushort num6 = num5;
            ushort num7 = num6;
            this.IdTipoUpdate = num6;
            this.IdEmpresa = num7;
            this.TipoDispositivo = 0;
        }

        public string ToStr(bool decPrint, bool esIda = true)
        {
            string str = "";
            str = string.Concat(str, "\r\nSecuencia: ");
            uint secuencia = this.Secuencia;
            str = string.Concat(str, secuencia.ToString("X8"));
            if (decPrint)
            {
                uint num = this.Secuencia;
                str = string.Concat(str, ":", num.ToString());
            }
            if (esIda)
            {
                str = string.Concat(str, "\r\nIdEmpresa: ");
                ushort idEmpresa = this.IdEmpresa;
                str = string.Concat(str, idEmpresa.ToString("X4"));
                if (decPrint)
                {
                    ushort idEmpresa1 = this.IdEmpresa;
                    str = string.Concat(str, ":", idEmpresa1.ToString());
                }
                str = string.Concat(str, "\r\nIdTipoUpdate: ");
                ushort idTipoUpdate = this.IdTipoUpdate;
                str = string.Concat(str, idTipoUpdate.ToString("X4"));
                if (decPrint)
                {
                    ushort idTipoUpdate1 = this.IdTipoUpdate;
                    str = string.Concat(str, ":", idTipoUpdate1.ToString());
                }
                str = string.Concat(str, "\r\nTipoDispositivo: ");
                byte tipoDispositivo = this.TipoDispositivo;
                str = string.Concat(str, tipoDispositivo.ToString("X2"));
                if (decPrint)
                {
                    byte tipoDispositivo1 = this.TipoDispositivo;
                    str = string.Concat(str, ":", tipoDispositivo1.ToString());
                }
                str = string.Concat(str, "\r\nVersion: ");
                uint version = this.Version;
                str = string.Concat(str, version.ToString("X8"));
                if (decPrint)
                {
                    uint version1 = this.Version;
                    str = string.Concat(str, ":", version1.ToString());
                }
            }
            str = string.Concat(str, "\r\nOffsetFragmento: ");
            uint offsetFragmento = this.OffsetFragmento;
            str = string.Concat(str, offsetFragmento.ToString("X8"));
            if (decPrint)
            {
                uint offsetFragmento1 = this.OffsetFragmento;
                str = string.Concat(str, ":", offsetFragmento1.ToString());
            }
            if (esIda)
            {
                str = string.Concat(str, "\r\nLargoFragmento: ");
                ushort largoFragmento = this.LargoFragmento;
                str = string.Concat(str, largoFragmento.ToString("X4"));
                if (decPrint)
                {
                    ushort largoFragmento1 = this.LargoFragmento;
                    str = string.Concat(str, ":", largoFragmento1.ToString());
                }
            }
            return str;
        }

        public override string ToString()
        {
            string str = "";
            uint secuencia = this.Secuencia;
            str = string.Concat(str, secuencia.ToString("X8"));
            ushort idEmpresa = this.IdEmpresa;
            str = string.Concat(str, idEmpresa.ToString("X4"));
            ushort idTipoUpdate = this.IdTipoUpdate;
            str = string.Concat(str, idTipoUpdate.ToString("X4"));
            byte tipoDispositivo = this.TipoDispositivo;
            str = string.Concat(str, tipoDispositivo.ToString("X2"));
            uint version = this.Version;
            str = string.Concat(str, version.ToString("X8"));
            uint offsetFragmento = this.OffsetFragmento;
            str = string.Concat(str, offsetFragmento.ToString("X8"));
            ushort largoFragmento = this.LargoFragmento;
            str = string.Concat(str, largoFragmento.ToString("X4"));
            return str;
        }
    }
}