namespace DBPizza
{
    partial class PayDayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayDayForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnRoll = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.paydayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paydayTableAdapter = new DBPizza.PizzaDataSetTableAdapters.paydayTableAdapter();
            this.tableAdapterManager = new DBPizza.PizzaDataSetTableAdapters.TableAdapterManager();
            this.staffTableAdapter = new DBPizza.PizzaDataSetTableAdapters.staffTableAdapter();
            this.DGVPay = new Guna.UI2.WinForms.Guna2DataGridView();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionTableAdapter = new DBPizza.PizzaDataSetTableAdapters.positionTableAdapter();
            this.LblTgl = new System.Windows.Forms.Label();
            this.TglEdit = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.BtnDell = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.LBoxFilter = new System.Windows.Forms.ListBox();
            this.GBoxFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.LblRBDes = new System.Windows.Forms.Label();
            this.RBDesc = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.LblRBAsc = new System.Windows.Forms.Label();
            this.RBAsc = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.BtnMainMenu = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDellFilter = new Guna.UI2.WinForms.Guna2Button();
            this.GBoxAllFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtAllFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnAllFilter = new Guna.UI2.WinForms.Guna2Button();
            this.TxtCretFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBoxCretFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BtnLast = new Guna.UI2.WinForms.Guna2Button();
            this.BtnNext = new Guna.UI2.WinForms.Guna2Button();
            this.BrnBack = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFirst = new Guna.UI2.WinForms.Guna2Button();
            this.GBoxCretFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pizzaDataSet = new DBPizza.PizzaDataSet();
            this.paydayBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payhours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paydayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            this.GBoxFilter.SuspendLayout();
            this.GBoxAllFilter.SuspendLayout();
            this.GBoxCretFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paydayBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 40);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "Зарплаты";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // BtnRoll
            // 
            this.BtnRoll.Image = ((System.Drawing.Image)(resources.GetObject("BtnRoll.Image")));
            this.BtnRoll.Location = new System.Drawing.Point(1049, 18);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(34, 33);
            this.BtnRoll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRoll.TabIndex = 45;
            this.BtnRoll.TabStop = false;
            this.BtnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(1089, 18);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(34, 33);
            this.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnExit.TabIndex = 44;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // paydayBindingSource
            // 
            this.paydayBindingSource.DataMember = "payday";
            // 
            // paydayTableAdapter
            // 
            this.paydayTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.order_itemTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.paydayTableAdapter = this.paydayTableAdapter;
            this.tableAdapterManager.positionTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.UpdateOrder = DBPizza.PizzaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // DGVPay
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVPay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPay.AutoGenerateColumns = false;
            this.DGVPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVPay.BackgroundColor = System.Drawing.Color.White;
            this.DGVPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVPay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPay.ColumnHeadersHeight = 21;
            this.DGVPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.staff_id,
            this.date1,
            this.date2,
            this.hours,
            this.payhours,
            this.sum});
            this.DGVPay.DataSource = this.paydayBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPay.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPay.EnableHeadersVisualStyles = false;
            this.DGVPay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVPay.Location = new System.Drawing.Point(16, 57);
            this.DGVPay.Name = "DGVPay";
            this.DGVPay.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPay.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPay.Size = new System.Drawing.Size(860, 469);
            this.DGVPay.TabIndex = 63;
            this.DGVPay.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVPay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVPay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVPay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVPay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVPay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVPay.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVPay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVPay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVPay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVPay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVPay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVPay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVPay.ThemeStyle.HeaderStyle.Height = 21;
            this.DGVPay.ThemeStyle.ReadOnly = false;
            this.DGVPay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVPay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVPay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVPay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVPay.ThemeStyle.RowsStyle.Height = 22;
            this.DGVPay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVPay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "position";
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // LblTgl
            // 
            this.LblTgl.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTgl.Location = new System.Drawing.Point(919, 220);
            this.LblTgl.Margin = new System.Windows.Forms.Padding(0);
            this.LblTgl.Name = "LblTgl";
            this.LblTgl.Size = new System.Drawing.Size(207, 20);
            this.LblTgl.TabIndex = 68;
            this.LblTgl.Text = "Изменения выключены";
            this.LblTgl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblTgl.UseCompatibleTextRendering = true;
            // 
            // TglEdit
            // 
            this.TglEdit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TglEdit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TglEdit.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TglEdit.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TglEdit.CheckedState.Parent = this.TglEdit;
            this.TglEdit.Location = new System.Drawing.Point(882, 220);
            this.TglEdit.Name = "TglEdit";
            this.TglEdit.ShadowDecoration.Parent = this.TglEdit;
            this.TglEdit.Size = new System.Drawing.Size(35, 20);
            this.TglEdit.TabIndex = 67;
            this.TglEdit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TglEdit.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TglEdit.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TglEdit.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TglEdit.UncheckedState.Parent = this.TglEdit;
            this.TglEdit.CheckedChanged += new System.EventHandler(this.TglEdit_CheckedChanged);
            // 
            // BtnDell
            // 
            this.BtnDell.CheckedState.Parent = this.BtnDell;
            this.BtnDell.CustomImages.Parent = this.BtnDell;
            this.BtnDell.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDell.ForeColor = System.Drawing.Color.White;
            this.BtnDell.HoverState.Parent = this.BtnDell;
            this.BtnDell.Location = new System.Drawing.Point(882, 159);
            this.BtnDell.Name = "BtnDell";
            this.BtnDell.ShadowDecoration.Parent = this.BtnDell;
            this.BtnDell.Size = new System.Drawing.Size(244, 45);
            this.BtnDell.TabIndex = 66;
            this.BtnDell.Text = "Удалить";
            this.BtnDell.Click += new System.EventHandler(this.BtnDell_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.CheckedState.Parent = this.BtnSave;
            this.BtnSave.CustomImages.Parent = this.BtnSave;
            this.BtnSave.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.HoverState.Parent = this.BtnSave;
            this.BtnSave.Location = new System.Drawing.Point(882, 108);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.ShadowDecoration.Parent = this.BtnSave;
            this.BtnSave.Size = new System.Drawing.Size(244, 45);
            this.BtnSave.TabIndex = 65;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.CheckedState.Parent = this.BtnAdd;
            this.BtnAdd.CustomImages.Parent = this.BtnAdd;
            this.BtnAdd.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.HoverState.Parent = this.BtnAdd;
            this.BtnAdd.Location = new System.Drawing.Point(882, 57);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.ShadowDecoration.Parent = this.BtnAdd;
            this.BtnAdd.Size = new System.Drawing.Size(244, 45);
            this.BtnAdd.TabIndex = 64;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LBoxFilter
            // 
            this.LBoxFilter.FormattingEnabled = true;
            this.LBoxFilter.ItemHeight = 18;
            this.LBoxFilter.Items.AddRange(new object[] {
            "ФИО Сотрудника",
            "Дата начала",
            "Дата конца",
            "Отработано часов",
            "Зарплата в час",
            "Сумма выплаты"});
            this.LBoxFilter.Location = new System.Drawing.Point(3, 49);
            this.LBoxFilter.Name = "LBoxFilter";
            this.LBoxFilter.Size = new System.Drawing.Size(227, 112);
            this.LBoxFilter.TabIndex = 0;
            // 
            // GBoxFilter
            // 
            this.GBoxFilter.BackColor = System.Drawing.Color.White;
            this.GBoxFilter.Controls.Add(this.guna2Button1);
            this.GBoxFilter.Controls.Add(this.BtnFilter);
            this.GBoxFilter.Controls.Add(this.LblRBDes);
            this.GBoxFilter.Controls.Add(this.RBDesc);
            this.GBoxFilter.Controls.Add(this.LblRBAsc);
            this.GBoxFilter.Controls.Add(this.RBAsc);
            this.GBoxFilter.Controls.Add(this.LBoxFilter);
            this.GBoxFilter.Controls.Add(this.BtnMainMenu);
            this.GBoxFilter.Controls.Add(this.BtnDellFilter);
            this.GBoxFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GBoxFilter.FillColor = System.Drawing.SystemColors.Window;
            this.GBoxFilter.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBoxFilter.ForeColor = System.Drawing.Color.White;
            this.GBoxFilter.Location = new System.Drawing.Point(882, 253);
            this.GBoxFilter.Name = "GBoxFilter";
            this.GBoxFilter.ShadowDecoration.Parent = this.GBoxFilter;
            this.GBoxFilter.Size = new System.Drawing.Size(244, 426);
            this.GBoxFilter.TabIndex = 69;
            this.GBoxFilter.Text = "Сортировка";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2Button1.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(3, 372);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(238, 45);
            this.guna2Button1.TabIndex = 63;
            this.guna2Button1.Text = "Информация";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // BtnFilter
            // 
            this.BtnFilter.CheckedState.Parent = this.BtnFilter;
            this.BtnFilter.CustomImages.Parent = this.BtnFilter;
            this.BtnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnFilter.ForeColor = System.Drawing.Color.White;
            this.BtnFilter.HoverState.Parent = this.BtnFilter;
            this.BtnFilter.Location = new System.Drawing.Point(3, 228);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.ShadowDecoration.Parent = this.BtnFilter;
            this.BtnFilter.Size = new System.Drawing.Size(238, 45);
            this.BtnFilter.TabIndex = 50;
            this.BtnFilter.Text = "Сортировать";
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // LblRBDes
            // 
            this.LblRBDes.BackColor = System.Drawing.Color.White;
            this.LblRBDes.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRBDes.ForeColor = System.Drawing.Color.DimGray;
            this.LblRBDes.Location = new System.Drawing.Point(26, 196);
            this.LblRBDes.Margin = new System.Windows.Forms.Padding(0);
            this.LblRBDes.Name = "LblRBDes";
            this.LblRBDes.Size = new System.Drawing.Size(204, 20);
            this.LblRBDes.TabIndex = 51;
            this.LblRBDes.Text = "Сортировать по убыванию";
            this.LblRBDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblRBDes.UseCompatibleTextRendering = true;
            // 
            // RBDesc
            // 
            this.RBDesc.BackColor = System.Drawing.Color.White;
            this.RBDesc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBDesc.CheckedState.BorderThickness = 0;
            this.RBDesc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBDesc.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RBDesc.CheckedState.Parent = this.RBDesc;
            this.RBDesc.Location = new System.Drawing.Point(3, 196);
            this.RBDesc.Name = "RBDesc";
            this.RBDesc.ShadowDecoration.Parent = this.RBDesc;
            this.RBDesc.Size = new System.Drawing.Size(20, 20);
            this.RBDesc.TabIndex = 52;
            this.RBDesc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RBDesc.UncheckedState.BorderThickness = 2;
            this.RBDesc.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RBDesc.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RBDesc.UncheckedState.Parent = this.RBDesc;
            // 
            // LblRBAsc
            // 
            this.LblRBAsc.BackColor = System.Drawing.Color.White;
            this.LblRBAsc.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRBAsc.ForeColor = System.Drawing.Color.DimGray;
            this.LblRBAsc.Location = new System.Drawing.Point(26, 167);
            this.LblRBAsc.Margin = new System.Windows.Forms.Padding(0);
            this.LblRBAsc.Name = "LblRBAsc";
            this.LblRBAsc.Size = new System.Drawing.Size(204, 20);
            this.LblRBAsc.TabIndex = 50;
            this.LblRBAsc.Text = "Сортировать по возростанию";
            this.LblRBAsc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblRBAsc.UseCompatibleTextRendering = true;
            // 
            // RBAsc
            // 
            this.RBAsc.BackColor = System.Drawing.Color.White;
            this.RBAsc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBAsc.CheckedState.BorderThickness = 0;
            this.RBAsc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBAsc.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RBAsc.CheckedState.Parent = this.RBAsc;
            this.RBAsc.Location = new System.Drawing.Point(3, 167);
            this.RBAsc.Name = "RBAsc";
            this.RBAsc.ShadowDecoration.Parent = this.RBAsc;
            this.RBAsc.Size = new System.Drawing.Size(20, 20);
            this.RBAsc.TabIndex = 50;
            this.RBAsc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RBAsc.UncheckedState.BorderThickness = 2;
            this.RBAsc.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RBAsc.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RBAsc.UncheckedState.Parent = this.RBAsc;
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.CheckedState.Parent = this.BtnMainMenu;
            this.BtnMainMenu.CustomImages.Parent = this.BtnMainMenu;
            this.BtnMainMenu.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMainMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMainMenu.HoverState.Parent = this.BtnMainMenu;
            this.BtnMainMenu.Location = new System.Drawing.Point(3, 330);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.ShadowDecoration.Parent = this.BtnMainMenu;
            this.BtnMainMenu.Size = new System.Drawing.Size(238, 40);
            this.BtnMainMenu.TabIndex = 62;
            this.BtnMainMenu.Text = "Выйти в главное меню";
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // BtnDellFilter
            // 
            this.BtnDellFilter.CheckedState.Parent = this.BtnDellFilter;
            this.BtnDellFilter.CustomImages.Parent = this.BtnDellFilter;
            this.BtnDellFilter.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDellFilter.ForeColor = System.Drawing.Color.White;
            this.BtnDellFilter.HoverState.Parent = this.BtnDellFilter;
            this.BtnDellFilter.Location = new System.Drawing.Point(3, 279);
            this.BtnDellFilter.Name = "BtnDellFilter";
            this.BtnDellFilter.ShadowDecoration.Parent = this.BtnDellFilter;
            this.BtnDellFilter.Size = new System.Drawing.Size(238, 37);
            this.BtnDellFilter.TabIndex = 61;
            this.BtnDellFilter.Text = "Сбросить все фильтры";
            this.BtnDellFilter.Click += new System.EventHandler(this.BtnDellFilter_Click);
            // 
            // GBoxAllFilter
            // 
            this.GBoxAllFilter.BackColor = System.Drawing.Color.Transparent;
            this.GBoxAllFilter.Controls.Add(this.TxtAllFilter);
            this.GBoxAllFilter.Controls.Add(this.BtnAllFilter);
            this.GBoxAllFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GBoxAllFilter.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBoxAllFilter.ForeColor = System.Drawing.SystemColors.Window;
            this.GBoxAllFilter.Location = new System.Drawing.Point(464, 583);
            this.GBoxAllFilter.Name = "GBoxAllFilter";
            this.GBoxAllFilter.ShadowDecoration.Parent = this.GBoxAllFilter;
            this.GBoxAllFilter.Size = new System.Drawing.Size(412, 96);
            this.GBoxAllFilter.TabIndex = 78;
            this.GBoxAllFilter.Text = "Общий поиск";
            // 
            // TxtAllFilter
            // 
            this.TxtAllFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAllFilter.DefaultText = "";
            this.TxtAllFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAllFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAllFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAllFilter.DisabledState.Parent = this.TxtAllFilter;
            this.TxtAllFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAllFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAllFilter.FocusedState.Parent = this.TxtAllFilter;
            this.TxtAllFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAllFilter.HoverState.Parent = this.TxtAllFilter;
            this.TxtAllFilter.Location = new System.Drawing.Point(5, 51);
            this.TxtAllFilter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtAllFilter.Name = "TxtAllFilter";
            this.TxtAllFilter.PasswordChar = '\0';
            this.TxtAllFilter.PlaceholderText = "";
            this.TxtAllFilter.SelectedText = "";
            this.TxtAllFilter.ShadowDecoration.Parent = this.TxtAllFilter;
            this.TxtAllFilter.Size = new System.Drawing.Size(201, 39);
            this.TxtAllFilter.TabIndex = 57;
            this.TxtAllFilter.Enter += new System.EventHandler(this.TxtAllFilter_Enter);
            this.TxtAllFilter.Leave += new System.EventHandler(this.TxtAllFilter_Leave);
            // 
            // BtnAllFilter
            // 
            this.BtnAllFilter.CheckedState.Parent = this.BtnAllFilter;
            this.BtnAllFilter.CustomImages.Parent = this.BtnAllFilter;
            this.BtnAllFilter.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAllFilter.ForeColor = System.Drawing.Color.White;
            this.BtnAllFilter.HoverState.Parent = this.BtnAllFilter;
            this.BtnAllFilter.Location = new System.Drawing.Point(214, 51);
            this.BtnAllFilter.Name = "BtnAllFilter";
            this.BtnAllFilter.ShadowDecoration.Parent = this.BtnAllFilter;
            this.BtnAllFilter.Size = new System.Drawing.Size(180, 36);
            this.BtnAllFilter.TabIndex = 57;
            this.BtnAllFilter.Text = "Найти";
            this.BtnAllFilter.Click += new System.EventHandler(this.BtnAllFilter_Click);
            // 
            // TxtCretFilter
            // 
            this.TxtCretFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCretFilter.DefaultText = "";
            this.TxtCretFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCretFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCretFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCretFilter.DisabledState.Parent = this.TxtCretFilter;
            this.TxtCretFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCretFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCretFilter.FocusedState.Parent = this.TxtCretFilter;
            this.TxtCretFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCretFilter.HoverState.Parent = this.TxtCretFilter;
            this.TxtCretFilter.Location = new System.Drawing.Point(203, 50);
            this.TxtCretFilter.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCretFilter.Name = "TxtCretFilter";
            this.TxtCretFilter.PasswordChar = '\0';
            this.TxtCretFilter.PlaceholderText = "";
            this.TxtCretFilter.SelectedText = "";
            this.TxtCretFilter.ShadowDecoration.Parent = this.TxtCretFilter;
            this.TxtCretFilter.Size = new System.Drawing.Size(205, 36);
            this.TxtCretFilter.TabIndex = 56;
            this.TxtCretFilter.TextChanged += new System.EventHandler(this.TxtCretFilter_TextChanged);
            this.TxtCretFilter.Enter += new System.EventHandler(this.TxtCretFilter_Enter);
            this.TxtCretFilter.Leave += new System.EventHandler(this.TxtCretFilter_Leave);
            // 
            // CBoxCretFilter
            // 
            this.CBoxCretFilter.BackColor = System.Drawing.Color.Transparent;
            this.CBoxCretFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBoxCretFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxCretFilter.FocusedColor = System.Drawing.Color.Empty;
            this.CBoxCretFilter.FocusedState.Parent = this.CBoxCretFilter;
            this.CBoxCretFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBoxCretFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBoxCretFilter.FormattingEnabled = true;
            this.CBoxCretFilter.HoverState.Parent = this.CBoxCretFilter;
            this.CBoxCretFilter.ItemHeight = 30;
            this.CBoxCretFilter.Items.AddRange(new object[] {
            "ФИО Сотрудника",
            "Дата начала",
            "Дата конца",
            "Отработано часов",
            "Зарплата в час",
            "Сумма выплаты"});
            this.CBoxCretFilter.ItemsAppearance.Parent = this.CBoxCretFilter;
            this.CBoxCretFilter.Location = new System.Drawing.Point(3, 50);
            this.CBoxCretFilter.Name = "CBoxCretFilter";
            this.CBoxCretFilter.ShadowDecoration.Parent = this.CBoxCretFilter;
            this.CBoxCretFilter.Size = new System.Drawing.Size(194, 36);
            this.CBoxCretFilter.TabIndex = 56;
            // 
            // BtnLast
            // 
            this.BtnLast.CheckedState.Parent = this.BtnLast;
            this.BtnLast.CustomImages.Parent = this.BtnLast;
            this.BtnLast.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLast.ForeColor = System.Drawing.Color.White;
            this.BtnLast.HoverState.Parent = this.BtnLast;
            this.BtnLast.Location = new System.Drawing.Point(726, 532);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.ShadowDecoration.Parent = this.BtnLast;
            this.BtnLast.Size = new System.Drawing.Size(150, 40);
            this.BtnLast.TabIndex = 83;
            this.BtnLast.Text = "Последняя";
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.CheckedState.Parent = this.BtnNext;
            this.BtnNext.CustomImages.Parent = this.BtnNext;
            this.BtnNext.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNext.ForeColor = System.Drawing.Color.White;
            this.BtnNext.HoverState.Parent = this.BtnNext;
            this.BtnNext.Location = new System.Drawing.Point(479, 532);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.ShadowDecoration.Parent = this.BtnNext;
            this.BtnNext.Size = new System.Drawing.Size(150, 40);
            this.BtnNext.TabIndex = 82;
            this.BtnNext.Text = "Следующая";
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BrnBack
            // 
            this.BrnBack.CheckedState.Parent = this.BrnBack;
            this.BrnBack.CustomImages.Parent = this.BrnBack;
            this.BrnBack.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrnBack.ForeColor = System.Drawing.Color.White;
            this.BrnBack.HoverState.Parent = this.BrnBack;
            this.BrnBack.Location = new System.Drawing.Point(274, 532);
            this.BrnBack.Name = "BrnBack";
            this.BrnBack.ShadowDecoration.Parent = this.BrnBack;
            this.BrnBack.Size = new System.Drawing.Size(150, 40);
            this.BrnBack.TabIndex = 81;
            this.BrnBack.Text = "Предыдущая";
            this.BrnBack.Click += new System.EventHandler(this.BrnBack_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.CheckedState.Parent = this.BtnFirst;
            this.BtnFirst.CustomImages.Parent = this.BtnFirst;
            this.BtnFirst.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFirst.ForeColor = System.Drawing.Color.White;
            this.BtnFirst.HoverState.Parent = this.BtnFirst;
            this.BtnFirst.Location = new System.Drawing.Point(16, 532);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.ShadowDecoration.Parent = this.BtnFirst;
            this.BtnFirst.Size = new System.Drawing.Size(150, 40);
            this.BtnFirst.TabIndex = 80;
            this.BtnFirst.Text = "Первая";
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // GBoxCretFilter
            // 
            this.GBoxCretFilter.BackColor = System.Drawing.Color.Transparent;
            this.GBoxCretFilter.Controls.Add(this.TxtCretFilter);
            this.GBoxCretFilter.Controls.Add(this.CBoxCretFilter);
            this.GBoxCretFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GBoxCretFilter.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBoxCretFilter.ForeColor = System.Drawing.SystemColors.Window;
            this.GBoxCretFilter.Location = new System.Drawing.Point(16, 583);
            this.GBoxCretFilter.Name = "GBoxCretFilter";
            this.GBoxCretFilter.ShadowDecoration.Parent = this.GBoxCretFilter;
            this.GBoxCretFilter.Size = new System.Drawing.Size(422, 96);
            this.GBoxCretFilter.TabIndex = 79;
            this.GBoxCretFilter.Text = "Поиск по критериям";
            // 
            // pizzaDataSet
            // 
            this.pizzaDataSet.DataSetName = "PizzaDataSet";
            this.pizzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paydayBindingSource1
            // 
            this.paydayBindingSource1.DataMember = "payday";
            this.paydayBindingSource1.DataSource = this.pizzaDataSet;
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "staff";
            this.staffBindingSource1.DataSource = this.pizzaDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // staff_id
            // 
            this.staff_id.DataPropertyName = "staff_id";
            this.staff_id.DataSource = this.staffBindingSource1;
            this.staff_id.DisplayMember = "ФИО";
            this.staff_id.HeaderText = "staff_id";
            this.staff_id.Name = "staff_id";
            this.staff_id.ValueMember = "id";
            // 
            // date1
            // 
            this.date1.DataPropertyName = "StartDate";
            this.date1.HeaderText = "Дата начала";
            this.date1.Name = "date1";
            // 
            // date2
            // 
            this.date2.DataPropertyName = "EndDate";
            this.date2.HeaderText = "Дата окончания";
            this.date2.Name = "date2";
            // 
            // hours
            // 
            this.hours.DataPropertyName = "hours";
            this.hours.HeaderText = "Отработано часов";
            this.hours.Name = "hours";
            // 
            // payhours
            // 
            this.payhours.DataPropertyName = "SalaryPerHour";
            this.payhours.HeaderText = "Зарплата в час";
            this.payhours.Name = "payhours";
            // 
            // sum
            // 
            this.sum.DataPropertyName = "total";
            this.sum.HeaderText = "Сумма выплат";
            this.sum.Name = "sum";
            // 
            // PayDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1144, 700);
            this.Controls.Add(this.GBoxAllFilter);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BrnBack);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.GBoxCretFilter);
            this.Controls.Add(this.LblTgl);
            this.Controls.Add(this.TglEdit);
            this.Controls.Add(this.BtnDell);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.GBoxFilter);
            this.Controls.Add(this.DGVPay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnRoll);
            this.Controls.Add(this.BtnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayDayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayDayForm";
            this.Load += new System.EventHandler(this.PayDayForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PayDayForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.BtnRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paydayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            this.GBoxFilter.ResumeLayout(false);
            this.GBoxAllFilter.ResumeLayout(false);
            this.GBoxCretFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paydayBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox BtnRoll;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.BindingSource paydayBindingSource;
        private PizzaDataSetTableAdapters.paydayTableAdapter paydayTableAdapter;
        private PizzaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PizzaDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView DGVPay;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private PizzaDataSetTableAdapters.positionTableAdapter positionTableAdapter;
        private System.Windows.Forms.Label LblTgl;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TglEdit;
        private Guna.UI2.WinForms.Guna2Button BtnDell;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
        private Guna.UI2.WinForms.Guna2Button BtnAdd;
        private System.Windows.Forms.ListBox LBoxFilter;
        private Guna.UI2.WinForms.Guna2GroupBox GBoxFilter;
        private Guna.UI2.WinForms.Guna2Button BtnFilter;
        private System.Windows.Forms.Label LblRBDes;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RBDesc;
        private System.Windows.Forms.Label LblRBAsc;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RBAsc;
        private Guna.UI2.WinForms.Guna2Button BtnMainMenu;
        private Guna.UI2.WinForms.Guna2Button BtnDellFilter;
        private Guna.UI2.WinForms.Guna2GroupBox GBoxAllFilter;
        private Guna.UI2.WinForms.Guna2TextBox TxtAllFilter;
        private Guna.UI2.WinForms.Guna2Button BtnAllFilter;
        private Guna.UI2.WinForms.Guna2TextBox TxtCretFilter;
        private Guna.UI2.WinForms.Guna2ComboBox CBoxCretFilter;
        private Guna.UI2.WinForms.Guna2Button BtnLast;
        private Guna.UI2.WinForms.Guna2Button BtnNext;
        private Guna.UI2.WinForms.Guna2Button BrnBack;
        private Guna.UI2.WinForms.Guna2Button BtnFirst;
        private Guna.UI2.WinForms.Guna2GroupBox GBoxCretFilter;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.BindingSource paydayBindingSource1;
        private PizzaDataSet pizzaDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn staff_id;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn payhours;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
    }
}