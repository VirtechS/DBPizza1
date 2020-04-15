using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPizza
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            this.Hide();
            staffForm.Show();
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
            PositionForm PositionForm = new PositionForm();
            this.Hide();
            PositionForm.Show();
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm CategoryForm = new CategoryForm();
            this.Hide();
            CategoryForm.Show();
        }
    }
}
