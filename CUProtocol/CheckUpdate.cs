using System;
using System.Collections.Generic;

namespace ClienteConcentrador
{
    public class CheckUpdate
    {
        private byte sentido = 1;

        public CheckUpdateEncabezado checkUpdateEncabezado;

        private List<CheckUpdateInfoUpdate> infoUpdateList = new List<CheckUpdateInfoUpdate>();

        private int Queformato = 1;

        public int CantidadInfoUpdate
        {
            get
            {
                return this.infoUpdateList.Count;
            }
        }

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

        public ushort LargoCheckUpdate
        {
            get
            {
                if (this.FormatoMensaje == 1)
                {
                    return (ushort)(9 + this.infoUpdateList.Count * 7);
                }
                return (ushort)(2 + this.infoUpdateList.Count * 6);
            }
        }

        public byte Sentido
        {
            get
            {
                return this.sentido;
            }
        }

        public CheckUpdate()
        {
            this.checkUpdateEncabezado = new CheckUpdateEncabezado()
            {
                FormatoMensaje = this.FormatoMensaje
            };
        }

        public void AddInfoUpdate(CheckUpdateInfoUpdate _infoUpdate)
        {
            _infoUpdate.FormatoMensaje = this.FormatoMensaje;
            this.infoUpdateList.Add(_infoUpdate);
        }

        public byte[] GetStream()
        {
            byte[] stream = this.checkUpdateEncabezado.GetStream();
            int upperBound = 0;
            if (this.infoUpdateList != null && this.infoUpdateList.Count > 0)
            {
                foreach (CheckUpdateInfoUpdate checkUpdateInfoUpdate in this.infoUpdateList)
                {
                    upperBound = upperBound + checkUpdateInfoUpdate.GetStream().GetUpperBound(0) + 1;
                }
            }
            int length = stream.GetLength(0);
            byte[] numArray = new byte[length + upperBound];
            Buffer.BlockCopy(stream, 0, numArray, 0, length);
            if (this.infoUpdateList != null && this.infoUpdateList.Count > 0)
            {
                int num = length;
                foreach (CheckUpdateInfoUpdate checkUpdateInfoUpdate1 in this.infoUpdateList)
                {
                    byte[] stream1 = checkUpdateInfoUpdate1.GetStream();
                    int length1 = stream1.GetLength(0);
                    Buffer.BlockCopy(stream1, 0, numArray, num, length1);
                    num += length1;
                }
            }
            return numArray;
        }

        public void SetFormato(int _formato)
        {
            this.FormatoMensaje = _formato;
            this.checkUpdateEncabezado.FormatoMensaje = _formato;
        }

        public override string ToString()
        {
            string str = "";
            str = string.Concat(str, this.checkUpdateEncabezado.ToString());
            if (this.infoUpdateList.Count > 0)
            {
                foreach (CheckUpdateInfoUpdate checkUpdateInfoUpdate in this.infoUpdateList)
                {
                    str = string.Concat(str, checkUpdateInfoUpdate.ToString());
                }
            }
            return str;
        }

        public string ToString(bool _muestraNombreCampos)
        {
            if (!_muestraNombreCampos)
            {
                return this.ToString();
            }
            string str = "";
            str = string.Concat(str, this.checkUpdateEncabezado.ToString(_muestraNombreCampos));
            if (this.infoUpdateList.Count > 0)
            {
                foreach (CheckUpdateInfoUpdate checkUpdateInfoUpdate in this.infoUpdateList)
                {
                    str = string.Concat(str, checkUpdateInfoUpdate.ToString(_muestraNombreCampos));
                }
            }
            return str;
        }
    }
}