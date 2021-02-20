using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace RentaCarWfUI.Forms
{
    partial class EntitiesFormBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
        protected void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntitiesFormBase));
            this.ToolStripMenu = new System.Windows.Forms.ToolStrip();
            this.BtnFirstRow = new System.Windows.Forms.ToolStripButton();
            this.BtnPrevious = new System.Windows.Forms.ToolStripButton();
            this.LblCounter = new System.Windows.Forms.ToolStripLabel();
            this.BtnNext = new System.Windows.Forms.ToolStripButton();
            this.BtnLastRow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.BtnAdd = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnFind = new System.Windows.Forms.ToolStripButton();
            this.TbxId = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DgvTable = new System.Windows.Forms.DataGridView();
            this.ToolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripMenu
            // 
            this.ToolStripMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnFirstRow,
            this.BtnPrevious,
            this.LblCounter,
            this.BtnNext,
            this.BtnLastRow,
            this.toolStripSeparator1,
            this.BtnSave,
            this.BtnAdd,
            this.BtnDelete,
            this.toolStripSeparator2,
            this.BtnFind,
            this.TbxId});
            this.ToolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.ToolStripMenu.Name = "ToolStripMenu";
            this.ToolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStripMenu.Size = new System.Drawing.Size(800, 25);
            this.ToolStripMenu.TabIndex = 14;
            this.ToolStripMenu.Text = "toolStrip1";
            // 
            // BtnFirstRow
            // 
            this.BtnFirstRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFirstRow.Image = ((System.Drawing.Image)(resources.GetObject("BtnFirstRow.Image")));
            this.BtnFirstRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFirstRow.Name = "BtnFirstRow";
            this.BtnFirstRow.Size = new System.Drawing.Size(23, 22);
            this.BtnFirstRow.Text = "İlk Kayıt";
            this.BtnFirstRow.Click += new System.EventHandler(this.BtnFirstRow_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrevious.Image")));
            this.BtnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(23, 22);
            this.BtnPrevious.Text = "Geri";
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // LblCounter
            // 
            this.LblCounter.Name = "LblCounter";
            this.LblCounter.Size = new System.Drawing.Size(26, 22);
            this.LblCounter.Text = "0/0";
            // 
            // BtnNext
            // 
            this.BtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(23, 22);
            this.BtnNext.Text = "İleri";
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLastRow
            // 
            this.BtnLastRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnLastRow.Image = ((System.Drawing.Image)(resources.GetObject("BtnLastRow.Image")));
            this.BtnLastRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLastRow.Name = "BtnLastRow";
            this.BtnLastRow.Size = new System.Drawing.Size(23, 22);
            this.BtnLastRow.Text = "Son Kayıt";
            this.BtnLastRow.Click += new System.EventHandler(this.BtnLastRow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(23, 22);
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(23, 22);
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(23, 22);
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnFind
            // 
            this.BtnFind.Image = ((System.Drawing.Image)(resources.GetObject("BtnFind.Image")));
            this.BtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(45, 22);
            this.BtnFind.Text = "Ara";
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // TbxId
            // 
            this.TbxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxId.Name = "TbxId";
            this.TbxId.Size = new System.Drawing.Size(100, 25);
            this.TbxId.TextChanged += new System.EventHandler(this.TbxId_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvTable);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 78;
            this.splitContainer1.TabIndex = 15;
            // 
            // DgvTable
            // 
            this.DgvTable.BackgroundColor = System.Drawing.Color.White;
            this.DgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvTable.Location = new System.Drawing.Point(0, 0);
            this.DgvTable.Name = "DgvTable";
            this.DgvTable.Size = new System.Drawing.Size(796, 339);
            this.DgvTable.TabIndex = 0;
            // 
            // EntitiesFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ToolStripMenu);
            this.Name = "EntitiesFormBase";
            this.Text = "EntitiesFormBase";
            this.Load += new System.EventHandler(this.EntitiesFormBase_Load);
            this.ToolStripMenu.ResumeLayout(false);
            this.ToolStripMenu.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected ToolStrip ToolStripMenu;
        protected ToolStripButton BtnFirstRow;
        protected ToolStripButton BtnPrevious;
        protected ToolStripLabel LblCounter;
        protected ToolStripButton BtnNext;
        protected ToolStripButton BtnLastRow;
        protected ToolStripSeparator toolStripSeparator1;
        protected ToolStripButton BtnSave;
        protected ToolStripButton BtnAdd;
        protected ToolStripButton BtnDelete;
        protected ToolStripSeparator toolStripSeparator2;
        protected ToolStripButton BtnFind;
        protected SplitContainer splitContainer1;
        protected DataGridView DgvTable;
        protected ToolStripTextBox TbxId;
    }
}