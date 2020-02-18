using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    interface IPlugeable
        {

        /// <summary>
        /// serializa un objeto generico y devuelve un 
        /// array de bytes
        /// </summary>
        /// <typeparam name="T">el tipo de objeto a serializar</typeparam>
        /// <param name="param">el objeto a serializar</param>
        /// <returns></returns>
         byte[] getBytes<T>(T param);

        /// <summary>
        /// obtiene un objeto a partir del
        /// parsing de un array de bytes
        /// </summary>
        /// <param name="param">array de bytes a parsear</param>
        /// <returns></returns>
         object set(byte[] param);


        }

