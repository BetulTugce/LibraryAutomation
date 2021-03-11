
namespace libraryAutomation
{
    partial class frmListBook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListBook));
            this.dgwBook = new System.Windows.Forms.DataGridView();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtSearchBookTitle = new System.Windows.Forms.TextBox();
            this.lblBarcodeNo = new System.Windows.Forms.Label();
            this.txtSearchBarcodeNo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBook
            // 
            this.dgwBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBook.ContextMenuStrip = this.contextMenuStrip1;
            this.dgwBook.Location = new System.Drawing.Point(49, 68);
            this.dgwBook.Name = "dgwBook";
            this.dgwBook.ReadOnly = true;
            this.dgwBook.Size = new System.Drawing.Size(980, 582);
            this.dgwBook.TabIndex = 26;
            this.dgwBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBook_CellContentClick);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookTitle.Location = new System.Drawing.Point(456, 28);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(73, 17);
            this.lblBookTitle.TabIndex = 77;
            this.lblBookTitle.Text = "Kitap Ara :";
            // 
            // txtSearchBookTitle
            // 
            this.txtSearchBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBookTitle.Location = new System.Drawing.Point(533, 24);
            this.txtSearchBookTitle.Name = "txtSearchBookTitle";
            this.txtSearchBookTitle.Size = new System.Drawing.Size(243, 24);
            this.txtSearchBookTitle.TabIndex = 76;
            this.txtSearchBookTitle.TextChanged += new System.EventHandler(this.txtSearchBookTitle_TextChanged);
            this.txtSearchBookTitle.Enter += new System.EventHandler(this.txtSearchBookTitle_Enter);
            // 
            // lblBarcodeNo
            // 
            this.lblBarcodeNo.AutoSize = true;
            this.lblBarcodeNo.BackColor = System.Drawing.Color.Transparent;
            this.lblBarcodeNo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarcodeNo.Location = new System.Drawing.Point(46, 28);
            this.lblBarcodeNo.Name = "lblBarcodeNo";
            this.lblBarcodeNo.Size = new System.Drawing.Size(107, 17);
            this.lblBarcodeNo.TabIndex = 75;
            this.lblBarcodeNo.Text = "Barkod No Ara :";
            // 
            // txtSearchBarcodeNo
            // 
            this.txtSearchBarcodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBarcodeNo.Location = new System.Drawing.Point(172, 24);
            this.txtSearchBarcodeNo.Name = "txtSearchBarcodeNo";
            this.txtSearchBarcodeNo.Size = new System.Drawing.Size(243, 24);
            this.txtSearchBarcodeNo.TabIndex = 74;
            this.txtSearchBarcodeNo.TextChanged += new System.EventHandler(this.txtSearchBarcodeNo_TextChanged);
            this.txtSearchBarcodeNo.Enter += new System.EventHandler(this.txtSearchBarcodeNo_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Ekle";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Sil";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Düzenle";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // frmListBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 667);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.txtSearchBookTitle);
            this.Controls.Add(this.lblBarcodeNo);
            this.Controls.Add(this.txtSearchBarcodeNo);
            this.Controls.Add(this.dgwBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListBook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAPLARI LİSTELE";
            this.Load += new System.EventHandler(this.frmListBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBook;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtSearchBookTitle;
        private System.Windows.Forms.Label lblBarcodeNo;
        private System.Windows.Forms.TextBox txtSearchBarcodeNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}