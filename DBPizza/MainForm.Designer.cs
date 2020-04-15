namespace DBPizza
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BtnRoll = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClient = new Guna.UI2.WinForms.Guna2Button();
            this.BtnItem = new Guna.UI2.WinForms.Guna2Button();
            this.BtnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPayDay = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPosition = new Guna.UI2.WinForms.Guna2Button();
            this.BtnStaff = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRoll
            // 
            this.BtnRoll.Image = ((System.Drawing.Image)(resources.GetObject("BtnRoll.Image")));
            this.BtnRoll.Location = new System.Drawing.Point(199, 12);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(34, 33);
            this.BtnRoll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRoll.TabIndex = 35;
            this.BtnRoll.TabStop = false;
            this.BtnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(239, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(34, 33);
            this.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnExit.TabIndex = 34;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(25, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 40);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "Главное меню";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // BtnCategory
            // 
            this.BtnCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCategory.CheckedState.Parent = this.BtnCategory;
            this.BtnCategory.CustomImages.Parent = this.BtnCategory;
            this.BtnCategory.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCategory.ForeColor = System.Drawing.Color.White;
            this.BtnCategory.HoverState.Parent = this.BtnCategory;
            this.BtnCategory.Location = new System.Drawing.Point(68, 95);
            this.BtnCategory.Name = "BtnCategory";
            this.BtnCategory.ShadowDecoration.Parent = this.BtnCategory;
            this.BtnCategory.Size = new System.Drawing.Size(143, 45);
            this.BtnCategory.TabIndex = 37;
            this.BtnCategory.Text = "Категории";
            // 
            // BtnClient
            // 
            this.BtnClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnClient.CheckedState.Parent = this.BtnClient;
            this.BtnClient.CustomImages.Parent = this.BtnClient;
            this.BtnClient.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClient.ForeColor = System.Drawing.Color.White;
            this.BtnClient.HoverState.Parent = this.BtnClient;
            this.BtnClient.Location = new System.Drawing.Point(68, 146);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.ShadowDecoration.Parent = this.BtnClient;
            this.BtnClient.Size = new System.Drawing.Size(143, 45);
            this.BtnClient.TabIndex = 38;
            this.BtnClient.Text = "Клиенты";
            // 
            // BtnItem
            // 
            this.BtnItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnItem.CheckedState.Parent = this.BtnItem;
            this.BtnItem.CustomImages.Parent = this.BtnItem;
            this.BtnItem.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnItem.ForeColor = System.Drawing.Color.White;
            this.BtnItem.HoverState.Parent = this.BtnItem;
            this.BtnItem.Location = new System.Drawing.Point(68, 197);
            this.BtnItem.Name = "BtnItem";
            this.BtnItem.ShadowDecoration.Parent = this.BtnItem;
            this.BtnItem.Size = new System.Drawing.Size(143, 45);
            this.BtnItem.TabIndex = 39;
            this.BtnItem.Text = "Товары";
            // 
            // BtnOrder
            // 
            this.BtnOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnOrder.CheckedState.Parent = this.BtnOrder;
            this.BtnOrder.CustomImages.Parent = this.BtnOrder;
            this.BtnOrder.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOrder.ForeColor = System.Drawing.Color.White;
            this.BtnOrder.HoverState.Parent = this.BtnOrder;
            this.BtnOrder.Location = new System.Drawing.Point(68, 248);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.ShadowDecoration.Parent = this.BtnOrder;
            this.BtnOrder.Size = new System.Drawing.Size(143, 45);
            this.BtnOrder.TabIndex = 40;
            this.BtnOrder.Text = "Заказы";
            // 
            // BtnPayDay
            // 
            this.BtnPayDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPayDay.CheckedState.Parent = this.BtnPayDay;
            this.BtnPayDay.CustomImages.Parent = this.BtnPayDay;
            this.BtnPayDay.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPayDay.ForeColor = System.Drawing.Color.White;
            this.BtnPayDay.HoverState.Parent = this.BtnPayDay;
            this.BtnPayDay.Location = new System.Drawing.Point(68, 299);
            this.BtnPayDay.Name = "BtnPayDay";
            this.BtnPayDay.ShadowDecoration.Parent = this.BtnPayDay;
            this.BtnPayDay.Size = new System.Drawing.Size(143, 45);
            this.BtnPayDay.TabIndex = 41;
            this.BtnPayDay.Text = "Зарплаты";
            // 
            // BtnPosition
            // 
            this.BtnPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPosition.CheckedState.Parent = this.BtnPosition;
            this.BtnPosition.CustomImages.Parent = this.BtnPosition;
            this.BtnPosition.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPosition.ForeColor = System.Drawing.Color.White;
            this.BtnPosition.HoverState.Parent = this.BtnPosition;
            this.BtnPosition.Location = new System.Drawing.Point(68, 350);
            this.BtnPosition.Name = "BtnPosition";
            this.BtnPosition.ShadowDecoration.Parent = this.BtnPosition;
            this.BtnPosition.Size = new System.Drawing.Size(143, 45);
            this.BtnPosition.TabIndex = 42;
            this.BtnPosition.Text = "Должности";
            this.BtnPosition.Click += new System.EventHandler(this.BtnPosition_Click);
            // 
            // BtnStaff
            // 
            this.BtnStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnStaff.CheckedState.Parent = this.BtnStaff;
            this.BtnStaff.CustomImages.Parent = this.BtnStaff;
            this.BtnStaff.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnStaff.ForeColor = System.Drawing.Color.White;
            this.BtnStaff.HoverState.Parent = this.BtnStaff;
            this.BtnStaff.Location = new System.Drawing.Point(68, 401);
            this.BtnStaff.Name = "BtnStaff";
            this.BtnStaff.ShadowDecoration.Parent = this.BtnStaff;
            this.BtnStaff.Size = new System.Drawing.Size(143, 45);
            this.BtnStaff.TabIndex = 43;
            this.BtnStaff.Text = "Сотрудники";
            this.BtnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(285, 458);
            this.Controls.Add(this.BtnStaff);
            this.Controls.Add(this.BtnPosition);
            this.Controls.Add(this.BtnPayDay);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.BtnItem);
            this.Controls.Add(this.BtnClient);
            this.Controls.Add(this.BtnCategory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnRoll);
            this.Controls.Add(this.BtnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.BtnRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnRoll;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button BtnCategory;
        private Guna.UI2.WinForms.Guna2Button BtnClient;
        private Guna.UI2.WinForms.Guna2Button BtnItem;
        private Guna.UI2.WinForms.Guna2Button BtnOrder;
        private Guna.UI2.WinForms.Guna2Button BtnPayDay;
        private Guna.UI2.WinForms.Guna2Button BtnPosition;
        private Guna.UI2.WinForms.Guna2Button BtnStaff;
    }
}