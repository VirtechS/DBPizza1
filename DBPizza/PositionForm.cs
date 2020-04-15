using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPizza
{
    public partial class PositionForm : Form
    {
        public PositionForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        readonly SqlConnection con = new SqlConnection("Data Source=DESKTOP-8FMQ1MB;Initial Catalog=pizza_dasha;Integrated Security=True");

        private void positionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.positionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaDataSet);

        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            this.DGVPosition.ReadOnly = true;
            TxtAllFilter.Text = "Введите текст";
            TxtCretFilter.Text = "Введите текст";
            this.positionTableAdapter.Fill(this.pizzaDataSet.position);

        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PositionForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.positionBindingSource.AddNew();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.positionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaDataSet);
            MessageBox.Show("Сохранено");
        }

        private void BtnDell_Click(object sender, EventArgs e)
        {
            this.positionBindingSource.RemoveCurrent();
        }

        private void TglEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (TglEdit.Checked == true)
            {
                DGVPosition.ReadOnly = false;
                LblTgl.Text = "Изменения включены";
            }
            if (TglEdit.Checked == false)
            {
                DGVPosition.ReadOnly = true;
                LblTgl.Text = "Изменения выключены";
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default;
            switch (LBoxFilter.SelectedIndex)
            {
                case 0:
                    Col = name;
                    break;
                case 1:
                    Col = salary;
                    break;
            }
            if (RBAsc.Checked)
            {
                DGVPosition.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                DGVPosition.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void BtnDellFilter_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM position", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DGVPosition.DataSource = dataTable;
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void BtnAllFilter_Click(object sender, EventArgs e)
        {
            for (int index1 = 0; index1 < this.DGVPosition.RowCount; ++index1)
            {
                this.DGVPosition.Rows[index1].Selected = false;
                for (int index2 = 0; index2 < this.DGVPosition.ColumnCount; ++index2)
                {
                    if (this.DGVPosition.Rows[index1].Cells[index2].Value != null && this.DGVPosition.Rows[index1].Cells[index2].Value.ToString().Contains(this.TxtAllFilter.Text))
                    {
                        this.DGVPosition.Rows[index1].Selected = true;
                        break;
                    }
                }
            }
        }

        private void TxtCretFilter_TextChanged(object sender, EventArgs e)
        {
            if (this.CBoxCretFilter.Text == "Название")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM staff WHERE name LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVPosition.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Зарплата")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM staff WHERE salary LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVPosition.DataSource = dataTable;
            }
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            this.positionBindingSource.MoveFirst();
        }

        private void BrnBack_Click(object sender, EventArgs e)
        {
            this.positionBindingSource.MovePrevious();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.positionBindingSource.MoveNext();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            this.positionBindingSource.MoveLast();
        }

        private void TxtAllFilter_Enter(object sender, EventArgs e)
        {
            if (TxtAllFilter.Text == "Введите текст")
            {
                TxtAllFilter.Text = "";
            }
        }

        private void TxtAllFilter_Leave(object sender, EventArgs e)
        {
            if (TxtAllFilter.Text == "")
            {
                TxtAllFilter.Text = "Введите текст";
            }
        }

        private void TxtCretFilter_Enter(object sender, EventArgs e)
        {
            if (TxtCretFilter.Text == "Введите текст")
            {
                TxtCretFilter.Text = "";
            }
        }

        private void TxtCretFilter_Leave(object sender, EventArgs e)
        {
            if (TxtCretFilter.Text == "")
            {
                TxtCretFilter.Text = "Введите текст";
            }
        }
    }
}
