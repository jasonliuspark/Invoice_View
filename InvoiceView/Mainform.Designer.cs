using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InvoiceView
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.Invoice_Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Invoice_Details = new System.Windows.Forms.DataGridView();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tax_Payer_Iden = new System.Windows.Forms.TextBox();
            this.Address_Tele = new System.Windows.Forms.TextBox();
            this.Bank_Account = new System.Windows.Forms.TextBox();
            this.Amount_Upper = new System.Windows.Forms.TextBox();
            this.Amount_Low = new System.Windows.Forms.TextBox();
            this.IssueerName = new System.Windows.Forms.TextBox();
            this.Issuer = new System.Windows.Forms.Label();
            this.Company_Name = new System.Windows.Forms.TextBox();
            this.Contract_serial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Invoice_Title
            // 
            this.Invoice_Title.AutoSize = true;
            this.Invoice_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Invoice_Title.Location = new System.Drawing.Point(395, 9);
            this.Invoice_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Invoice_Title.Name = "Invoice_Title";
            this.Invoice_Title.Size = new System.Drawing.Size(129, 25);
            this.Invoice_Title.TabIndex = 0;
            this.Invoice_Title.Text = "Invoice Serial";
            this.Invoice_Title.Click += new System.EventHandler(this.Invoice_Title_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate_New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Invoice_Details
            // 
            this.Invoice_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Invoice_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Name,
            this.Item_Model,
            this.Unit,
            this.Quantity,
            this.Unit_Price,
            this.Amount,
            this.Tax_Rate,
            this.Tax_Amount});
            this.Invoice_Details.Location = new System.Drawing.Point(82, 223);
            this.Invoice_Details.Margin = new System.Windows.Forms.Padding(2);
            this.Invoice_Details.Name = "Invoice_Details";
            this.Invoice_Details.RowTemplate.Height = 28;
            this.Invoice_Details.Size = new System.Drawing.Size(848, 90);
            this.Invoice_Details.TabIndex = 6;
            this.Invoice_Details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "货物或应税劳务名称";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Width = 180;
            // 
            // Item_Model
            // 
            this.Item_Model.HeaderText = "规格型号";
            this.Item_Model.Name = "Item_Model";
            this.Item_Model.Width = 110;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Unit.HeaderText = "单位";
            this.Unit.Name = "Unit";
            this.Unit.Width = 51;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "数量";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 80;
            // 
            // Unit_Price
            // 
            this.Unit_Price.HeaderText = "单价";
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.Width = 85;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "金额";
            this.Amount.Name = "Amount";
            this.Amount.Width = 130;
            // 
            // Tax_Rate
            // 
            this.Tax_Rate.HeaderText = "税率";
            this.Tax_Rate.Name = "Tax_Rate";
            this.Tax_Rate.Width = 54;
            // 
            // Tax_Amount
            // 
            this.Tax_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tax_Amount.HeaderText = "税额";
            this.Tax_Amount.Name = "Tax_Amount";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1011, 589);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tax_Payer_Iden
            // 
            this.Tax_Payer_Iden.Location = new System.Drawing.Point(231, 158);
            this.Tax_Payer_Iden.Name = "Tax_Payer_Iden";
            this.Tax_Payer_Iden.Size = new System.Drawing.Size(336, 21);
            this.Tax_Payer_Iden.TabIndex = 9;
            // 
            // Address_Tele
            // 
            this.Address_Tele.Location = new System.Drawing.Point(231, 182);
            this.Address_Tele.Name = "Address_Tele";
            this.Address_Tele.Size = new System.Drawing.Size(336, 21);
            this.Address_Tele.TabIndex = 10;
            // 
            // Bank_Account
            // 
            this.Bank_Account.Location = new System.Drawing.Point(231, 200);
            this.Bank_Account.Name = "Bank_Account";
            this.Bank_Account.Size = new System.Drawing.Size(336, 21);
            this.Bank_Account.TabIndex = 11;
            // 
            // Amount_Upper
            // 
            this.Amount_Upper.Location = new System.Drawing.Point(322, 416);
            this.Amount_Upper.Name = "Amount_Upper";
            this.Amount_Upper.Size = new System.Drawing.Size(230, 21);
            this.Amount_Upper.TabIndex = 12;
            // 
            // Amount_Low
            // 
            this.Amount_Low.Location = new System.Drawing.Point(757, 417);
            this.Amount_Low.Name = "Amount_Low";
            this.Amount_Low.Size = new System.Drawing.Size(135, 21);
            this.Amount_Low.TabIndex = 13;
            // 
            // IssueerName
            // 
            this.IssueerName.Location = new System.Drawing.Point(713, 101);
            this.IssueerName.Name = "IssueerName";
            this.IssueerName.Size = new System.Drawing.Size(217, 21);
            this.IssueerName.TabIndex = 14;
            // 
            // Issuer
            // 
            this.Issuer.AutoSize = true;
            this.Issuer.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Issuer.Location = new System.Drawing.Point(651, 102);
            this.Issuer.Name = "Issuer";
            this.Issuer.Size = new System.Drawing.Size(56, 16);
            this.Issuer.TabIndex = 15;
            this.Issuer.Text = "开票方";
            // 
            // Company_Name
            // 
            this.Company_Name.Location = new System.Drawing.Point(231, 134);
            this.Company_Name.Name = "Company_Name";
            this.Company_Name.Size = new System.Drawing.Size(336, 21);
            this.Company_Name.TabIndex = 16;
            this.Company_Name.TextChanged += new System.EventHandler(this.Company_Name_TextChanged);
            // 
            // Contract_serial
            // 
            this.Contract_serial.Location = new System.Drawing.Point(198, 89);
            this.Contract_serial.Name = "Contract_serial";
            this.Contract_serial.Size = new System.Drawing.Size(154, 21);
            this.Contract_serial.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.Location = new System.Drawing.Point(104, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "客户合同号";
            // 
            // Mainform
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Contract_serial);
            this.Controls.Add(this.Company_Name);
            this.Controls.Add(this.Issuer);
            this.Controls.Add(this.IssueerName);
            this.Controls.Add(this.Amount_Low);
            this.Controls.Add(this.Amount_Upper);
            this.Controls.Add(this.Bank_Account);
            this.Controls.Add(this.Address_Tele);
            this.Controls.Add(this.Tax_Payer_Iden);
            this.Controls.Add(this.Invoice_Details);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Invoice_Title);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mainform";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainFormDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainFormDragEnter);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        

        private void MainFormDragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            { e.Effect = DragDropEffects.Link;
            }
            else { e.Effect = DragDropEffects.None; }



        }


        //Darg drop
        private void MainFormDragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // retrive label.Text for path 
            Invoice_Title.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();

            TextHandler tx = new TextHandler();

            tx.TextHandler_line(Invoice_Title.Text);
            //populate
            Company_Name.Text = Common.CompanyName;
            Tax_Payer_Iden.Text = Common.TaxerID;
            Address_Tele.Text = Common.AddressPhone;
            Bank_Account.Text = Common.AccountDetails;
            Contract_serial.Text = Common.ContractNum;
            IssueerName.Text = Common.Issuer;
        }




        private Label Invoice_Title;
        private Button button1;
        private DataGridView Invoice_Details;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Item_Name;
        private DataGridViewTextBoxColumn Item_Model;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit_Price;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Tax_Rate;
        private DataGridViewTextBoxColumn Tax_Amount;
        //private TextBox Name;
        private TextBox Tax_Payer_Iden;
        private TextBox Address_Tele;
        private TextBox Bank_Account;
        private TextBox Amount_Upper;
        private TextBox Amount_Low;
        private TextBox IssueerName;
        private Label Issuer;
        private TextBox Company_Name;
        private TextBox Contract_serial;
        private Label label1;
    }
}

