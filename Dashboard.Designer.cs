namespace RestaurantSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new CustomControls.GradientPanel();
            this.materialButton_reportlist = new CustomControls.MaterialButton();
            this.materialButton_customers = new CustomControls.MaterialButton();
            this.materialButton_partiesmanage = new CustomControls.MaterialButton();
            this.materialButton_purchase = new CustomControls.MaterialButton();
            this.materialButton_categories = new CustomControls.MaterialButton();
            this.materialButton_items = new CustomControls.MaterialButton();
            this.materialButton_daymanage = new CustomControls.MaterialButton();
            this.materialButton_managecounter = new CustomControls.MaterialButton();
            this.panel_border_top = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_menu = new CustomControls.GradientPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel_link = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_dashboardusermenu = new System.Windows.Forms.PictureBox();
            this.label_username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dashboardusermenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 628);
            this.panel1.TabIndex = 0;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(230)))));
            this.gradientPanel1.CausesValidation = false;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(230)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.materialButton_reportlist);
            this.gradientPanel1.Controls.Add(this.materialButton_customers);
            this.gradientPanel1.Controls.Add(this.materialButton_partiesmanage);
            this.gradientPanel1.Controls.Add(this.materialButton_purchase);
            this.gradientPanel1.Controls.Add(this.materialButton_categories);
            this.gradientPanel1.Controls.Add(this.materialButton_items);
            this.gradientPanel1.Controls.Add(this.materialButton_daymanage);
            this.gradientPanel1.Controls.Add(this.materialButton_managecounter);
            this.gradientPanel1.Controls.Add(this.panel_border_top);
            this.gradientPanel1.Controls.Add(this.panel4);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(245, 626);
            this.gradientPanel1.TabIndex = 18;
            // 
            // materialButton_reportlist
            // 
            this.materialButton_reportlist.BackColor = System.Drawing.Color.Transparent;
            this.materialButton_reportlist.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_reportlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_reportlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialButton_reportlist.FlatAppearance.BorderSize = 0;
            this.materialButton_reportlist.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.materialButton_reportlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_reportlist.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_reportlist.fontIncrement = 1.5F;
            this.materialButton_reportlist.FontStyle = null;
            this.materialButton_reportlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_reportlist.hoverforecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(126)))), ((int)(((byte)(196)))));
            this.materialButton_reportlist.hoverforefont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_reportlist.hoverimage = null;
            this.materialButton_reportlist.Image = global::RestaurantSystem.Properties.Resources.reports_20x20;
            this.materialButton_reportlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_reportlist.Location = new System.Drawing.Point(0, 314);
            this.materialButton_reportlist.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.materialButton_reportlist.Name = "materialButton_reportlist";
            this.materialButton_reportlist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.materialButton_reportlist.role = 0;
            this.materialButton_reportlist.Size = new System.Drawing.Size(245, 28);
            this.materialButton_reportlist.TabIndex = 18;
            this.materialButton_reportlist.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_reportlist.tempforefont = null;
            this.materialButton_reportlist.Text = "Reports";
            this.materialButton_reportlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_reportlist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton_reportlist.Totext = null;
            this.materialButton_reportlist.userole = false;
            this.materialButton_reportlist.UseVisualStyleBackColor = false;
            this.materialButton_reportlist.Click += new System.EventHandler(this.materialButton_reportlist_Click);
            // 
            // materialButton_customers
            // 
            this.materialButton_customers.BackColor = System.Drawing.Color.Transparent;
            this.materialButton_customers.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialButton_customers.FlatAppearance.BorderSize = 0;
            this.materialButton_customers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.materialButton_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_customers.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_customers.fontIncrement = 1.5F;
            this.materialButton_customers.FontStyle = null;
            this.materialButton_customers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_customers.hoverforecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(126)))), ((int)(((byte)(196)))));
            this.materialButton_customers.hoverforefont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_customers.hoverimage = null;
            this.materialButton_customers.Image = global::RestaurantSystem.Properties.Resources.customers_20x20;
            this.materialButton_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_customers.Location = new System.Drawing.Point(0, 286);
            this.materialButton_customers.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.materialButton_customers.Name = "materialButton_customers";
            this.materialButton_customers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.materialButton_customers.role = 0;
            this.materialButton_customers.Size = new System.Drawing.Size(245, 28);
            this.materialButton_customers.TabIndex = 16;
            this.materialButton_customers.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_customers.tempforefont = null;
            this.materialButton_customers.Text = " Customers";
            this.materialButton_customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton_customers.Totext = null;
            this.materialButton_customers.userole = false;
            this.materialButton_customers.UseVisualStyleBackColor = false;
            this.materialButton_customers.Click += new System.EventHandler(this.materialButton_customers_Click);
            // 
            // materialButton_partiesmanage
            // 
            this.materialButton_partiesmanage.BackColor = System.Drawing.Color.Transparent;
            this.materialButton_partiesmanage.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_partiesmanage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_partiesmanage.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialButton_partiesmanage.FlatAppearance.BorderSize = 0;
            this.materialButton_partiesmanage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.materialButton_partiesmanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_partiesmanage.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_partiesmanage.fontIncrement = 1.5F;
            this.materialButton_partiesmanage.FontStyle = null;
            this.materialButton_partiesmanage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_partiesmanage.hoverforecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_partiesmanage.hoverforefont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_partiesmanage.hoverimage = global::RestaurantSystem.Properties.Resources.parties_20x20;
            this.materialButton_partiesmanage.Image = global::RestaurantSystem.Properties.Resources.parties_20x20;
            this.materialButton_partiesmanage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_partiesmanage.Location = new System.Drawing.Point(0, 258);
            this.materialButton_partiesmanage.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.materialButton_partiesmanage.Name = "materialButton_partiesmanage";
            this.materialButton_partiesmanage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.materialButton_partiesmanage.role = 0;
            this.materialButton_partiesmanage.Size = new System.Drawing.Size(245, 28);
            this.materialButton_partiesmanage.TabIndex = 12;
            this.materialButton_partiesmanage.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_partiesmanage.tempforefont = null;
            this.materialButton_partiesmanage.Text = " Parties";
            this.materialButton_partiesmanage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_partiesmanage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton_partiesmanage.Totext = null;
            this.materialButton_partiesmanage.userole = false;
            this.materialButton_partiesmanage.UseVisualStyleBackColor = false;
            this.materialButton_partiesmanage.Click += new System.EventHandler(this.materialButton_partiesmanage_Click);
            // 
            // materialButton_purchase
            // 
            this.materialButton_purchase.BackColor = System.Drawing.Color.Transparent;
            this.materialButton_purchase.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_purchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_purchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialButton_purchase.FlatAppearance.BorderSize = 0;
            this.materialButton_purchase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.materialButton_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_purchase.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_purchase.fontIncrement = 1.5F;
            this.materialButton_purchase.FontStyle = null;
            this.materialButton_purchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_purchase.hoverforecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(126)))), ((int)(((byte)(196)))));
            this.materialButton_purchase.hoverforefont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_purchase.hoverimage = null;
            this.materialButton_purchase.Image = global::RestaurantSystem.Properties.Resources.store_20x20;
            this.materialButton_purchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_purchase.Location = new System.Drawing.Point(0, 230);
            this.materialButton_purchase.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.materialButton_purchase.Name = "materialButton_purchase";
            this.materialButton_purchase.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.materialButton_purchase.role = 0;
            this.materialButton_purchase.Size = new System.Drawing.Size(245, 28);
            this.materialButton_purchase.TabIndex = 13;
            this.materialButton_purchase.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_purchase.tempforefont = null;
            this.materialButton_purchase.Text = " Store";
            this.materialButton_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_purchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton_purchase.Totext = null;
            this.materialButton_purchase.userole = false;
            this.materialButton_purchase.UseVisualStyleBackColor = false;
            this.materialButton_purchase.Click += new System.EventHandler(this.materialButton_purchase_Click);
            // 
            // materialButton_categories
            // 
            this.materialButton_categories.BackColor = System.Drawing.Color.Transparent;
            this.materialButton_categories.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_categories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_categories.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialButton_categories.FlatAppearance.BorderSize = 0;
            this.materialButton_categories.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.materialButton_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_categories.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_categories.fontIncrement = 1.5F;
            this.materialButton_categories.FontStyle = null;
            this.materialButton_categories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_categories.hoverforecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(126)))), ((int)(((byte)(196)))));
            this.materialButton_categories.hoverforefont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_categories.hoverimage = null;
            this.materialButton_categories.Image = global::RestaurantSystem.Properties.Resources.categories_20x20;
            this.materialButton_categories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_categories.Location = new System.Drawing.Point(0, 202);
            this.materialButton_categories.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.materialButton_categories.Name = "materialButton_categories";
            this.materialButton_categories.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.materialButton_categories.role = 0;
            this.materialButton_categories.Size = new System.Drawing.Size(245, 28);
            this.materialButton_categories.TabIndex = 14;
            this.materialButton_categories.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_categories.tempforefont = null;
            this.materialButton_categories.Text = " Categories";
            this.materialButton_categories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_categories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton_categories.Totext = null;
            this.materialButton_categories.userole = false;
            this.materialButton_categories.UseVisualStyleBackColor = false;
            this.materialButton_categories.Click += new System.EventHandler(this.materialButton_categories_Click);
            // 
            // materialButton_items
            // 
            this.materialButton_items.BackColor = System.Drawing.Color.Transparent;
            this.materialButton_items.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_items.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_items.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialButton_items.FlatAppearance.BorderSize = 0;
            this.materialButton_items.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.materialButton_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_items.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_items.fontIncrement = 1.5F;
            this.materialButton_items.FontStyle = null;
            this.materialButton_items.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_items.hoverforecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(126)))), ((int)(((byte)(196)))));
            this.materialButton_items.hoverforefont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_items.hoverimage = null;
            this.materialButton_items.Image = global::RestaurantSystem.Properties.Resources.menuitems_20x20;
            this.materialButton_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_items.Location = new System.Drawing.Point(0, 174);
            this.materialButton_items.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.materialButton_items.Name = "materialButton_items";
            this.materialButton_items.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.materialButton_items.role = 0;
            this.materialButton_items.Size = new System.Drawing.Size(245, 28);
            this.materialButton_items.TabIndex = 15;
            this.materialButton_items.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_items.tempforefont = null;
            this.materialButton_items.Text = " MenuItems";
            this.materialButton_items.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_items.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton_items.Totext = null;
            this.materialButton_items.userole = false;
            this.materialButton_items.UseVisualStyleBackColor = false;
            this.materialButton_items.Click += new System.EventHandler(this.materialButton_items_Click);
            // 
            // materialButton_daymanage
            // 
            this.materialButton_daymanage.BackColor = System.Drawing.Color.Transparent;
            this.materialButton_daymanage.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_daymanage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_daymanage.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialButton_daymanage.FlatAppearance.BorderSize = 0;
            this.materialButton_daymanage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.materialButton_daymanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_daymanage.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_daymanage.fontIncrement = 1.5F;
            this.materialButton_daymanage.FontStyle = null;
            this.materialButton_daymanage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_daymanage.hoverforecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(126)))), ((int)(((byte)(196)))));
            this.materialButton_daymanage.hoverforefont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_daymanage.hoverimage = null;
            this.materialButton_daymanage.Image = global::RestaurantSystem.Properties.Resources.daymgnt_20x20;
            this.materialButton_daymanage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_daymanage.Location = new System.Drawing.Point(0, 146);
            this.materialButton_daymanage.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.materialButton_daymanage.Name = "materialButton_daymanage";
            this.materialButton_daymanage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.materialButton_daymanage.role = 0;
            this.materialButton_daymanage.Size = new System.Drawing.Size(245, 28);
            this.materialButton_daymanage.TabIndex = 10;
            this.materialButton_daymanage.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_daymanage.tempforefont = null;
            this.materialButton_daymanage.Text = " Day Management";
            this.materialButton_daymanage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_daymanage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton_daymanage.Totext = null;
            this.materialButton_daymanage.userole = false;
            this.materialButton_daymanage.UseVisualStyleBackColor = false;
            this.materialButton_daymanage.Click += new System.EventHandler(this.materialButton_daymanage_Click);
            // 
            // materialButton_managecounter
            // 
            this.materialButton_managecounter.BackColor = System.Drawing.Color.Transparent;
            this.materialButton_managecounter.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_managecounter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_managecounter.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialButton_managecounter.FlatAppearance.BorderSize = 0;
            this.materialButton_managecounter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.materialButton_managecounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_managecounter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_managecounter.fontIncrement = 1.5F;
            this.materialButton_managecounter.FontStyle = null;
            this.materialButton_managecounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_managecounter.hoverforecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(126)))), ((int)(((byte)(196)))));
            this.materialButton_managecounter.hoverforefont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_managecounter.hoverimage = null;
            this.materialButton_managecounter.Image = global::RestaurantSystem.Properties.Resources.counters_20x20;
            this.materialButton_managecounter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_managecounter.Location = new System.Drawing.Point(0, 118);
            this.materialButton_managecounter.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.materialButton_managecounter.Name = "materialButton_managecounter";
            this.materialButton_managecounter.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.materialButton_managecounter.role = 0;
            this.materialButton_managecounter.Size = new System.Drawing.Size(245, 28);
            this.materialButton_managecounter.TabIndex = 11;
            this.materialButton_managecounter.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_managecounter.tempforefont = null;
            this.materialButton_managecounter.Text = " Counters";
            this.materialButton_managecounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_managecounter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton_managecounter.Totext = null;
            this.materialButton_managecounter.userole = false;
            this.materialButton_managecounter.UseVisualStyleBackColor = false;
            this.materialButton_managecounter.Click += new System.EventHandler(this.materialButton_managecounter_Click);
            // 
            // panel_border_top
            // 
            this.panel_border_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel_border_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_border_top.Location = new System.Drawing.Point(0, 116);
            this.panel_border_top.Name = "panel_border_top";
            this.panel_border_top.Size = new System.Drawing.Size(245, 2);
            this.panel_border_top.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::RestaurantSystem.Properties.Resources.Dashbord;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 116);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_menu);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(952, 628);
            this.panel3.TabIndex = 13;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_menu.ColorBottom = System.Drawing.Color.White;
            this.panel_menu.ColorTop = System.Drawing.Color.White;
            this.panel_menu.Controls.Add(this.panel5);
            this.panel_menu.Controls.Add(this.linkLabel_link);
            this.panel_menu.Controls.Add(this.label6);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_menu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_menu.Location = new System.Drawing.Point(246, 50);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(706, 578);
            this.panel_menu.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.ForeColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(348, 555);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 15);
            this.panel5.TabIndex = 10;
            // 
            // linkLabel_link
            // 
            this.linkLabel_link.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabel_link.AutoSize = true;
            this.linkLabel_link.BackColor = System.Drawing.Color.White;
            this.linkLabel_link.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_link.ForeColor = System.Drawing.Color.Blue;
            this.linkLabel_link.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel_link.Location = new System.Drawing.Point(366, 554);
            this.linkLabel_link.Name = "linkLabel_link";
            this.linkLabel_link.Size = new System.Drawing.Size(112, 15);
            this.linkLabel_link.TabIndex = 9;
            this.linkLabel_link.TabStop = true;
            this.linkLabel_link.Text = "By NeedTechnoSoft";
            this.linkLabel_link.VisitedLinkColor = System.Drawing.Color.Navy;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(270, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Crafted With";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel2.Controls.Add(this.pictureBox_dashboardusermenu);
            this.panel2.Controls.Add(this.label_username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(246, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 50);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox_dashboardusermenu
            // 
            this.pictureBox_dashboardusermenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_dashboardusermenu.Image = global::RestaurantSystem.Properties.Resources.user_dashboard_icon;
            this.pictureBox_dashboardusermenu.Location = new System.Drawing.Point(667, 10);
            this.pictureBox_dashboardusermenu.Name = "pictureBox_dashboardusermenu";
            this.pictureBox_dashboardusermenu.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_dashboardusermenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_dashboardusermenu.TabIndex = 1;
            this.pictureBox_dashboardusermenu.TabStop = false;
            this.pictureBox_dashboardusermenu.Click += new System.EventHandler(this.pictureBox_dashboardusermenu_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(605, 17);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(50, 19);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "label1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 628);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dashboardusermenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.MaterialButton materialButton_customers;
        private CustomControls.MaterialButton materialButton_items;
        private CustomControls.MaterialButton materialButton_categories;
        private CustomControls.MaterialButton materialButton_purchase;
        private CustomControls.MaterialButton materialButton_partiesmanage;
        private CustomControls.MaterialButton materialButton_managecounter;
        private CustomControls.MaterialButton materialButton_daymanage;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel linkLabel_link;
        private System.Windows.Forms.Label label6;
        private CustomControls.MaterialButton materialButton_reportlist;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_border_top;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_dashboardusermenu;
        private System.Windows.Forms.Label label_username;
        public CustomControls.GradientPanel panel_menu;
    }
}