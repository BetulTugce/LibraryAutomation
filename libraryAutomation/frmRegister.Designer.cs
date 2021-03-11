
namespace libraryAutomation
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.linklblLogin = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtAnswer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmboxQuestion = new System.Windows.Forms.ComboBox();
            this.txtSurname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOperation
            // 
            this.pnlOperation.BackColor = System.Drawing.Color.Black;
            this.pnlOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOperation.Controls.Add(this.linklblLogin);
            this.pnlOperation.Controls.Add(this.btnRegister);
            this.pnlOperation.Controls.Add(this.txtAnswer);
            this.pnlOperation.Controls.Add(this.cmboxQuestion);
            this.pnlOperation.Controls.Add(this.txtSurname);
            this.pnlOperation.Controls.Add(this.txtName);
            this.pnlOperation.Controls.Add(this.txtPassword);
            this.pnlOperation.Controls.Add(this.txtUsername);
            this.pnlOperation.Controls.Add(this.lblLine);
            this.pnlOperation.Controls.Add(this.lblRegister);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOperation.Location = new System.Drawing.Point(0, 0);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(445, 639);
            this.pnlOperation.TabIndex = 2;
            this.pnlOperation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlOperation_MouseDown);
            this.pnlOperation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlOperation_MouseMove);
            this.pnlOperation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlOperation_MouseUp);
            // 
            // linklblLogin
            // 
            this.linklblLogin.ActiveLinkColor = System.Drawing.Color.Black;
            this.linklblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linklblLogin.AutoSize = true;
            this.linklblLogin.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.linklblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklblLogin.LinkColor = System.Drawing.Color.Silver;
            this.linklblLogin.Location = new System.Drawing.Point(12, 614);
            this.linklblLogin.Name = "linklblLogin";
            this.linklblLogin.Size = new System.Drawing.Size(68, 16);
            this.linklblLogin.TabIndex = 92;
            this.linklblLogin.TabStop = true;
            this.linklblLogin.Text = "Oturum aç";
            this.linklblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogin_LinkClicked);
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveBorderThickness = 1;
            this.btnRegister.ActiveCornerRadius = 20;
            this.btnRegister.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnRegister.ActiveForecolor = System.Drawing.Color.Black;
            this.btnRegister.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.ButtonText = "Kayıt ol";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleCornerRadius = 20;
            this.btnRegister.IdleFillColor = System.Drawing.Color.Silver;
            this.btnRegister.IdleForecolor = System.Drawing.Color.Black;
            this.btnRegister.IdleLineColor = System.Drawing.Color.Silver;
            this.btnRegister.Location = new System.Drawing.Point(123, 477);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(181, 41);
            this.btnRegister.TabIndex = 91;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAnswer.ForeColor = System.Drawing.Color.Silver;
            this.txtAnswer.HintForeColor = System.Drawing.Color.Silver;
            this.txtAnswer.HintText = "Cevap";
            this.txtAnswer.isPassword = false;
            this.txtAnswer.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtAnswer.LineIdleColor = System.Drawing.Color.Silver;
            this.txtAnswer.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtAnswer.LineThickness = 3;
            this.txtAnswer.Location = new System.Drawing.Point(43, 403);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(350, 33);
            this.txtAnswer.TabIndex = 90;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmboxQuestion
            // 
            this.cmboxQuestion.BackColor = System.Drawing.Color.Silver;
            this.cmboxQuestion.DropDownHeight = 108;
            this.cmboxQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmboxQuestion.FormattingEnabled = true;
            this.cmboxQuestion.IntegralHeight = false;
            this.cmboxQuestion.Items.AddRange(new object[] {
            "Güvenlik sorusu seçin.",
            "Annenizin kızlık soyadı nedir?",
            "İlk evcil hayvanınızın adı nedir?",
            "İlkokul öğretmeninizin adı nedir?",
            "Hangi şehirde doğdunuz?",
            "Çocukluk lakabınız nedir?"});
            this.cmboxQuestion.Location = new System.Drawing.Point(43, 372);
            this.cmboxQuestion.Name = "cmboxQuestion";
            this.cmboxQuestion.Size = new System.Drawing.Size(350, 24);
            this.cmboxQuestion.TabIndex = 87;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSurname.ForeColor = System.Drawing.Color.Silver;
            this.txtSurname.HintForeColor = System.Drawing.Color.Silver;
            this.txtSurname.HintText = "Soysim";
            this.txtSurname.isPassword = false;
            this.txtSurname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtSurname.LineIdleColor = System.Drawing.Color.Silver;
            this.txtSurname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtSurname.LineThickness = 3;
            this.txtSurname.Location = new System.Drawing.Point(43, 326);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(350, 33);
            this.txtSurname.TabIndex = 86;
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.Silver;
            this.txtName.HintForeColor = System.Drawing.Color.Silver;
            this.txtName.HintText = "İsim";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtName.LineIdleColor = System.Drawing.Color.Silver;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(43, 285);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(350, 33);
            this.txtName.TabIndex = 85;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.HintForeColor = System.Drawing.Color.Silver;
            this.txtPassword.HintText = "Şifre";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.Silver;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(43, 244);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(350, 33);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtUsername.HintForeColor = System.Drawing.Color.Silver;
            this.txtUsername.HintText = "Kullanıcı adı";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtUsername.LineIdleColor = System.Drawing.Color.Silver;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(43, 203);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(350, 33);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblLine
            // 
            this.lblLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblLine.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblLine.Location = new System.Drawing.Point(43, 181);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(350, 1);
            this.lblLine.TabIndex = 1;
            // 
            // lblRegister
            // 
            this.lblRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblRegister.Location = new System.Drawing.Point(43, 141);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(103, 25);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "KAYIT OL";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1031, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1057, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1083, 639);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlOperation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRegister_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmRegister_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmRegister_MouseUp);
            this.pnlOperation.ResumeLayout(false);
            this.pnlOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblRegister;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        public System.Windows.Forms.ComboBox cmboxQuestion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSurname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAnswer;
        private System.Windows.Forms.LinkLabel linklblLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
    }
}