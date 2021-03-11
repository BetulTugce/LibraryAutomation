using System;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace libraryAutomation
{
    public partial class frmAccount : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\libraryDatabase.accdb");

        public frmAccount()
        {
            InitializeComponent();
        }

        public string username;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "" || txtOldPassword.Text == "")
            {
                MessageBox.Show("Lütfen bütün alanları doldurun!");
            }
            else
            {
                try
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("SELECT * FROM user_information WHERE Username = @username AND Password = @password", con);
                    com.Parameters.AddWithValue("@username", username);
                    com.Parameters.AddWithValue("@password", ComputeSHA256Hash(txtOldPassword.Text));
                    OleDbDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        OleDbCommand com2 = new OleDbCommand("UPDATE user_information SET Password = @password WHERE Username = @username", con);
                        com2.Parameters.AddWithValue("@password", ComputeSHA256Hash(txtNewPassword.Text));
                        com2.Parameters.AddWithValue("@username", username);
                        com2.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Şifreniz başarıyla değiştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Eski şifrenizi yanlış girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hay aksi! Beklenmeyen bir sorun oluştu. Lütfen tekrar deneyin.");
                    con.Close();
                }
            }
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            lblUsername.Text = username;

        }

        private void btnDelAccount_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = new DialogResult();
                answer = MessageBox.Show("Hesabınızı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("delete from user_information where Username=@Username", con);
                    com.Parameters.AddWithValue("@Username", lblUsername.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Hesabınız silinmiştir.");
                    con.Close();
                    Application.Restart();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hay aksi! Beklenmeyen bir sorun oluştu. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
