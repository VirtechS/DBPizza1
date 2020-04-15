﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPizza
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaDataSet);

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.item". При необходимости она может быть перемещена или удалена.
            this.itemTableAdapter.Fill(this.pizzaDataSet.item);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.pizzaDataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.pizzaDataSet.staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.order_item". При необходимости она может быть перемещена или удалена.
            this.order_itemTableAdapter.Fill(this.pizzaDataSet.order_item);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.pizzaDataSet.order);

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnFirst_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.MoveFirst();
        }

        private void BrnBack_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.MovePrevious();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.MoveNext();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.MoveLast();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.AddNew();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaDataSet);
            MessageBox.Show("Сохранено");
        }

        private void BtnDell_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.RemoveCurrent();
        }
    }
}
