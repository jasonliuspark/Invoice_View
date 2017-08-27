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
            this.Invoice_Title = new System.Windows.Forms.Label();
            this.Company_Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Recognize_Num = new System.Windows.Forms.TextBox();
            this.Address_num = new System.Windows.Forms.TextBox();
            this.Bank_Account = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Invoice_Title
            // 
            this.Invoice_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Invoice_Title.AutoSize = true;
            this.Invoice_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Invoice_Title.Location = new System.Drawing.Point(549, 0);
            this.Invoice_Title.Name = "Invoice_Title";
            this.Invoice_Title.Size = new System.Drawing.Size(194, 36);
            this.Invoice_Title.TabIndex = 0;
            this.Invoice_Title.Text = "Invoice Serial";
            // 
            // Company_Name
            // 
            this.Company_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Company_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Company_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Company_Name.Location = new System.Drawing.Point(297, 188);
            this.Company_Name.Name = "Company_Name";
            this.Company_Name.Size = new System.Drawing.Size(432, 25);
            this.Company_Name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1070, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate_New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Recognize_Num
            // 
            this.Recognize_Num.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Recognize_Num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Recognize_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Recognize_Num.Location = new System.Drawing.Point(297, 219);
            this.Recognize_Num.Name = "Recognize_Num";
            this.Recognize_Num.Size = new System.Drawing.Size(432, 25);
            this.Recognize_Num.TabIndex = 3;
            // 
            // Address_num
            // 
            this.Address_num.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address_num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Address_num.Location = new System.Drawing.Point(297, 251);
            this.Address_num.Name = "Address_num";
            this.Address_num.Size = new System.Drawing.Size(432, 25);
            this.Address_num.TabIndex = 4;
            // 
            // Bank_Account
            // 
            this.Bank_Account.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bank_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bank_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bank_Account.Location = new System.Drawing.Point(297, 286);
            this.Bank_Account.Name = "Bank_Account";
            this.Bank_Account.Size = new System.Drawing.Size(432, 25);
            this.Bank_Account.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Name});
            this.dataGridView1.Location = new System.Drawing.Point(122, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "货物或应税劳务名称";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Width = 239;
            // 
            // Mainform
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InvoiceView.Properties.Resources.timg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1353, 844);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Bank_Account);
            this.Controls.Add(this.Address_num);
            this.Controls.Add(this.Recognize_Num);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Company_Name);
            this.Controls.Add(this.Invoice_Title);
            this.Name = "Mainform";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainFormDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainFormDragEnter);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        }




        private Label Invoice_Title;
        private TextBox Company_Name;
        private Button button1;
        private TextBox Recognize_Num;
        private TextBox Address_num;
        private TextBox Bank_Account;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Item_Name;
    }
}

