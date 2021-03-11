using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace libraryAutomation
{
    public partial class frmGiveBook : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\libraryDatabase.accdb");
        DataTable tableMember = new DataTable();
        DataTable tableBook = new DataTable();
        DataView dataView = new DataView();

        public frmGiveBook()
        {
            InitializeComponent();
        }

        private void frmGiveBook_Load(object sender, EventArgs e)
        {
            con.Open();
            tableMember.Clear();
            OleDbDataAdapter adrMember = new OleDbDataAdapter("select * from member order by name", con);
            adrMember.Fill(tableMember);
            dgwMember.DataSource = tableMember;
            dgwMember.Columns["id_no"].HeaderText = "TC Kimlik No";
            dgwMember.Columns["name"].HeaderText = "İsim";
            dgwMember.Columns["surname"].HeaderText = "Soyisim";
            dgwMember.Columns["tel"].HeaderText = "Telefon";
            dgwMember.Columns["address"].HeaderText = "Adres";
            tableBook.Clear();
            OleDbDataAdapter adrBook = new OleDbDataAdapter("select * from book order by book_title", con);
            adrBook.Fill(tableBook);
            dgwBook.DataSource = tableBook;
            dgwBook.Columns["barcode_no"].HeaderText = "Barkod No";
            dgwBook.Columns["book_title"].HeaderText = "Kitap Adı";
            dgwBook.Columns["author"].HeaderText = "Yazarı";
            dgwBook.Columns["page_count"].HeaderText = "Sayfa Sayısı";
            dgwBook.Columns["shelf_no"].HeaderText = "Raf No";
            con.Close();

        }

        //This button gets information from the datagridviews and loads data into "give_book" table.
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand com = new OleDbCommand("insert into give_book (id_no,name,surname,tel,address,barcode_no,book_title,author,page_count,shelf_no,issue_date,submission_date)" +
                " values (@id_no,@name,@surname,@tel,@address,@barcode_no,@book_title,@author,@page_count,@shelf_no,@issue_date,@submission_date)", con);
                com.Parameters.AddWithValue("@id_no", dgwMember.CurrentRow.Cells["id_no"].Value.ToString());
                com.Parameters.AddWithValue("@name", dgwMember.CurrentRow.Cells["name"].Value.ToString());
                com.Parameters.AddWithValue("@surname", dgwMember.CurrentRow.Cells["surname"].Value.ToString());
                com.Parameters.AddWithValue("@tel", dgwMember.CurrentRow.Cells["tel"].Value.ToString());
                com.Parameters.AddWithValue("@address", dgwMember.CurrentRow.Cells["address"].Value.ToString());
                com.Parameters.AddWithValue("@barcode_no", dgwBook.CurrentRow.Cells["barcode_no"].Value.ToString());
                com.Parameters.AddWithValue("@book_title", dgwBook.CurrentRow.Cells["book_title"].Value.ToString());
                com.Parameters.AddWithValue("@author", dgwBook.CurrentRow.Cells["author"].Value.ToString());
                com.Parameters.AddWithValue("@page_count", dgwBook.CurrentRow.Cells["page_count"].Value.ToString());
                com.Parameters.AddWithValue("@shelf_no", dgwBook.CurrentRow.Cells["shelf_no"].Value.ToString());
                com.Parameters.AddWithValue("@issue_date", dtpIssueDate.Value.ToString());
                com.Parameters.AddWithValue("@submission_date", dtpSubmissionDate.Value.ToString());
                com.ExecuteNonQuery();
                MessageBox.Show("Kitap emanet işlemi başarılı bir şekilde gerçekleşti.");
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bilgileri kontrol edin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //This line of code filters the table based on entered id number.
        private void txtSearchIdNo_TextChanged(object sender, EventArgs e)
        {
            dataView = tableMember.DefaultView;
            dataView.RowFilter = "id_no LIKE '%" + txtSearchIdNo.Text + "%'";
            dgwMember.DataSource = dataView;

        }

        //This line of code filters the table based on entered barcode number.
        private void txtSearchBarcodeNo_TextChanged(object sender, EventArgs e)
        {
            dataView = tableBook.DefaultView;
            dataView.RowFilter = "barcode_no LIKE '%" + txtSearchBarcodeNo.Text + "%'";
            dgwBook.DataSource = dataView;

        }
    }
}
