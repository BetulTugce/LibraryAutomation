using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace libraryAutomation
{
    public partial class frmEditBook : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\libraryDatabase.accdb");
        DataTable table = new DataTable();
        DataView dataView = new DataView();
        public frmEditBook()
        {
            InitializeComponent();
        }

        public string barcodeNo, bookTitle, author, pageCount, shelfNo;

        //This button updates the book's information and then refreshes the table.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBarcodeNo.Text == "" || txtBookTitle.Text == "" || txtAuthor.Text == "" || txtPageCount.Text == "" || txtShelfNo.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayın!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("update book set barcode_no=@barcode_no,book_title=@book_title,author=@author,page_count=@page_count," +
                        "shelf_no=@shelf_no where barcode_no=@barcode_no", con);
                    com.Parameters.AddWithValue("@barcode_no", txtBarcodeNo.Text);
                    com.Parameters.AddWithValue("@book_title", txtBookTitle.Text);
                    com.Parameters.AddWithValue("@author", txtAuthor.Text);
                    com.Parameters.AddWithValue("@page_count", txtPageCount.Text);
                    com.Parameters.AddWithValue("@shelf_no", txtShelfNo.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Kitap bilgileri güncellenmiştir.");
                    con.Close();
                    this.InvokeOnClick(btnClear, EventArgs.Empty);
                    table.Clear();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("select * from book order by book_title", con);
                    adapter.Fill(table);
                    dgwBook.DataSource = table;
                }
                catch (Exception)
                {
                    MessageBox.Show("Bilgileri kontrol edin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //This line of code filters the table based on entered barcode number.
        private void txtSearchBarcodeNo_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "barcode_no LIKE '%" + txtSearchBarcodeNo.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        //This line of code prints the book's information on the text when double clicked on the datagridview cell.
        private void dgwBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarcodeNo.Text = dgwBook.CurrentRow.Cells["barcode_no"].Value.ToString();
            txtBookTitle.Text = dgwBook.CurrentRow.Cells["book_title"].Value.ToString();
            txtAuthor.Text = dgwBook.CurrentRow.Cells["author"].Value.ToString();
            txtPageCount.Text = dgwBook.CurrentRow.Cells["page_count"].Value.ToString();
            txtShelfNo.Text = dgwBook.CurrentRow.Cells["shelf_no"].Value.ToString();
        }

        private void frmEditBook_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from book order by book_title", con);
            adapter.Fill(table);
            dgwBook.DataSource = table;
            dgwBook.Columns["barcode_no"].HeaderText = "Barkod No";
            dgwBook.Columns["book_title"].HeaderText = "Kitap Adı";
            dgwBook.Columns["author"].HeaderText = "Yazarı";
            dgwBook.Columns["page_count"].HeaderText = "Sayfa Sayısı";
            dgwBook.Columns["shelf_no"].HeaderText = "Raf No";
            con.Close();

            //To get the data from frmListBook.
            txtBarcodeNo.Text = barcodeNo;
            txtBookTitle.Text = bookTitle;
            txtAuthor.Text = author;
            txtPageCount.Text = pageCount;
            txtShelfNo.Text = shelfNo;
        }

        //This line of code will work if user right click on datagridview and then click this contextMenuStripItem.
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmaddBook"] == null)
            {
                frmaddBook form = new frmaddBook();
                form.Show();
            }
            else
                Application.OpenForms["frmaddBook"].Activate();
            this.Close();
        }

        //This line of code will work if user right click on datagridview and then click this contextMenuStripItem.
        //It removes the record from "book" table according to the barcode number and then refreshes the table.
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = new DialogResult();
                answer = MessageBox.Show("Kitap kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("delete from book where barcode_no=@barcode_no", con);
                    com.Parameters.AddWithValue("@barcode_no", dgwBook.CurrentRow.Cells["barcode_no"].Value.ToString());
                    com.ExecuteNonQuery();
                    table.Clear();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("select * from book order by book_title", con);
                    adapter.Fill(table);
                    dgwBook.DataSource = table;
                    MessageBox.Show("Kitap kaydı silinmiştir.");
                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hay aksi! Bir hata oluştu. Tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This line of code will work if user right click on datagridview and then click this contextMenuStripItem. 
        //It prints the book's information on the text.
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBarcodeNo.Text = dgwBook.CurrentRow.Cells[0].Value.ToString();
            txtBookTitle.Text = dgwBook.CurrentRow.Cells[1].Value.ToString();
            txtAuthor.Text = dgwBook.CurrentRow.Cells[2].Value.ToString();
            txtPageCount.Text = dgwBook.CurrentRow.Cells[3].Value.ToString();
            txtShelfNo.Text = dgwBook.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtSearchBarcodeNo_Enter(object sender, EventArgs e)
        {
            txtSearchBookTitle.Clear();
        }

        private void txtSearchBookTitle_Enter(object sender, EventArgs e)
        {
            txtSearchBarcodeNo.Clear();
        }

        //This line of code filters the table based on entered book title.
        private void txtSearchBookTitle_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "book_title LIKE '%" + txtSearchBookTitle.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        //This button removes the record from "book" table according to the barcode number and then refreshes the table.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBarcodeNo.Text == "")
            {
                MessageBox.Show("Barkod No alanı boş bırakılamaz! Lütfen silmek istediğiniz kitabı seçin.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult answer = new DialogResult();
                    answer = MessageBox.Show("Kitap kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (answer == DialogResult.Yes)
                    {
                        con.Open();
                        OleDbCommand com = new OleDbCommand("delete from book where barcode_no=@barcode_no", con);
                        com.Parameters.AddWithValue("@barcode_no", txtBarcodeNo.Text);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Kitap kaydı silinmiştir.");
                        con.Close();
                        this.InvokeOnClick(btnClear, EventArgs.Empty);
                        table.Clear();
                        OleDbDataAdapter adapter = new OleDbDataAdapter("select * from book order by book_title", con);
                        adapter.Fill(table);
                        dgwBook.DataSource = table;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hay aksi! Bir hata oluştu. Tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
