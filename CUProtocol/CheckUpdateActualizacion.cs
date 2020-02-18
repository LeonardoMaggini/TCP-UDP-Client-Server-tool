using System;
using System.Collections.Generic;

namespace ClienteConcentrador
{
    public class CheckUpdateActualizacion
    {
        private byte sentido = 2;

        private CheckUpdateEncabezadoActualizacion checkUpdateEncabezadoActualizacion;

        private List<CheckUpdateInfoActualizacion> infoActualizacionList = new List<CheckUpdateInfoActualizacion>();

        public int CantidadInfoActualizacion
        {
            get
            {
                return this.infoActualizacionList.Count;
            }
        }

        public byte Sentido
        {
            get
            {
                return this.sentido;
            }
        }

        public CheckUpdateActualizacion()
        {
            this.checkUpdateEncabezadoActualizacion = new CheckUpdateEncabezadoActualizacion();
        }

        public void AddInfoActualizacion(CheckUpdateInfoActualizacion _infoActualizacion)
        {
            this.infoActualizacionList.Add(_infoActualizacion);
        }

        public byte[] GetStream()
        {
            byte[] stream = this.checkUpdateEncabezadoActualizacion.GetStream();
            int upperBound = 0;
            if (this.infoActualizacionList != null && this.infoActualizacionList.Count > 0)
            {
                foreach (CheckUpdateInfoActualizacion checkUpdateInfoActualizacion in this.infoActualizacionList)
                {
                    upperBound += checkUpdateInfoActualizacion.GetStream().GetUpperBound(0);
                }
            }
            byte[] numArray = new byte[stream.GetUpperBound(0) + upperBound];
            Buffer.BlockCopy(stream, 0, numArray, 0, stream.GetUpperBound(0));
            if (this.infoActualizacionList != null && this.infoActualizacionList.Count > 0)
            {
                int num = stream.GetUpperBound(0);
                foreach (CheckUpdateInfoActualizacion checkUpdateInfoActualizacion1 in this.infoActualizacionList)
                {
                    byte[] stream1 = checkUpdateInfoActualizacion1.GetStream();
                    int upperBound1 = stream1.GetUpperBound(0);
                    Buffer.BlockCopy(stream1, 0, numArray, num, upperBound1);
                    num += upperBound1;
                }
            }
            return numArray;
        }

        public override string ToString()
        {
            string str = "";
            str = string.Concat(str, this.checkUpdateEncabezadoActualizacion.ToString());
            if (this.infoActualizacionList.Count > 0)
            {
                foreach (CheckUpdateInfoActualizacion checkUpdateInfoActualizacion in this.infoActualizacionList)
                {
                    str = string.Concat(str, checkUpdateInfoActualizacion.ToString());
                }
            }
            return str;
        }
    }
}