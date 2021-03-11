
namespace libraryAutomation
{
    partial class frmEscrowedBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscrowedBook));
            this.dgwBook = new System.Windows.Forms.DataGridView();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtSearchBookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.cmboxSelection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).BeginInit();
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
            this.dgwBook.Location = new System.Drawing.Point(49, 68);
            this.dgwBook.Name = "dgwBook";
            this.dgwBook.ReadOnly = true;
            this.dgwBook.Size = new System.Drawing.Size(980, 481);
            this.dgwBook.TabIndex = 27;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookTitle.Location = new System.Drawing.Point(376, 26);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(73, 17);
            this.lblBookTitle.TabIndex = 79;
            this.lblBookTitle.Text = "Kitap Ara :";
            // 
            // txtSearchBookTitle
            // 
            this.txtSearchBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBookTitle.Location = new System.Drawing.Point(453, 22);
            this.txtSearchBookTitle.Name = "txtSearchBookTitle";
            this.txtSearchBookTitle.Size = new System.Drawing.Size(243, 24);
            this.txtSearchBookTitle.TabIndex = 78;
            this.txtSearchBookTitle.TextChanged += new System.EventHandler(this.txtSearchBookTitle_TextChanged);
            this.txtSearchBookTitle.Enter += new System.EventHandler(this.txtSearchBookTitle_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 82;
            this.label1.Text = "İsim Ara :";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchName.Location = new System.Drawing.Point(119, 22);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(243, 24);
            this.txtSearchName.TabIndex = 81;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            this.txtSearchName.Enter += new System.EventHandler(this.txtSearchName_Enter);
            // 
            // cmboxSelection
            // 
            this.cmboxSelection.DropDownHeight = 108;
            this.cmboxSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmboxSelection.FormattingEnabled = true;
            this.cmboxSelection.IntegralHeight = false;
            this.cmboxSelection.Items.AddRange(new object[] {
            "Tümü",
            "Gecikenler",
            "Gecikmeyenler"});
            this.cmboxSelection.Location = new System.Drawing.Point(831, 22);
            this.cmboxSelection.Name = "cmboxSelection";
            this.cmboxSelection.Size = new System.Drawing.Size(198, 24);
            this.cmboxSelection.TabIndex = 83;
            this.cmboxSelection.SelectedIndexChanged += new System.EventHandler(this.cmboxSelection_SelectedIndexChanged);
            // 
            // frmEscrowedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 566);
            this.Controls.Add(this.cmboxSelection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.txtSearchBookTitle);
            this.Controls.Add(this.dgwBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEscrowedBook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMANET VERİLEN KİTAPLAR";
            this.Load += new System.EventHandler(this.frmEscrowedBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBook;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtSearchBookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchName;
        public System.Windows.Forms.ComboBox cmboxSelection;
    }
}