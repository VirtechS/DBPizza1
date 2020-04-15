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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        readonly SqlConnection con = new SqlConnection("Data Source=DESKTOP-8FMQ1MB;Initial Catalog=pizza_dasha;Integrated Security=True");

        private void StaffForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.position". При необходимости она может быть перемещена или удалена.
            this.positionTableAdapter.Fill(this.pizzaDataSet.position);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.pizzaDataSet.staff);
            this.positionTableAdapter.Fill(this.pizzaDataSet.position);
            this.staffTableAdapter.Fill(this.pizzaDataSet.staff);
            this.DGVStaff.ReadOnly = true;
            TxtAllFilter.Text = "Введите текст";
            TxtCretFilter.Text = "Введите текст";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void StaffForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.staffBindingSource.AddNew();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaDataSet);
            MessageBox.Show("Сохранено");
        }

        private void BtnDell_Click(object sender, EventArgs e)
        {
            this.staffBindingSource.RemoveCurrent();
        }

        private void TglEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (TglEdit.Checked == true)
            {
                DGVStaff.ReadOnly = false;
                LblTgl.Text = "Изменения включены";
            }
            if (TglEdit.Checked == false)
            {
                DGVStaff.ReadOnly = true;
                LblTgl.Text = "Изменения выключены";
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default;
            switch (LBoxFilter.SelectedIndex)
            {
                case 0:
                    Col = Login;
                    break;
                case 1:
                    Col = fio;
                    break;
                case 2:
                    Col = address;
                    break;
                case 3:
                    Col = position;
                    break;
                case 4:
                    Col = phone;
                    break;
                case 5:
                    Col = address;
                    break;
                case 6:
                    Col = email;
                    break;
            }
            if (RBAsc.Checked)
            {
                DGVStaff.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                DGVStaff.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void BtnDellFilter_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM staff", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DGVStaff.DataSource = dataTable;
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void BtnAllFilter_Click(object sender, EventArgs e)
        {
            for (int index1 = 0; index1 < this.DGVStaff.RowCount; ++index1)
            {
                this.DGVStaff.Rows[index1].Selected = false;
                for (int index2 = 0; index2 < this.DGVStaff.ColumnCount; ++index2)
                {
                    if (this.DGVStaff.Rows[index1].Cells[index2].Value != null && this.DGVStaff.Rows[index1].Cells[index2].Value.ToString().Contains(this.TxtAllFilter.Text))
                    {
                        this.DGVStaff.Rows[index1].Selected = true;
                        break;
                    }
                }
            }
        }

        private void TxtCretFilter_TextChanged(object sender, EventArgs e)
        {
            if (this.CBoxCretFilter.Text == "Логин")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM staff WHERE login LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVStaff.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Должность")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM staff INNER JOIN position ON staff.position_id = position.id WHERE position.name LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVStaff.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "ФИО")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM staff WHERE ФИО LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVStaff.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Телефон")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM staff WHERE phone LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVStaff.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Адрес")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM staff WHERE address LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVStaff.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Почта")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM staff WHERE email LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVStaff.DataSource = dataTable;
            }
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            this.staffBindingSource.MoveFirst();
        }

        private void BrnBack_Click(object sender, EventArgs e)
        {
            this.staffBindingSource.MovePrevious();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.staffBindingSource.MoveNext();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            this.staffBindingSource.MoveLast();
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
            if(TxtCretFilter.Text == "Введите текст")
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
