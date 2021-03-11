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

namespace libraryAutomation
{
    public partial class frmListMember : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\libraryDatabase.accdb");
        DataTable table = new DataTable();
        DataView dataView = new DataView();

        public frmListMember()
        {
            InitializeComponent();
        }

        private void frmListMember_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from member order by name", con);
            adapter.Fill(table);
            dgwMember.DataSource = table;
            dgwMember.Columns["id_no"].HeaderText = "TC Kimlik No";
            dgwMember.Columns["name"].HeaderText = "İsim";
            dgwMember.Columns["surname"].HeaderText = "Soyisim";
            dgwMember.Columns["tel"].HeaderText = "Telefon";
            dgwMember.Columns["address"].HeaderText = "Adres";
            con.Close();
        }

        //This line of code filters the table based on entered id number.
        private void txtSearchIdNo_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "id_no LIKE '%" + txtSearchIdNo.Text + "%'";
            dgwMember.DataSource = dataView;
        }

        //This line of code filters the table based on entered name.
        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "name LIKE '%" + txtSearchName.Text + "%'";
            dgwMember.DataSource = dataView;
        }

        private void txtSearchIdNo_Enter(object sender, EventArgs e)
        {
            txtSearchName.Clear();
        }

        private void txtSearchName_Enter(object sender, EventArgs e)
        {
            txtSearchIdNo.Clear();
        }

        //This line of code will work if user right click on datagridview and then click this contextMenuStripItem.
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAddMember"] == null)
            {
                frmAddMember form = new frmAddMember();
                form.Show();
            }
            else
                Application.OpenForms["frmAddMember"].Activate();
            this.Close();
        }

        //This line of code will work if user right click on datagridview and then click this contextMenuStripItem. 
        //It sends the member's information to frmEditMember.
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditMember form = new frmEditMember();
            form.idNo = dgwMember.CurrentRow.Cells[0].Value.ToString();
            form.name = dgwMember.CurrentRow.Cells[1].Value.ToString();
            form.surname = dgwMember.CurrentRow.Cells[2].Value.ToString();
            form.tel = dgwMember.CurrentRow.Cells[3].Value.ToString();
            form.address = dgwMember.CurrentRow.Cells[4].Value.ToString();
            form.Show();
            this.Close();
        }

        //This line of code will work if user right click on datagridview and then click this contextMenuStripItem.
        //It removes the record from "member" table according to the id number and then refreshes the table.
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = new DialogResult();
                answer = MessageBox.Show("Üye kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand("delete from member where id_no=@id_no", con);
                    com.Parameters.AddWithValue("@id_no", dgwMember.CurrentRow.Cells["id_no"].Value.ToString());
                    com.ExecuteNonQuery();
                    table.Clear();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("select * from Member order by name", con);
                    adapter.Fill(table);
                    dgwMember.DataSource = table;
                    MessageBox.Show("Üye kaydı silinmiştir.");
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
