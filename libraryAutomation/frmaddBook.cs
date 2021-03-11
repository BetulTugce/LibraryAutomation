using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace libraryAutomation
{
    public partial class frmaddBook : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\libraryDatabase.accdb");

        public frmaddBook()
        {
            InitializeComponent();
        }

        //This button gets information from TextBoxes and loads data into "book" table
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBarcodeNo.Text == "")
            {
                MessageBox.Show("Barkod No alanı boş bırakılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("insert into book (barcode_no,book_title,author,page_count,shelf_no) values (@barcode_no,@book_title,@author,@page_count,@shelf_no)", con);
                    com.Parameters.AddWithValue("@barcode_no", txtBarcodeNo.Text);
                    com.Parameters.AddWithValue("@book_title", txtBookTitle.Text);
                    com.Parameters.AddWithValue("@author", txtAuthor.Text);
                    com.Parameters.AddWithValue("@page_count", txtPageCount.Text);
                    com.Parameters.AddWithValue("@shelf_no", txtShelfNo.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Kitap kaydı gerçekleştirildi.");
                    con.Close();
                    this.InvokeOnClick(btnClear, EventArgs.Empty);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hay aksi! Kitap kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBarcodeNo.Clear();
            txtBookTitle.Clear();
            txtAuthor.Clear();
            txtPageCount.Clear();
            txtShelfNo.Clear();
        }
    }
}
