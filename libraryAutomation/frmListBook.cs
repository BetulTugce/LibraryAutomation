using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace libraryAutomation
{
    public partial class frmListBook : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\libraryDatabase.accdb");
        DataTable table = new DataTable();
        DataView dataView = new DataView();
        public frmListBook()
        {
            InitializeComponent();
        }

        private void frmListBook_Load(object sender, EventArgs e)
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
        }

        //This line of code filters the table based on entered barcode number.
        private void txtSearchBarcodeNo_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "barcode_no LIKE '%" + txtSearchBarcodeNo.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        //This line of code filters the table based on entered book title.
        private void txtSearchBookTitle_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "book_title LIKE '%" + txtSearchBookTitle.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        private void txtSearchBarcodeNo_Enter(object sender, EventArgs e)
        {
            txtSearchBookTitle.Clear();
        }

        private void txtSearchBookTitle_Enter(object sender, EventArgs e)
        {
            txtSearchBarcodeNo.Clear();
        }

        private void dgwBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        //It sends the book's information to frmEditBook.
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditBook form = new frmEditBook();
            form.barcodeNo = dgwBook.CurrentRow.Cells[0].Value.ToString();
            form.bookTitle = dgwBook.CurrentRow.Cells[1].Value.ToString();
            form.author = dgwBook.CurrentRow.Cells[2].Value.ToString();
            form.pageCount = dgwBook.CurrentRow.Cells[3].Value.ToString();
            form.shelfNo = dgwBook.CurrentRow.Cells[4].Value.ToString();
            form.Show();
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
    }
}
