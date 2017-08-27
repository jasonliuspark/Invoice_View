using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceView
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

            int high = this.Height;
            int width = this.Width;

            Company_Name.Height = high / 4 - 5;

            Company_Name.Width = width / 4 - 5;


        }

        private void Generate_Click(object sender, EventArgs e)
        {

        }
    }
}
