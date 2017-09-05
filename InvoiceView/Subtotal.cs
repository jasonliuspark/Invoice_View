using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace InvoiceView
{
    public static class Subtotal
    {
        public static string SubtotalCount(DataGridView dtv)
        {
            //string result="";
            double amount = 0;
            for (int i = 0; i < dtv.Rows.Count - 1; i++)
            {
                double temp1 = 0; 
                double temp2=0;
                double.TryParse(dtv.Rows[i].Cells[5].Value.ToString(),out temp1);
                double.TryParse(dtv.Rows[i].Cells[7].Value.ToString(),out temp2);
                amount +=temp1+temp2;

            }

            return amount.ToString();
        }

        public static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?/d*[.]?/d*$");
        }
        
    }
}
