using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace libraryAutomation
{
    public partial class frmAddMember : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\libraryDatabase.accdb");

        public frmAddMember()
        {
            InitializeComponent();
        }

        public int checkId(string text)
        {
            int result;
            con.Open();
            OleDbCommand com = new OleDbCommand("Select Count(id_no) from member where id_no='" + text + "'", con);
            result = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            return result;
        }

        //This button gets information from TextBoxes and loads data into "member" table.
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtIdNo.Text == "")
            {
                MessageBox.Show("TC Kimlik No alanı boş bırakılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (checkId(txtIdNo.Text) != 0)
                    {
                        MessageBox.Show("Bu TC Kimlik Numarası zaten kayıtlı!");
                    }
                    else
                    {
                        con.Open();
                        OleDbCommand com = new OleDbCommand("insert into member (id_no,name,surname,tel,address) values (@id_no,@name,@surname,@tel,@address)", con);
                        com.Parameters.AddWithValue("@id_no", txtIdNo.Text);
                        com.Parameters.AddWithValue("@name", txtName.Text);
                        com.Parameters.AddWithValue("@surname", txtSurname.Text);
                        com.Parameters.AddWithValue("@tel", txtTel.Text);
                        com.Parameters.AddWithValue("@address", txtAddress.Text);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Üye başarıyla kaydedilmiştir.");
                        con.Close();
                        this.InvokeOnClick(btnClear, EventArgs.Empty);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hay aksi! Kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdNo.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtTel.Clear();
            txtAddress.Clear();
        }
    }
}
