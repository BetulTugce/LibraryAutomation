using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace libraryAutomation
{
    public partial class frmTakeBackBook : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\libraryDatabase.accdb");
        DataTable table = new DataTable();
        DataView dataView = new DataView();
        public frmTakeBackBook()
        {
            InitializeComponent();
        }

        //This button removes the record from "give_book" table according to the id number and the barcode number.
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand com = new OleDbCommand("delete from give_book where id_no=@id_no and barcode_no=@barcode_no", con);
                com.Parameters.AddWithValue("@id_no", dgwBook.CurrentRow.Cells["id_no"].Value.ToString());
                com.Parameters.AddWithValue("@barcode_no", dgwBook.CurrentRow.Cells["barcode_no"].Value.ToString());
                com.ExecuteNonQuery();
                table.Clear();
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from give_book order by name", con);
                adapter.Fill(table);
                dgwBook.DataSource = table;
                MessageBox.Show("Kitap iadesi başarılı bir şekilde gerçekleşti.");
                con.Close();
                table.Clear();
                adapter.Fill(table);
                dgwBook.DataSource = table;
            }
            catch (Exception)
            {
                MessageBox.Show("Bilgileri kontrol edin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTakeBackBook_Load(object sender, EventArgs e)
        {
            con.Open();
            table.Clear();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from give_book order by name", con);
            adapter.Fill(table);
            dgwBook.DataSource = table;
            dgwBook.Columns["id_no"].HeaderText = "TC Kimlik No";
            dgwBook.Columns["name"].HeaderText = "İsim";
            dgwBook.Columns["surname"].HeaderText = "Soyisim";
            dgwBook.Columns["tel"].HeaderText = "Telefon";
            dgwBook.Columns["address"].HeaderText = "Adres";
            dgwBook.Columns["barcode_no"].HeaderText = "Barkod No";
            dgwBook.Columns["book_title"].HeaderText = "Kitap Adı";
            dgwBook.Columns["author"].HeaderText = "Yazarı";
            dgwBook.Columns["page_count"].HeaderText = "Sayfa Sayısı";
            dgwBook.Columns["shelf_no"].HeaderText = "Raf No";
            dgwBook.Columns["issue_date"].HeaderText = "Verilme Tarihi";
            dgwBook.Columns["submission_date"].HeaderText = "Teslim Tarihi";
            con.Close();
        }

        //This line of code filters the table based on entered barcode number.
        private void txtSearchBarcodeNo_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "barcode_no LIKE '%" + txtSearchBarcodeNo.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        //This line of code filters the table based on entered id number.
        private void txtSearchIdNo_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "id_no LIKE '%" + txtSearchIdNo.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        private void txtSearchIdNo_Enter(object sender, EventArgs e)
        {
            txtSearchBarcodeNo.Clear();
        }

        private void txtSearchBarcodeNo_Enter(object sender, EventArgs e)
        {
            txtSearchIdNo.Clear();
        }
    }
}
