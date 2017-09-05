using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

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



        }

        private void Generate_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdf = new SaveFileDialog();
            sdf.Filter = "invoice(*.txt)|";
            //sdf.FilterIndex = 1;
            sdf.RestoreDirectory = true;
            sdf.FileName = Common.InvoiceSerial+"_New"+".txt";
            if (sdf.ShowDialog() == DialogResult.OK)
            {
               
                string localFilePath = sdf.FileName.ToString();     //获得文件路径 
                using (StreamReader sr = new StreamReader(Invoice_Title.Text,Encoding.Default))
                {
                    String txt = sr.ReadToEnd();
                    Replacer rep = new Replacer();
                    string temp="";

                     txt= rep.Replace_new(Common.CompanyName, Company_Name.Text, txt);
                    txt = rep.Replace_new(Common.TaxerID, Tax_Payer_Iden.Text, txt);
                    txt = rep.Replace_new(Common.AddressPhone, Address_Tele.Text, txt);
                    txt = rep.Replace_new(Common.AccountDetails, Bank_Account.Text, txt);
                    temp = InvoiceNote.Text.Replace("\r\n","\\n");
                    txt = rep.Replace_new(Common.Notes, temp, txt);


                    using (StreamWriter sw = new StreamWriter(localFilePath,false,Encoding.Default))
                    {
                        sw.Write(txt);
                        sw.Flush();
                    }
                }


            }

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Invoice_Title_Click(object sender, EventArgs e)
        {

        }

        private void Company_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            Common.dt.Rows.Clear();
            Binddata();
            for (int i = 0; i < Common.dt.Rows.Count; i++)
            {
                for (int j = 0; j < Common.dt.Columns.Count; j++)
                {
                   Trace.WriteLine(Common.dt.Rows[i][j].ToString());
                }
            }
            
        }

        private void Binddata()
            {
            UpdateDataTable();
            Invoice_Details.AutoGenerateColumns = false;
            Invoice_Details.DataSource = Common.dt;
            Invoice_Details.Columns["Item_Name"].DataPropertyName = "ItemNames";
            Invoice_Details.Columns["Item_Model"].DataPropertyName = "Model";
            Invoice_Details.Columns["Unit"].DataPropertyName = "Unit";
            Invoice_Details.Columns["Quantity"].DataPropertyName = "Quantity";
            Invoice_Details.Columns["Unit_Price"].DataPropertyName = "UnitPrice";
            Invoice_Details.Columns["Amount"].DataPropertyName = "Amount";
            Invoice_Details.Columns["Tax_Rate"].DataPropertyName = "TaxRate";
            Invoice_Details.Columns["Tax_Amount"].DataPropertyName = "TaxAmount";
        }
        private void UpdateDataTable()
        {

            
                // _dt = DataTable("aa");
                Common.dt.Columns.Add("ItemNames", System.Type.GetType("System.String"));
                Common.dt.Columns.Add("Model", System.Type.GetType("System.String"));
                Common.dt.Columns.Add("Unit", System.Type.GetType("System.String"));
                Common.dt.Columns.Add("Quantity", System.Type.GetType("System.Double"));
                Common.dt.Columns.Add("UnitPrice", System.Type.GetType("System.Double"));
                Common.dt.Columns.Add("Amount", System.Type.GetType("System.Double"));
                Common.dt.Columns.Add("TaxRate", System.Type.GetType("System.Double"));
                Common.dt.Columns.Add("TaxAmount", System.Type.GetType("System.Double"));

            //DataRow dr = Common.dt.NewRow();
            //for (int i = 0; i < 2; i++)
            //{
            //    dr = Common.dt.NewRow();
            //    dr["ItemNames"] = "00" + i.ToString();
            //    dr["Model"] = "姓名" + i.ToString();
            //    dr["Quantity"] = 23;
            //    dr["UnitPrice"] = 23.22;
            //    Common.dt.Rows.Add(dr);
            //}
        }

        private void Invoice_Details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Invoice_Details_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            Amount_Low.Text = Subtotal.SubtotalCount(Invoice_Details);
            UperConvert conv = new UperConvert();
            Amount_Upper.Text = conv.Uper(Subtotal.SubtotalCount(Invoice_Details));

        }
    }
}
