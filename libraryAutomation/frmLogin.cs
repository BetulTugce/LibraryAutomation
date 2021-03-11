using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace libraryAutomation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pnlOperation_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pnlOperation_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void pnlOperation_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Kullanıcı adı")
            {
                txtUserName.Text = "";
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Kullanıcı adı";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Şifre")
            {
                txtPassword.Text = "";
                txtPassword.isPassword = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Şifre";
                txtPassword.isPassword = false;
            }
        }

        //Hashing guards against the possibility that someone who gains unauthorized access to the database can retrieve the passwords of every user 
        //in the system. This line of code turns the password into another String, called the hashed password.
        static string ComputeSHA256Hash(string text)
        {
            SHA256 sha256Encrypting = new SHA256CryptoServiceProvider();
            byte[] bytes = sha256Encrypting.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder builder = new StringBuilder();
            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }
            return builder.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUserName.Text == "" && txtPassword.Text == "") || (txtUserName.Text == "Kullanıcı adı" && txtPassword.Text == "Şifre") ||
                (txtUserName.Text == "" && txtPassword.Text == "Şifre") || (txtPassword.Text == "" && txtUserName.Text == "Kullanıcı adı"))
            {
                MessageBox.Show("Bilgilerinizi boş bırakmayınız!");
            }
            else if (txtUserName.Text == "" || txtUserName.Text == "Kullanıcı adı")
            {
                MessageBox.Show("Kullanıcı adınızı girin!");
            }
            else if (txtPassword.Text == "" || txtPassword.Text == "Şifre")
            {
                MessageBox.Show("Şifrenizi girin!");
            }
            else
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\libraryDatabase.accdb");
                con.Open();
                OleDbCommand com = new OleDbCommand("Select * from user_information where Username=@username AND Password=@password", con);
                com.Parameters.AddWithValue("@username", txtUserName.Text);
                com.Parameters.AddWithValue("@password", ComputeSHA256Hash(txtPassword.Text));
                com.ExecuteNonQuery();               
                OleDbDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    frmMain form = new frmMain();
                    form.username = txtUserName.Text; //Sends the username to frmMain.
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen bilgilerinizi kontrol edin.");
                }
                con.Close();
                con.Dispose();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms["frmRegister"] == null)
            {
                frmRegister form = new frmRegister();
                form.Show();
            }
            else
                Application.OpenForms["frmRegister"].Activate();
        } 
    }
}
