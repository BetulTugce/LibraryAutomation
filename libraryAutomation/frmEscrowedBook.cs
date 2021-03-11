using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace libraryAutomation
{
    public partial class frmEscrowedBook : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\libraryDatabase.accdb");
        DataTable table = new DataTable();
        DataView dataView = new DataView();
        public frmEscrowedBook()
        {
            InitializeComponent();
        }

        private void frmEscrowedBook_Load(object sender, EventArgs e)
        {
            cmboxSelection.SelectedIndex = 0;
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

        //This line of code filters the table based on entered book title.
        private void txtSearchBookTitle_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "book_title LIKE '%" + txtSearchBookTitle.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        //This line of code filters the table based on entered name.
        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "name LIKE '%" + txtSearchName.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        private void txtSearchName_Enter(object sender, EventArgs e)
        {
            txtSearchBookTitle.Text = "";
        }

        private void txtSearchBookTitle_Enter(object sender, EventArgs e)
        {
            txtSearchName.Text = "";
        }

        //This line of code filters the table based on user selection.
        //index 0 = all books ---- index 1 = delayed ---- index 2 = not delayed
        private void cmboxSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            table.Clear();
            if (cmboxSelection.SelectedIndex == 0)
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from give_book order by name", con);
                adapter.Fill(table);
                dgwBook.DataSource = table;
            }
            else if (cmboxSelection.SelectedIndex == 1)
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from delayed order by name", con);
                adapter.Fill(table);
                dgwBook.DataSource = table;
            }
            else if (cmboxSelection.SelectedIndex == 2)
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from undelayed order by name", con);
                adapter.Fill(table);
                dgwBook.DataSource = table;
            }
        }
    }
}
