using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteConcentrador
    {
   public class Firma
        {

        private int _largo;

        public int Largo
            {
            get { return _largo; }
            set { _largo = value; }
            }


        public void SetFirma(string value)
            {
            }

       public void SetFirma(byte[] numArray, int value)
           {
           }
        }
    }
