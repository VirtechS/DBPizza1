﻿using System;
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
    public partial class PayDayForm : Form
    {
        public PayDayForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        readonly SqlConnection con = new SqlConnection("Data Source=DESKTOP-8FMQ1MB;Initial Catalog=pizza_dasha;Integrated Security=True");

        private void paydayBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paydayBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaDataSet);

        }

        private void PayDayForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.position". При необходимости она может быть перемещена или удалена.
            this.positionTableAdapter.Fill(this.pizzaDataSet.position);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.pizzaDataSet.staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.payday". При необходимости она может быть перемещена или удалена.
            this.paydayTableAdapter.Fill(this.pizzaDataSet.payday);
            this.DGVPay.ReadOnly = true;
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
            this.paydayBindingSource.AddNew();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paydayBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaDataSet);
            MessageBox.Show("Сохранено");
        }

        private void BtnDell_Click(object sender, EventArgs e)
        {
            this.paydayBindingSource.RemoveCurrent();
        }

        private void TglEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (TglEdit.Checked == true)
            {
                DGVPay.ReadOnly = false;
                LblTgl.Text = "Изменения включены";
            }
            if (TglEdit.Checked == false)
            {
                DGVPay.ReadOnly = true;
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
                    Col = date1;
                    break;
                case 2:
                    Col = date2;
                    break;
                case 3:
                    Col = hours;
                    break;
                case 4:
                    Col = payhours;
                    break;
                case 5:
                    Col = sum;
                    break;
            }
            if (RBAsc.Checked)
            {
                DGVPay.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                DGVPay.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void BtnDellFilter_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM payday", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DGVPay.DataSource = dataTable;
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            this.paydayBindingSource.MoveFirst();
        }

        private void BrnBack_Click(object sender, EventArgs e)
        {
            this.paydayBindingSource.MovePrevious();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.paydayBindingSource.MoveNext();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            this.paydayBindingSource.MoveLast();
        }

        private void BtnAllFilter_Click(object sender, EventArgs e)
        {
            for (int index1 = 0; index1 < this.DGVPay.RowCount; ++index1)
            {
                this.DGVPay.Rows[index1].Selected = false;
                for (int index2 = 0; index2 < this.DGVPay.ColumnCount; ++index2)
                {
                    if (this.DGVPay.Rows[index1].Cells[index2].Value != null && this.DGVPay.Rows[index1].Cells[index2].Value.ToString().Contains(this.TxtAllFilter.Text))
                    {
                        this.DGVPay.Rows[index1].Selected = true;
                        break;
                    }
                }
            }
        }
        private void TxtCretFilter_TextChanged(object sender, EventArgs e)
        {
            if (this.CBoxCretFilter.Text == "ФИО Сотрудника")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM payday INNER JOIN staff ON payday.staff_id = staff.id WHERE staff.фио LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVPay.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Дата начала")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM payday WHERE StartDate LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVPay.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Дата конца")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM payday WHERE EndDate LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVPay.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Отработано часов")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM payday WHERE hours LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVPay.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Зарплата в час")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM payday WHERE SalaryPerHour LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVPay.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Сумма выплаты")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM payday WHERE total LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVPay.DataSource = dataTable;
            }
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

        private void PayDayForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}