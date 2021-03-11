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
    public partial class frmRegister : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\libraryDatabase.accdb");
        public frmRegister()
        {
            InitializeComponent();
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

        bool move;
        int mouse_x;
        int mouse_y;

        private void frmRegister_Load(object sender, EventArgs e)
        {
            cmboxQuestion.SelectedIndex = 0;
        }

        //This line of code checks if username already taken during registration.
        public int checkUsername(string username)
        {
            int result;
            con.Open();
            OleDbCommand com = new OleDbCommand("Select Count(Username) from user_information where Username='" + username + "'", con);
            result = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            return result;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //This line of code checks if the fields are empty.
            if (txtUsername.Text == "" || txtUsername.Text == "Kullanıcı adı" || txtPassword.Text == "" || txtPassword.Text == "Şifre" || txtName.Text == "" ||
                txtName.Text == "İsim" || txtSurname.Text == "" || txtSurname.Text == "Soyisim" || txtAnswer.Text == "" || txtAnswer.Text == "Cevap" ||
                cmboxQuestion.SelectedIndex==0)
            {
                MessageBox.Show("Lütfen boş alan bırakmadığınızdan ve güvenlik sorusu seçtiğinizden emin olun!");
            }
            else
            {
                //If username already exists in the database, a message will be displayed on the form telling the user that the submitted username has already been taken.
                if (checkUsername(txtUsername.Text) != 0)
                {
                    MessageBox.Show("Bu kullanıcı adı başkası tarafından kullanılıyor!");
                }
                else
                {
                    try
                    {
                        //This line of code gets information from TextBoxes and loads data into "user_information" table
                        con.Open();
                        OleDbCommand com = new OleDbCommand();
                        com.Connection = con;
                        com.CommandText = "insert into user_information values ('" + txtUsername.Text + "','" + ComputeSHA256Hash(txtPassword.Text) + "','" + txtName.Text + "','" + txtSurname.Text + "','" + cmboxQuestion.SelectedItem.ToString() + "','" + ComputeSHA256Hash(txtAnswer.Text) + "')";
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Kullanıcı oluşturuldu.");

                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtName.Text = "";
                        txtSurname.Text = "";
                        txtAnswer.Text = "";
                        cmboxQuestion.SelectedIndex = 0;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hay aksi! Kayıt sırasında bir problem oluştu. Lütfen tekrar deneyin.");
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms["frmLogin"] == null)
            {
                frmLogin form = new frmLogin();
                form.Show();
                this.Close();
            }
            else
                Application.OpenForms["frmLogin"].Activate();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.isPassword = true;
        }

        private void frmRegister_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmRegister_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void frmRegister_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pnlOperation_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void pnlOperation_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void pnlOperation_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
