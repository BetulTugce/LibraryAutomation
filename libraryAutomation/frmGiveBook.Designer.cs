
namespace libraryAutomation
{
    partial class frmGiveBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiveBook));
            this.labelBarcodeNo = new System.Windows.Forms.Label();
            this.txtSearchBarcodeNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchIdNo = new System.Windows.Forms.TextBox();
            this.dgwMember = new System.Windows.Forms.DataGridView();
            this.dgwBook = new System.Windows.Forms.DataGridView();
            this.lblSubmissionDate = new System.Windows.Forms.Label();
            this.dtpSubmissionDate = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBarcodeNo
            // 
            this.labelBarcodeNo.AutoSize = true;
            this.labelBarcodeNo.BackColor = System.Drawing.Color.Transparent;
            this.labelBarcodeNo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBarcodeNo.ForeColor = System.Drawing.Color.White;
            this.labelBarcodeNo.Location = new System.Drawing.Point(19, 283);
            this.labelBarcodeNo.Name = "labelBarcodeNo";
            this.labelBarcodeNo.Size = new System.Drawing.Size(107, 17);
            this.labelBarcodeNo.TabIndex = 98;
            this.labelBarcodeNo.Text = "Barkod No Ara :";
            // 
            // txtSearchBarcodeNo
            // 
            this.txtSearchBarcodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBarcodeNo.Location = new System.Drawing.Point(145, 279);
            this.txtSearchBarcodeNo.Name = "txtSearchBarcodeNo";
            this.txtSearchBarcodeNo.Size = new System.Drawing.Size(243, 24);
            this.txtSearchBarcodeNo.TabIndex = 97;
            this.txtSearchBarcodeNo.TextChanged += new System.EventHandler(this.txtSearchBarcodeNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 96;
            this.label2.Text = "Tc Kimlik No Ara :";
            // 
            // txtSearchIdNo
            // 
            this.txtSearchIdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchIdNo.Location = new System.Drawing.Point(145, 12);
            this.txtSearchIdNo.Name = "txtSearchIdNo";
            this.txtSearchIdNo.Size = new System.Drawing.Size(243, 24);
            this.txtSearchIdNo.TabIndex = 95;
            this.txtSearchIdNo.TextChanged += new System.EventHandler(this.txtSearchIdNo_TextChanged);
            // 
            // dgwMember
            // 
            this.dgwMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMember.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMember.Location = new System.Drawing.Point(22, 54);
            this.dgwMember.Name = "dgwMember";
            this.dgwMember.ReadOnly = true;
            this.dgwMember.Size = new System.Drawing.Size(1058, 203);
            this.dgwMember.TabIndex = 99;
            // 
            // dgwBook
            // 
            this.dgwBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBook.Location = new System.Drawing.Point(22, 318);
            this.dgwBook.Name = "dgwBook";
            this.dgwBook.ReadOnly = true;
            this.dgwBook.Size = new System.Drawing.Size(1058, 203);
            this.dgwBook.TabIndex = 100;
            // 
            // lblSubmissionDate
            // 
            this.lblSubmissionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubmissionDate.AutoSize = true;
            this.lblSubmissionDate.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmissionDate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubmissionDate.Location = new System.Drawing.Point(19, 580);
            this.lblSubmissionDate.Name = "lblSubmissionDate";
            this.lblSubmissionDate.Size = new System.Drawing.Size(89, 17);
            this.lblSubmissionDate.TabIndex = 104;
            this.lblSubmissionDate.Text = "Teslim Tarihi";
            // 
            // dtpSubmissionDate
            // 
            this.dtpSubmissionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpSubmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSubmissionDate.Location = new System.Drawing.Point(123, 577);
            this.dtpSubmissionDate.Name = "dtpSubmissionDate";
            this.dtpSubmissionDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSubmissionDate.TabIndex = 103;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.BackColor = System.Drawing.Color.Transparent;
            this.lblIssueDate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIssueDate.Location = new System.Drawing.Point(19, 541);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(96, 17);
            this.lblIssueDate.TabIndex = 102;
            this.lblIssueDate.Text = "Verilme Tarihi";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpIssueDate.Enabled = false;
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(123, 538);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpIssueDate.TabIndex = 101;
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Emanet Ver";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = null;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(939, 555);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(141, 42);
            this.btnSave.TabIndex = 105;
            this.btnSave.Text = "Emanet Ver";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmGiveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1113, 635);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSubmissionDate);
            this.Controls.Add(this.dtpSubmissionDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.dgwBook);
            this.Controls.Add(this.dgwMember);
            this.Controls.Add(this.labelBarcodeNo);
            this.Controls.Add(this.txtSearchBarcodeNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchIdNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1129, 674);
            this.MinimumSize = new System.Drawing.Size(900, 674);
            this.Name = "frmGiveBook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMANET VER";
            this.Load += new System.EventHandler(this.frmGiveBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBarcodeNo;
        private System.Windows.Forms.TextBox txtSearchBarcodeNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchIdNo;
        private System.Windows.Forms.DataGridView dgwMember;
        private System.Windows.Forms.DataGridView dgwBook;
        private System.Windows.Forms.Label lblSubmissionDate;
        private System.Windows.Forms.DateTimePicker dtpSubmissionDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
    }
}