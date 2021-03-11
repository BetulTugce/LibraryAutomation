using System;
using System.Windows.Forms;

namespace libraryAutomation
{
    public partial class frmMain : Form
    {

        bool move;
        int mouse_x;
        int mouse_y;

        public frmMain()
        {
            InitializeComponent();
        }

        public string username;

        private void frmMain_Load(object sender, EventArgs e)
        {
            userToolStripMenuItem.Text = username;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAddMember"] == null)
            {
                frmAddMember form = new frmAddMember();
                form.Show();
            }
            else
                Application.OpenForms["frmAddMember"].Activate();
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmEditMember"] == null)
            {
                frmEditMember form = new frmEditMember();
                form.Show();
            }
            else
                Application.OpenForms["frmEditMember"].Activate();
        }

        private void btnListMember_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListMember"] == null)
            {
                frmListMember form = new frmListMember();
                form.Show();
            }
            else
                Application.OpenForms["frmListMember"].Activate();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmaddBook"] == null)
            {
                frmaddBook form = new frmaddBook();
                form.Show();
            }
            else
                Application.OpenForms["frmaddBook"].Activate();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmEditBook"] == null)
            {
                frmEditBook form = new frmEditBook();
                form.Show();
            }
            else
                Application.OpenForms["frmEditBook"].Activate();
        }

        private void btnListBook_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListBook"] == null)
            {
                frmListBook form = new frmListBook();
                form.Show();
            }
            else
                Application.OpenForms["frmListBook"].Activate();
        }

        private void btnGive_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmGiveBook"] == null)
            {
                frmGiveBook form = new frmGiveBook();
                form.Show();
            }
            else
                Application.OpenForms["frmGiveBook"].Activate();
        }

        private void btnTakeBack_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmTakeBackBook"] == null)
            {
                frmTakeBackBook form = new frmTakeBackBook();
                form.Show();
            }
            else
                Application.OpenForms["frmTackBackBook"].Activate();
        }

        private void btnEscrowedBooks_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmEscrowedBook"] == null)
            {
                frmEscrowedBook form = new frmEscrowedBook();
                form.Show();
            }
            else
                Application.OpenForms["frmEscrowedBook"].Activate();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Betül Tuğçe Dikdoğmuş tarafından geliştirilmiştir.", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAccount"] == null)
            {
                frmAccount form = new frmAccount();
                form.username = userToolStripMenuItem.Text; //Sends the username to frmMain.
                form.Show();
            }
        }
    }
}
