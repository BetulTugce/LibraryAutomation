
namespace libraryAutomation
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListMember = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEditMember = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAddMember = new Bunifu.Framework.UI.BunifuTileButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListBook = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEditBook = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAddBook = new Bunifu.Framework.UI.BunifuTileButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEscrowedBooks = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTakeBack = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnGive = new Bunifu.Framework.UI.BunifuTileButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnListMember);
            this.groupBox1.Controls.Add(this.btnEditMember);
            this.groupBox1.Controls.Add(this.btnAddMember);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.groupBox1.Location = new System.Drawing.Point(171, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // btnListMember
            // 
            this.btnListMember.BackColor = System.Drawing.Color.LightGray;
            this.btnListMember.color = System.Drawing.Color.LightGray;
            this.btnListMember.colorActive = System.Drawing.Color.Silver;
            this.btnListMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListMember.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListMember.ForeColor = System.Drawing.Color.Black;
            this.btnListMember.Image = ((System.Drawing.Image)(resources.GetObject("btnListMember.Image")));
            this.btnListMember.ImagePosition = 10;
            this.btnListMember.ImageZoom = 65;
            this.btnListMember.LabelPosition = 35;
            this.btnListMember.LabelText = "Listele";
            this.btnListMember.Location = new System.Drawing.Point(243, 28);
            this.btnListMember.Margin = new System.Windows.Forms.Padding(6);
            this.btnListMember.Name = "btnListMember";
            this.btnListMember.Size = new System.Drawing.Size(92, 114);
            this.btnListMember.TabIndex = 2;
            this.btnListMember.Click += new System.EventHandler(this.btnListMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.BackColor = System.Drawing.Color.LightGray;
            this.btnEditMember.color = System.Drawing.Color.LightGray;
            this.btnEditMember.colorActive = System.Drawing.Color.Silver;
            this.btnEditMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMember.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditMember.ForeColor = System.Drawing.Color.Black;
            this.btnEditMember.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMember.Image")));
            this.btnEditMember.ImagePosition = 10;
            this.btnEditMember.ImageZoom = 65;
            this.btnEditMember.LabelPosition = 35;
            this.btnEditMember.LabelText = "Düzenle";
            this.btnEditMember.Location = new System.Drawing.Point(129, 28);
            this.btnEditMember.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(92, 114);
            this.btnEditMember.TabIndex = 1;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.LightGray;
            this.btnAddMember.color = System.Drawing.Color.LightGray;
            this.btnAddMember.colorActive = System.Drawing.Color.Silver;
            this.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMember.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMember.ForeColor = System.Drawing.Color.Black;
            this.btnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMember.Image")));
            this.btnAddMember.ImagePosition = 10;
            this.btnAddMember.ImageZoom = 65;
            this.btnAddMember.LabelPosition = 35;
            this.btnAddMember.LabelText = "Ekle";
            this.btnAddMember.Location = new System.Drawing.Point(14, 28);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(92, 114);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.btnListBook);
            this.groupBox2.Controls.Add(this.btnEditBook);
            this.groupBox2.Controls.Add(this.btnAddBook);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.groupBox2.Location = new System.Drawing.Point(555, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 157);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnListBook
            // 
            this.btnListBook.BackColor = System.Drawing.Color.LightGray;
            this.btnListBook.color = System.Drawing.Color.LightGray;
            this.btnListBook.colorActive = System.Drawing.Color.Silver;
            this.btnListBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListBook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListBook.ForeColor = System.Drawing.Color.Black;
            this.btnListBook.Image = ((System.Drawing.Image)(resources.GetObject("btnListBook.Image")));
            this.btnListBook.ImagePosition = 10;
            this.btnListBook.ImageZoom = 65;
            this.btnListBook.LabelPosition = 35;
            this.btnListBook.LabelText = "Listele";
            this.btnListBook.Location = new System.Drawing.Point(243, 28);
            this.btnListBook.Margin = new System.Windows.Forms.Padding(6);
            this.btnListBook.Name = "btnListBook";
            this.btnListBook.Size = new System.Drawing.Size(92, 114);
            this.btnListBook.TabIndex = 2;
            this.btnListBook.Click += new System.EventHandler(this.btnListBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.LightGray;
            this.btnEditBook.color = System.Drawing.Color.LightGray;
            this.btnEditBook.colorActive = System.Drawing.Color.Silver;
            this.btnEditBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditBook.ForeColor = System.Drawing.Color.Black;
            this.btnEditBook.Image = ((System.Drawing.Image)(resources.GetObject("btnEditBook.Image")));
            this.btnEditBook.ImagePosition = 10;
            this.btnEditBook.ImageZoom = 65;
            this.btnEditBook.LabelPosition = 35;
            this.btnEditBook.LabelText = "Düzenle";
            this.btnEditBook.Location = new System.Drawing.Point(129, 28);
            this.btnEditBook.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(92, 114);
            this.btnEditBook.TabIndex = 1;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.LightGray;
            this.btnAddBook.color = System.Drawing.Color.LightGray;
            this.btnAddBook.colorActive = System.Drawing.Color.Silver;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBook.ForeColor = System.Drawing.Color.Black;
            this.btnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBook.Image")));
            this.btnAddBook.ImagePosition = 10;
            this.btnAddBook.ImageZoom = 65;
            this.btnAddBook.LabelPosition = 35;
            this.btnAddBook.LabelText = "Ekle";
            this.btnAddBook.Location = new System.Drawing.Point(14, 28);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(92, 114);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.btnEscrowedBooks);
            this.groupBox3.Controls.Add(this.btnTakeBack);
            this.groupBox3.Controls.Add(this.btnGive);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.groupBox3.Location = new System.Drawing.Point(171, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 157);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet İşlemleri";
            // 
            // btnEscrowedBooks
            // 
            this.btnEscrowedBooks.BackColor = System.Drawing.Color.LightGray;
            this.btnEscrowedBooks.color = System.Drawing.Color.LightGray;
            this.btnEscrowedBooks.colorActive = System.Drawing.Color.Silver;
            this.btnEscrowedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscrowedBooks.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEscrowedBooks.ForeColor = System.Drawing.Color.Black;
            this.btnEscrowedBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnEscrowedBooks.Image")));
            this.btnEscrowedBooks.ImagePosition = 10;
            this.btnEscrowedBooks.ImageZoom = 65;
            this.btnEscrowedBooks.LabelPosition = 35;
            this.btnEscrowedBooks.LabelText = "Listele";
            this.btnEscrowedBooks.Location = new System.Drawing.Point(243, 28);
            this.btnEscrowedBooks.Margin = new System.Windows.Forms.Padding(6);
            this.btnEscrowedBooks.Name = "btnEscrowedBooks";
            this.btnEscrowedBooks.Size = new System.Drawing.Size(92, 114);
            this.btnEscrowedBooks.TabIndex = 2;
            this.btnEscrowedBooks.Click += new System.EventHandler(this.btnEscrowedBooks_Click);
            // 
            // btnTakeBack
            // 
            this.btnTakeBack.BackColor = System.Drawing.Color.LightGray;
            this.btnTakeBack.color = System.Drawing.Color.LightGray;
            this.btnTakeBack.colorActive = System.Drawing.Color.Silver;
            this.btnTakeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakeBack.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTakeBack.ForeColor = System.Drawing.Color.Black;
            this.btnTakeBack.Image = ((System.Drawing.Image)(resources.GetObject("btnTakeBack.Image")));
            this.btnTakeBack.ImagePosition = 10;
            this.btnTakeBack.ImageZoom = 65;
            this.btnTakeBack.LabelPosition = 35;
            this.btnTakeBack.LabelText = "Al";
            this.btnTakeBack.Location = new System.Drawing.Point(129, 28);
            this.btnTakeBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnTakeBack.Name = "btnTakeBack";
            this.btnTakeBack.Size = new System.Drawing.Size(92, 114);
            this.btnTakeBack.TabIndex = 1;
            this.btnTakeBack.Click += new System.EventHandler(this.btnTakeBack_Click);
            // 
            // btnGive
            // 
            this.btnGive.BackColor = System.Drawing.Color.LightGray;
            this.btnGive.color = System.Drawing.Color.LightGray;
            this.btnGive.colorActive = System.Drawing.Color.Silver;
            this.btnGive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGive.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGive.ForeColor = System.Drawing.Color.Black;
            this.btnGive.Image = ((System.Drawing.Image)(resources.GetObject("btnGive.Image")));
            this.btnGive.ImagePosition = 10;
            this.btnGive.ImageZoom = 65;
            this.btnGive.LabelPosition = 35;
            this.btnGive.LabelText = "Ver";
            this.btnGive.Location = new System.Drawing.Point(14, 28);
            this.btnGive.Margin = new System.Windows.Forms.Padding(6);
            this.btnGive.Name = "btnGive";
            this.btnGive.Size = new System.Drawing.Size(92, 114);
            this.btnGive.TabIndex = 0;
            this.btnGive.Click += new System.EventHandler(this.btnGive_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.aboutToolStripMenuItem.Text = "Hakkında";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(89, 21);
            this.userToolStripMenuItem.Text = "Kullanıcı";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Hesap ayarları";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Oturumu Kapat";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Çıkış Yap";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 606);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuTileButton btnListMember;
        private Bunifu.Framework.UI.BunifuTileButton btnEditMember;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuTileButton btnListBook;
        private Bunifu.Framework.UI.BunifuTileButton btnEditBook;
        private Bunifu.Framework.UI.BunifuTileButton btnAddBook;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuTileButton btnEscrowedBooks;
        private Bunifu.Framework.UI.BunifuTileButton btnTakeBack;
        private Bunifu.Framework.UI.BunifuTileButton btnGive;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuTileButton btnAddMember;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}