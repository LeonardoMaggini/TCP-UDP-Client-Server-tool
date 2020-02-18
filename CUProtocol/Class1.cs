using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugIn
{
    public class EntryPointClass:IPlugeable

    {

    byte[] IPlugeable.getBytes<T>(T param)
        {
        throw new NotImplementedException();
        }


    object IPlugeable.set(byte[] param)
        {
        throw new NotImplementedException();
        }


    }
}
