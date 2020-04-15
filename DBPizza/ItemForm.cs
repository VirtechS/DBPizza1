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
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        readonly SqlConnection con = new SqlConnection("Data Source=DESKTOP-8FMQ1MB;Initial Catalog=pizza_dasha;Integrated Security=True");

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaDataSet);

        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.pizzaDataSet.category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.item". При необходимости она может быть перемещена или удалена.
            this.itemTableAdapter.Fill(this.pizzaDataSet.item);
            this.DGVItem.ReadOnly = true;
            TxtAllFilter.Text = "Введите текст";
            TxtCretFilter.Text = "Введите текст";

        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            this.itemBindingSource.MoveFirst();
        }

        private void BrnBack_Click(object sender, EventArgs e)
        {
            this.itemBindingSource.MovePrevious();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.itemBindingSource.MoveNext();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            this.itemBindingSource.MoveLast();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.itemBindingSource.AddNew();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaDataSet);
            MessageBox.Show("Сохранено");
        }

        private void BtnDell_Click(object sender, EventArgs e)
        {
            this.itemBindingSource.RemoveCurrent();
        }

        private void TglEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (TglEdit.Checked == true)
            {
                DGVItem.ReadOnly = false;
                LblTgl.Text = "Изменения включены";
            }
            if (TglEdit.Checked == false)
            {
                DGVItem.ReadOnly = true;
                LblTgl.Text = "Изменения выключены";
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default;
            switch (LBoxFilter.SelectedIndex)
            {
                case 0:
                    Col = title;
                    break;
                case 1:
                    Col = categoty;
                    break;
                case 2:
                    Col = price;
                    break;
                case 3:
                    Col = description;
                    break;
            }
            if (RBAsc.Checked)
            {
                DGVItem.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                DGVItem.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void BtnDellFilter_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM item", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DGVItem.DataSource = dataTable;
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void BtnAllFilter_Click(object sender, EventArgs e)
        {
            for (int index1 = 0; index1 < this.DGVItem.RowCount; ++index1)
            {
                this.DGVItem.Rows[index1].Selected = false;
                for (int index2 = 0; index2 < this.DGVItem.ColumnCount; ++index2)
                {
                    if (this.DGVItem.Rows[index1].Cells[index2].Value != null && this.DGVItem.Rows[index1].Cells[index2].Value.ToString().Contains(this.TxtAllFilter.Text))
                    {
                        this.DGVItem.Rows[index1].Selected = true;
                        break;
                    }
                }
            }
        }

        private void TxtCretFilter_TextChanged(object sender, EventArgs e)
        {
            if (this.CBoxCretFilter.Text == "Название")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM item WHERE title LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVItem.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Категория")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM item INNER JOIN category ON item.categoty_id = category.id WHERE position.name LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVItem.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Цена")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM item WHERE price LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVItem.DataSource = dataTable;
            }
            if (this.CBoxCretFilter.Text == "Описание")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM item WHERE description LIKE'" + this.TxtCretFilter.Text + "%'", con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGVItem.DataSource = dataTable;
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

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
