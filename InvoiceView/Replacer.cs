using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceView
{
    public  class Replacer
    {
       public Replacer()
        {

        }
        public string Replace_new(string old_v, string new_v, string data_input)
        {
            if (old_v != null && new_v != null)
            { data_input = data_input.Replace(old_v, new_v); }

            return data_input;
        }
    }
}
