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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        readonly SqlConnection con = new SqlConnection("Data Source=DESKTOP-8FMQ1MB;Initial Catalog=pizza_dasha;Integrated Security=True");

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.pizzaDataSet.client);
            this.DGVClients.ReadOnly = true;
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.AddNew();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaDataSet);
            MessageBox.Show("Сохранено");
        }

        private void BtnDell_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.RemoveCurrent();
        }

        private void TglEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (TglEdit.Checked == true)
            {
                DGVClients.ReadOnly = false;
                LblTgl.Text = "Изменения включены";
            }
            if (TglEdit.Checked == false)
            {
                DGVClients.ReadOnly = true;
                LblTgl.Text = "Изменения выключены";
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default;
            switch (LBoxFilter.SelectedIndex)
            {
                case 0:
                    Col = fio;
                    break;
                case 1:
                    Col = phone;
                    break;
            }
            if (RBAsc.Checked)
            {
                DGVClients.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                DGVClients.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void BtnDellFilter_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM client", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DGVClients.DataSource = dataTable;
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void ClientForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnAllFilter_Click(object sender, EventArgs e)
        {
            for (int index1 = 0; index1 < this.DGVClients.RowCount; ++index1)
            {
                this.DGVClients.Rows[index1].Selected = false;
                for (int index2 = 0; index2 < this.DGVClients.ColumnCount; ++index2)
                {
                    if (this.DGVClients.Rows[index1].Cells[index2].Value != null && this.DGVClients.Rows[index1].Cells[index2].Value.ToString().Contains(this.TxtAllFilter.Text))
                    {
                        this.DGVClients.Rows[index1].Selected = true;
                        break;
                    }
                }
            }
        }

        private void TxtCretFilter_TextChanged(object sender, EventArgs e)
        {
            if (this.CBoxCretFilter.Text == "ФИО Клиента")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM client WHERE name LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVClients.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Телефон")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM client WHERE phone LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVClients.DataSource = dataTable;
            }
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MoveFirst();
        }

        private void BrnBack_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MovePrevious();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MoveNext();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MoveLast();
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
