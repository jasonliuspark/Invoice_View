using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

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

                amount += double.Parse(dtv.Rows[i].Cells[5].Value.ToString()) + double.Parse(dtv.Rows[i].Cells[7].Value.ToString());

            }

            return amount.ToString();
        }

    }
}
