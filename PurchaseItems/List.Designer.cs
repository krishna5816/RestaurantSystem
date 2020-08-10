namespace RestaurantSystem.PurchaseItems
{
    partial class List
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
            this.panel_menuitem = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.betterTextBox_search = new CustomControls.BetterTextBox();
            this.materialButton_close = new CustomControls.MaterialButton();
            this.materialButton_add = new CustomControls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_unit = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.materialButton_cate = new CustomControls.MaterialButton();
            this.materialButton_issuestock = new CustomControls.MaterialButton();
            this.materialButton_refresh = new CustomControls.MaterialButton();
            this.materialButton_addstock = new CustomControls.MaterialButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menuitem
            // 
            this.panel_menuitem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_menuitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menuitem.Location = new System.Drawing.Point(2, 109);
            this.panel_menuitem.Name = "panel_menuitem";
            this.panel_menuitem.Size = new System.Drawing.Size(1061, 488);
            this.panel_menuitem.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.betterTextBox_search);
            this.panel1.Controls.Add(this.materialButton_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 40);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 1);
            this.panel2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = " Kitchen Items ";
            // 
            // betterTextBox_search
            // 
            this.betterTextBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.betterTextBox_search.append = "";
            this.betterTextBox_search.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_search.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_search.intVal = 0;
            this.betterTextBox_search.Location = new System.Drawing.Point(842, 11);
            this.betterTextBox_search.Name = "betterTextBox_search";
            this.betterTextBox_search.prepend = "";
            this.betterTextBox_search.Rules = null;
            this.betterTextBox_search.Size = new System.Drawing.Size(215, 24);
            this.betterTextBox_search.TabIndex = 3;
            this.betterTextBox_search.textboxType = CustomControls.TextboxType.Text;
            this.betterTextBox_search.TextChanged += new System.EventHandler(this.betterTextBox_search_TextChanged);
            // 
            // materialButton_close
            // 
            this.materialButton_close.BackgroundImage = global::RestaurantSystem.Properties.Resources.back_64x64;
            this.materialButton_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialButton_close.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_close.FlatAppearance.BorderSize = 0;
            this.materialButton_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_close.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_close.fontIncrement = 0F;
            this.materialButton_close.FontStyle = null;
            this.materialButton_close.ForeColor = System.Drawing.Color.White;
            this.materialButton_close.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_close.hoverforefont = null;
            this.materialButton_close.hoverimage = null;
            this.materialButton_close.Location = new System.Drawing.Point(6, 6);
            this.materialButton_close.Name = "materialButton_close";
            this.materialButton_close.role = 0;
            this.materialButton_close.Size = new System.Drawing.Size(30, 30);
            this.materialButton_close.TabIndex = 2;
            this.materialButton_close.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_close.tempforefont = null;
            this.materialButton_close.Totext = null;
            this.materialButton_close.userole = false;
            this.materialButton_close.UseVisualStyleBackColor = true;
            this.materialButton_close.Click += new System.EventHandler(this.materialButton_close_Click);
            // 
            // materialButton_add
            // 
            this.materialButton_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_add.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_add.FlatAppearance.BorderSize = 0;
            this.materialButton_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_add.fontIncrement = 0F;
            this.materialButton_add.FontStyle = null;
            this.materialButton_add.ForeColor = System.Drawing.Color.White;
            this.materialButton_add.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_add.hoverforefont = null;
            this.materialButton_add.hoverimage = null;
            this.materialButton_add.Location = new System.Drawing.Point(165, 56);
            this.materialButton_add.Name = "materialButton_add";
            this.materialButton_add.role = 0;
            this.materialButton_add.Size = new System.Drawing.Size(157, 30);
            this.materialButton_add.TabIndex = 1;
            this.materialButton_add.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_add.tempforefont = null;
            this.materialButton_add.Text = "Add New";
            this.materialButton_add.Totext = null;
            this.materialButton_add.userole = false;
            this.materialButton_add.UseVisualStyleBackColor = false;
            this.materialButton_add.Click += new System.EventHandler(this.materialButton_add_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(324, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Unit";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(408, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Categories";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label4.Location = new System.Drawing.Point(4, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Name";
            // 
            // lbl_unit
            // 
            this.lbl_unit.AutoSize = true;
            this.lbl_unit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.lbl_unit.Location = new System.Drawing.Point(324, 89);
            this.lbl_unit.Name = "lbl_unit";
            this.lbl_unit.Size = new System.Drawing.Size(36, 19);
            this.lbl_unit.TabIndex = 23;
            this.lbl_unit.Text = "Unit";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.lbl_category.Location = new System.Drawing.Point(408, 89);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(81, 19);
            this.lbl_category.TabIndex = 22;
            this.lbl_category.Text = "Categories";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.lbl_name.Location = new System.Drawing.Point(9, 89);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 19);
            this.lbl_name.TabIndex = 20;
            this.lbl_name.Text = "Name";
            // 
            // materialButton_cate
            // 
            this.materialButton_cate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_cate.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_cate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_cate.FlatAppearance.BorderSize = 0;
            this.materialButton_cate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_cate.fontIncrement = 0F;
            this.materialButton_cate.FontStyle = null;
            this.materialButton_cate.ForeColor = System.Drawing.Color.White;
            this.materialButton_cate.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_cate.hoverforefont = null;
            this.materialButton_cate.hoverimage = null;
            this.materialButton_cate.Location = new System.Drawing.Point(2, 56);
            this.materialButton_cate.Name = "materialButton_cate";
            this.materialButton_cate.role = 0;
            this.materialButton_cate.Size = new System.Drawing.Size(157, 30);
            this.materialButton_cate.TabIndex = 4;
            this.materialButton_cate.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_cate.tempforefont = null;
            this.materialButton_cate.Text = "Manage Category";
            this.materialButton_cate.Totext = null;
            this.materialButton_cate.userole = false;
            this.materialButton_cate.UseVisualStyleBackColor = false;
            this.materialButton_cate.Click += new System.EventHandler(this.materialButton_cate_Click);
            // 
            // materialButton_issuestock
            // 
            this.materialButton_issuestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_issuestock.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_issuestock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_issuestock.FlatAppearance.BorderSize = 0;
            this.materialButton_issuestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_issuestock.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_issuestock.fontIncrement = 0F;
            this.materialButton_issuestock.FontStyle = null;
            this.materialButton_issuestock.ForeColor = System.Drawing.Color.White;
            this.materialButton_issuestock.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_issuestock.hoverforefont = null;
            this.materialButton_issuestock.hoverimage = null;
            this.materialButton_issuestock.Location = new System.Drawing.Point(490, 57);
            this.materialButton_issuestock.Name = "materialButton_issuestock";
            this.materialButton_issuestock.role = 0;
            this.materialButton_issuestock.Size = new System.Drawing.Size(157, 30);
            this.materialButton_issuestock.TabIndex = 28;
            this.materialButton_issuestock.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_issuestock.tempforefont = null;
            this.materialButton_issuestock.Text = "Issue Stock ";
            this.materialButton_issuestock.Totext = null;
            this.materialButton_issuestock.userole = false;
            this.materialButton_issuestock.UseVisualStyleBackColor = false;
            this.materialButton_issuestock.Click += new System.EventHandler(this.materialButton_issuestock_Click);
            // 
            // materialButton_refresh
            // 
            this.materialButton_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_refresh.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_refresh.FlatAppearance.BorderSize = 0;
            this.materialButton_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_refresh.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_refresh.fontIncrement = 0F;
            this.materialButton_refresh.FontStyle = null;
            this.materialButton_refresh.ForeColor = System.Drawing.Color.White;
            this.materialButton_refresh.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_refresh.hoverforefont = null;
            this.materialButton_refresh.hoverimage = null;
            this.materialButton_refresh.Location = new System.Drawing.Point(653, 57);
            this.materialButton_refresh.Name = "materialButton_refresh";
            this.materialButton_refresh.role = 0;
            this.materialButton_refresh.Size = new System.Drawing.Size(157, 30);
            this.materialButton_refresh.TabIndex = 29;
            this.materialButton_refresh.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_refresh.tempforefont = null;
            this.materialButton_refresh.Text = "Refresh";
            this.materialButton_refresh.Totext = null;
            this.materialButton_refresh.userole = false;
            this.materialButton_refresh.UseVisualStyleBackColor = false;
            this.materialButton_refresh.Click += new System.EventHandler(this.materialButton_refresh_Click);
            // 
            // materialButton_addstock
            // 
            this.materialButton_addstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_addstock.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_addstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_addstock.FlatAppearance.BorderSize = 0;
            this.materialButton_addstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_addstock.fontIncrement = 0F;
            this.materialButton_addstock.FontStyle = null;
            this.materialButton_addstock.ForeColor = System.Drawing.Color.White;
            this.materialButton_addstock.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_addstock.hoverforefont = null;
            this.materialButton_addstock.hoverimage = null;
            this.materialButton_addstock.Location = new System.Drawing.Point(328, 57);
            this.materialButton_addstock.Name = "materialButton_addstock";
            this.materialButton_addstock.role = 0;
            this.materialButton_addstock.Size = new System.Drawing.Size(157, 30);
            this.materialButton_addstock.TabIndex = 30;
            this.materialButton_addstock.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_addstock.tempforefont = null;
            this.materialButton_addstock.Text = "Add Stock";
            this.materialButton_addstock.Totext = null;
            this.materialButton_addstock.userole = false;
            this.materialButton_addstock.UseVisualStyleBackColor = false;
            this.materialButton_addstock.Click += new System.EventHandler(this.materialButton_addstock_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 621);
            this.Controls.Add(this.materialButton_add);
            this.Controls.Add(this.materialButton_addstock);
            this.Controls.Add(this.materialButton_refresh);
            this.Controls.Add(this.materialButton_issuestock);
            this.Controls.Add(this.materialButton_cate);
            this.Controls.Add(this.panel_menuitem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_unit);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_name);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_menuitem;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.BetterTextBox betterTextBox_search;
        private CustomControls.MaterialButton materialButton_close;
        private CustomControls.MaterialButton materialButton_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_unit;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_name;
        private CustomControls.MaterialButton materialButton_cate;
        private System.Windows.Forms.Label label6;
        private CustomControls.MaterialButton materialButton_issuestock;
        private CustomControls.MaterialButton materialButton_refresh;
        private CustomControls.MaterialButton materialButton_addstock;
        private System.Windows.Forms.Panel panel2;
    }
}