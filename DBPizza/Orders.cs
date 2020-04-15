using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPizza
{
    public partial class Orders : Form
    {
        int inOrderID = 0;
        string strConnectionString = @"Data Source=DESKTOP-8FMQ1MB;Initial Catalog=pizza_dasha;Integrated Security=True";
        OpenFileDialog ofd = new OpenFileDialog();
        public Orders()
        {
            InitializeComponent();
        }
        void Clear()
        {
            txtTotal.Text = "";
            dtpDates.Value = DateTime.Now;
            if (dgvEmpCompany.DataSource == null)
                dgvEmpCompany.Rows.Clear();
            else
                dgvEmpCompany.DataSource = (dgvEmpCompany.DataSource as DataTable).Clone();
            inOrderID = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }
        void StaffComboBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID,ФИО FROM staff", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                cmbStaff.ValueMember = "ID";
                cmbStaff.DisplayMember = "ФИО";
                cmbStaff.DataSource = dtbl;
            }

        }
        void ClientComboBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT id,name FROM client", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                cmbClient.ValueMember = "id";
                cmbClient.DisplayMember = "name";
                cmbClient.DataSource = dtbl;
            }
        }
        void item()
        {
            using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ItemID,title FROM item", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dtbl.Rows.InsertAt(topItem, 0);
                dgvcmbItem.ValueMember = "ItemID";
                dgvcmbItem.DisplayMember = "title";
                dgvcmbItem.DataSource = dtbl.Copy();
            }
        }
        private void dgvEmpCompany_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow dgvRow = dgvEmpCompany.CurrentRow;
            if (dgvRow.Cells["dgvtxtOrderItemID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are You Sure to Delete this Record ?", "Master Detail CRUD", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("order_itemDeleteDelete", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@OrderItemID", Convert.ToInt32(dgvRow.Cells["dgvtxtOrderItemID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateMasterDetailForm())
            {
                int _OrderID = 0;
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    //Master
                    SqlCommand sqlCmd = new SqlCommand("OrderAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@OrderID", inOrderID);
                    sqlCmd.Parameters.AddWithValue("@staff_id", Convert.ToInt32(cmbStaff.SelectedValue));
                    sqlCmd.Parameters.AddWithValue("@client_id", Convert.ToInt32(cmbClient.SelectedValue));
                    sqlCmd.Parameters.AddWithValue("@dates", dtpDates.Value);
                    sqlCmd.Parameters.AddWithValue("@total", txtTotal.Text.Trim());
                    _OrderID = Convert.ToInt32(sqlCmd.ExecuteScalar());
                }
                //Details
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    foreach (DataGridViewRow dgvRow in dgvEmpCompany.Rows)
                    {
                        if (dgvRow.IsNewRow) break;
                        else
                        {
                            SqlCommand sqlCmd = new SqlCommand("order_itemAddOrEdit", sqlCon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@OrderItemID", Convert.ToInt32(dgvRow.Cells["dgvtxtOrderItemID"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtOrderItemID"].Value));
                            sqlCmd.Parameters.AddWithValue("@OrderID", _OrderID);
                            sqlCmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(dgvRow.Cells["dgvtxtquantity"].Value == DBNull.Value ? "" : dgvRow.Cells["dgvtxtquantity"].Value));
                            sqlCmd.Parameters.AddWithValue("@price", Convert.ToInt32(dgvRow.Cells["price"].Value == DBNull.Value ? "" : dgvRow.Cells["price"].Value));
                            sqlCmd.Parameters.AddWithValue("@total", Convert.ToInt32(dgvRow.Cells["total"].Value == DBNull.Value ? "" : dgvRow.Cells["total"].Value));
                            sqlCmd.Parameters.AddWithValue("@ItemID", Convert.ToInt32(dgvRow.Cells["dgvcmbItem"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvcmbItem"].Value));
                            sqlCmd.Parameters.AddWithValue("@title", dgvRow.Cells["title"].Value == DBNull.Value ? "" : dgvRow.Cells["title"].Value);
                            sqlCmd.ExecuteNonQuery();
                        }
                    }
                }
                FillEmployeeDataGridView();
                Clear();
                MessageBox.Show("Submitted Successfully");
            }
        }
        bool ValidateMasterDetailForm()
        {
            bool _isValid = true;
            if (txtTotal.Text.Trim() == "")
            {
                MessageBox.Show("Требуется сумма");
                _isValid = false;
            }
            //Add more validations if needed.
            return _isValid;
        }
        void FillEmployeeDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("OrderViewAll", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvEmployee.DataSource = dtbl;
                dgvEmployee.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEmployee.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvEmployee.Columns[0].Visible = false;
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Delete this Record ?", "Master Detail CRUD", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("OrderDelete", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@OrderID", inOrderID);
                    sqlCmd.ExecuteNonQuery();
                    Clear();
                    FillEmployeeDataGridView();
                    MessageBox.Show("Deleted Successfully");
                };
        }
    }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow.Index != -1)
            {
                DataGridViewRow _dgvCurrentRow = dgvEmployee.CurrentRow;
                inOrderID = Convert.ToInt32(_dgvCurrentRow.Cells[0].Value);
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("OrderViewByID", sqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@OrderID", inOrderID);
                    DataSet ds = new DataSet();
                    sqlDa.Fill(ds);

                    //Master - Fill
                    DataRow dr = ds.Tables[0].Rows[0];
                    cmbStaff.SelectedValue = Convert.ToInt32(dr["staff_id"].ToString());
                    cmbClient.SelectedValue = Convert.ToInt32(dr["client_id"].ToString());
                    dtpDates.Value = Convert.ToDateTime(dr["dates"].ToString());
                    txtTotal.Text = dr["total"].ToString();
                    dgvEmpCompany.AutoGenerateColumns = false;
                    dgvEmpCompany.DataSource = ds.Tables[1];
                    btnDelete.Enabled = true;
                    btnSave.Text = "Update";
                    tabControl.SelectedIndex = 0;
                }
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            StaffComboBoxFill();
            ClientComboBoxFill();
            Clear();
            FillEmployeeDataGridView();
            item();

        }
        private void dgvEmpCompany_Click(object sender, EventArgs e)
        {
            int sum = 0;
            decimal sumd = 0;
            for (int i = 0; i < dgvEmpCompany.RowCount; i++)
            {
                sum += Convert.ToInt32(dgvEmpCompany.Rows[i].Cells[4].Value) * Convert.ToInt32(dgvEmpCompany.Rows[i].Cells[3].Value);
                Convert.ToInt32(dgvEmpCompany.Rows[i].Cells[5].Value = sum);
            }
            for (int i = 0; i < dgvEmpCompany.RowCount; i++)
            {
                sumd += Convert.ToInt32(dgvEmpCompany.Rows[i].Cells[5].Value);
            }
            string back = sum.ToString();
            txtTotal.Text = back;
        }
    }
}
