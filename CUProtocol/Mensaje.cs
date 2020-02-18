using System;
using System.Collections.Generic;

namespace ClienteConcentrador
{
    public class Mensaje
    {
        private List<byte> mensaje = new List<byte>();

        public int largo
        {
            get
            {
                if (this.mensaje == null)
                {
                    return 0;
                }
                return this.mensaje.Count;
            }
        }

        public Mensaje()
        {
        }

        public void AddStream(byte[] _datos)
        {
            int upperBound = _datos.GetUpperBound(0);
            for (int i = 0; i <= upperBound; i++)
            {
                this.mensaje.Add(_datos[i]);
            }
        }

        public byte[] GetStream()
        {
            byte[] numArray = new byte[this.mensaje.Count];
            int num = 0;
            foreach (byte num1 in this.mensaje)
            {
                numArray[num] = num1;
                num++;
            }
            return numArray;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < this.mensaje.Count; i++)
            {
                byte item = this.mensaje[i];
                str = string.Concat(str, item.ToString("X2"));
            }
            return str;
        }
    }
}