namespace DBPizza
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Категории = new System.Windows.Forms.Label();
            this.BtnRoll = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.pizzaDataSet = new DBPizza.PizzaDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new DBPizza.PizzaDataSetTableAdapters.orderTableAdapter();
            this.tableAdapterManager = new DBPizza.PizzaDataSetTableAdapters.TableAdapterManager();
            this.order_itemTableAdapter = new DBPizza.PizzaDataSetTableAdapters.order_itemTableAdapter();
            this.order_itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GBoxOrderInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.LblRBAsc = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new DBPizza.PizzaDataSetTableAdapters.staffTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new DBPizza.PizzaDataSetTableAdapters.clientTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.fKorderitemorder1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new DBPizza.PizzaDataSetTableAdapters.itemTableAdapter();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnLast = new Guna.UI2.WinForms.Guna2Button();
            this.BtnNext = new Guna.UI2.WinForms.Guna2Button();
            this.BrnBack = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFirst = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDell = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_itemBindingSource)).BeginInit();
            this.GBoxOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKorderitemorder1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Категории
            // 
            this.Категории.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Категории.Location = new System.Drawing.Point(9, 5);
            this.Категории.Margin = new System.Windows.Forms.Padding(0);
            this.Категории.Name = "Категории";
            this.Категории.Size = new System.Drawing.Size(234, 40);
            this.Категории.TabIndex = 76;
            this.Категории.Text = "Должности";
            this.Категории.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Категории.UseCompatibleTextRendering = true;
            // 
            // BtnRoll
            // 
            this.BtnRoll.Image = ((System.Drawing.Image)(resources.GetObject("BtnRoll.Image")));
            this.BtnRoll.Location = new System.Drawing.Point(714, 12);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(34, 33);
            this.BtnRoll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRoll.TabIndex = 78;
            this.BtnRoll.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(754, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(34, 33);
            this.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnExit.TabIndex = 77;
            this.BtnExit.TabStop = false;
            // 
            // pizzaDataSet
            // 
            this.pizzaDataSet.DataSetName = "PizzaDataSet";
            this.pizzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.pizzaDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.order_itemTableAdapter = this.order_itemTableAdapter;
            this.tableAdapterManager.orderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.paydayTableAdapter = null;
            this.tableAdapterManager.positionTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DBPizza.PizzaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // order_itemTableAdapter
            // 
            this.order_itemTableAdapter.ClearBeforeFill = true;
            // 
            // order_itemBindingSource
            // 
            this.order_itemBindingSource.DataMember = "FK_order_item_order1";
            this.order_itemBindingSource.DataSource = this.orderBindingSource;
            // 
            // GBoxOrderInfo
            // 
            this.GBoxOrderInfo.Controls.Add(this.totalTextBox);
            this.GBoxOrderInfo.Controls.Add(this.label4);
            this.GBoxOrderInfo.Controls.Add(this.guna2DateTimePicker1);
            this.GBoxOrderInfo.Controls.Add(this.label3);
            this.GBoxOrderInfo.Controls.Add(this.guna2ComboBox2);
            this.GBoxOrderInfo.Controls.Add(this.label2);
            this.GBoxOrderInfo.Controls.Add(this.guna2ComboBox1);
            this.GBoxOrderInfo.Controls.Add(this.label1);
            this.GBoxOrderInfo.Controls.Add(this.idTextBox);
            this.GBoxOrderInfo.Controls.Add(this.LblRBAsc);
            this.GBoxOrderInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GBoxOrderInfo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBoxOrderInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.GBoxOrderInfo.Location = new System.Drawing.Point(12, 48);
            this.GBoxOrderInfo.Name = "GBoxOrderInfo";
            this.GBoxOrderInfo.ShadowDecoration.Parent = this.GBoxOrderInfo;
            this.GBoxOrderInfo.Size = new System.Drawing.Size(350, 281);
            this.GBoxOrderInfo.TabIndex = 79;
            this.GBoxOrderInfo.Text = "Информация о заказе";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(128, 59);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(201, 36);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // LblRBAsc
            // 
            this.LblRBAsc.BackColor = System.Drawing.Color.White;
            this.LblRBAsc.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRBAsc.ForeColor = System.Drawing.Color.DimGray;
            this.LblRBAsc.Location = new System.Drawing.Point(9, 59);
            this.LblRBAsc.Margin = new System.Windows.Forms.Padding(0);
            this.LblRBAsc.Name = "LblRBAsc";
            this.LblRBAsc.Size = new System.Drawing.Size(140, 36);
            this.LblRBAsc.TabIndex = 67;
            this.LblRBAsc.Text = "Код заказа:";
            this.LblRBAsc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblRBAsc.UseCompatibleTextRendering = true;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Animated = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "staff_id", true));
            this.guna2ComboBox1.DataSource = this.staffBindingSource;
            this.guna2ComboBox1.DisplayMember = "ФИО";
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(128, 101);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(201, 36);
            this.guna2ComboBox1.TabIndex = 68;
            this.guna2ComboBox1.ValueMember = "id";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.pizzaDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(9, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 36);
            this.label1.TabIndex = 69;
            this.label1.Text = "Сотрудник:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "client_id", true));
            this.guna2ComboBox2.DataSource = this.clientBindingSource;
            this.guna2ComboBox2.DisplayMember = "name";
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox2.FocusedState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.FormattingEnabled = true;
            this.guna2ComboBox2.HoverState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.ItemsAppearance.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Location = new System.Drawing.Point(128, 143);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.ShadowDecoration.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Size = new System.Drawing.Size(201, 36);
            this.guna2ComboBox2.TabIndex = 70;
            this.guna2ComboBox2.ValueMember = "id";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.pizzaDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 36);
            this.label2.TabIndex = 71;
            this.label2.Text = "Клиент:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.guna2DateTimePicker1.BorderThickness = 1;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "date", true));
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(128, 182);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(201, 36);
            this.guna2DateTimePicker1.TabIndex = 73;
            this.guna2DateTimePicker1.Value = new System.DateTime(2020, 4, 15, 19, 17, 44, 924);
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(128, 228);
            this.totalTextBox.Multiline = true;
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(201, 36);
            this.totalTextBox.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(9, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 36);
            this.label3.TabIndex = 75;
            this.label3.Text = "Дата:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(9, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 36);
            this.label4.TabIndex = 76;
            this.label4.Text = "Сумма:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.item_id,
            this.quantityDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.fKorderitemorder1BindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(12, 345);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(776, 240);
            this.guna2DataGridView1.TabIndex = 80;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // fKorderitemorder1BindingSource
            // 
            this.fKorderitemorder1BindingSource.DataMember = "FK_order_item_order1";
            this.fKorderitemorder1BindingSource.DataSource = this.orderBindingSource;
            // 
            // pizzaDataSetBindingSource
            // 
            this.pizzaDataSetBindingSource.DataSource = this.pizzaDataSet;
            this.pizzaDataSetBindingSource.Position = 0;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.pizzaDataSetBindingSource;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "item";
            this.itemBindingSource1.DataSource = this.pizzaDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // item_id
            // 
            this.item_id.DataPropertyName = "item_id";
            this.item_id.DataSource = this.itemBindingSource1;
            this.item_id.DisplayMember = "title";
            this.item_id.HeaderText = "Категория";
            this.item_id.Name = "item_id";
            this.item_id.ValueMember = "id";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Visible = false;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // BtnLast
            // 
            this.BtnLast.CheckedState.Parent = this.BtnLast;
            this.BtnLast.CustomImages.Parent = this.BtnLast;
            this.BtnLast.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLast.ForeColor = System.Drawing.Color.White;
            this.BtnLast.HoverState.Parent = this.BtnLast;
            this.BtnLast.Location = new System.Drawing.Point(472, 609);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.ShadowDecoration.Parent = this.BtnLast;
            this.BtnLast.Size = new System.Drawing.Size(115, 40);
            this.BtnLast.TabIndex = 84;
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
            this.BtnNext.Location = new System.Drawing.Point(314, 609);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.ShadowDecoration.Parent = this.BtnNext;
            this.BtnNext.Size = new System.Drawing.Size(115, 40);
            this.BtnNext.TabIndex = 83;
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
            this.BrnBack.Location = new System.Drawing.Point(167, 609);
            this.BrnBack.Name = "BrnBack";
            this.BrnBack.ShadowDecoration.Parent = this.BrnBack;
            this.BrnBack.Size = new System.Drawing.Size(115, 40);
            this.BrnBack.TabIndex = 82;
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
            this.BtnFirst.Location = new System.Drawing.Point(12, 609);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.ShadowDecoration.Parent = this.BtnFirst;
            this.BtnFirst.Size = new System.Drawing.Size(115, 40);
            this.BtnFirst.TabIndex = 81;
            this.BtnFirst.Text = "Первая";
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnDell
            // 
            this.BtnDell.CheckedState.Parent = this.BtnDell;
            this.BtnDell.CustomImages.Parent = this.BtnDell;
            this.BtnDell.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDell.ForeColor = System.Drawing.Color.White;
            this.BtnDell.HoverState.Parent = this.BtnDell;
            this.BtnDell.Location = new System.Drawing.Point(440, 191);
            this.BtnDell.Name = "BtnDell";
            this.BtnDell.ShadowDecoration.Parent = this.BtnDell;
            this.BtnDell.Size = new System.Drawing.Size(245, 36);
            this.BtnDell.TabIndex = 87;
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
            this.BtnSave.Location = new System.Drawing.Point(441, 149);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.ShadowDecoration.Parent = this.BtnSave;
            this.BtnSave.Size = new System.Drawing.Size(244, 36);
            this.BtnSave.TabIndex = 86;
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
            this.BtnAdd.Location = new System.Drawing.Point(441, 107);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.ShadowDecoration.Parent = this.BtnAdd;
            this.BtnAdd.Size = new System.Drawing.Size(244, 36);
            this.BtnAdd.TabIndex = 85;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 661);
            this.Controls.Add(this.BtnDell);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BrnBack);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.GBoxOrderInfo);
            this.Controls.Add(this.BtnRoll);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.Категории);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_itemBindingSource)).EndInit();
            this.GBoxOrderInfo.ResumeLayout(false);
            this.GBoxOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKorderitemorder1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Категории;
        private System.Windows.Forms.PictureBox BtnRoll;
        private System.Windows.Forms.PictureBox BtnExit;
        private PizzaDataSet pizzaDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private PizzaDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private PizzaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PizzaDataSetTableAdapters.order_itemTableAdapter order_itemTableAdapter;
        private System.Windows.Forms.BindingSource order_itemBindingSource;
        private Guna.UI2.WinForms.Guna2GroupBox GBoxOrderInfo;
        private System.Windows.Forms.TextBox idTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label LblRBAsc;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private PizzaDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private PizzaDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.BindingSource fKorderitemorder1BindingSource;
        private System.Windows.Forms.BindingSource pizzaDataSetBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private PizzaDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn item_id;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button BtnLast;
        private Guna.UI2.WinForms.Guna2Button BtnNext;
        private Guna.UI2.WinForms.Guna2Button BrnBack;
        private Guna.UI2.WinForms.Guna2Button BtnFirst;
        private Guna.UI2.WinForms.Guna2Button BtnDell;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
        private Guna.UI2.WinForms.Guna2Button BtnAdd;
    }
}