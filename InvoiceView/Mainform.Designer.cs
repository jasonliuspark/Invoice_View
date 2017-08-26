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
            this.SuspendLayout();
            // 
            // Invoice_Title
            // 
            this.Invoice_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Invoice_Title.AutoSize = true;
            this.Invoice_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Invoice_Title.Location = new System.Drawing.Point(500, 0);
            this.Invoice_Title.Name = "Invoice_Title";
            this.Invoice_Title.Size = new System.Drawing.Size(194, 36);
            this.Invoice_Title.TabIndex = 0;
            this.Invoice_Title.Text = "Invoice Serial";
            // 
            // Mainform
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1255, 844);
            this.Controls.Add(this.Invoice_Title);
            this.Name = "Mainform";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainFormDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainFormDragEnter);
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

        //松开鼠标左键触发DragDrop事件
        private void MainFormDragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            //其中 label1.Text显示的就是拖进文件的文件名； 
            Invoice_Title.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private Label Invoice_Title;
    }
}

