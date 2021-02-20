
namespace RentaCarWfUI.Forms
{
    partial class Form_01_BrandManager
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
        private new void InitializeComponent()
        {
            this.LblBrandName = new System.Windows.Forms.Label();
            this.TbxBrandName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TbxBrandName);
            this.splitContainer1.Panel1.Controls.Add(this.LblBrandName);
            // 
            // LblBrandName
            // 
            this.LblBrandName.AutoSize = true;
            this.LblBrandName.Location = new System.Drawing.Point(10, 17);
            this.LblBrandName.Name = "LblBrandName";
            this.LblBrandName.Size = new System.Drawing.Size(66, 13);
            this.LblBrandName.TabIndex = 0;
            this.LblBrandName.Text = "Brand Name";
            // 
            // TbxBrandName
            // 
            this.TbxBrandName.Location = new System.Drawing.Point(82, 14);
            this.TbxBrandName.Name = "TbxBrandName";
            this.TbxBrandName.Size = new System.Drawing.Size(100, 20);
            this.TbxBrandName.TabIndex = 1;
            // 
            // Form_01_BrandManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form_01_BrandManager";
            this.Load += new System.EventHandler(this.Form_01_BrandManager_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBrandName;
        private System.Windows.Forms.TextBox TbxBrandName;
    }
}
