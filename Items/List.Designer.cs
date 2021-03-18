namespace RestaurantSystem.Items
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.betterTextBox_search = new CustomControls.BetterTextBox();
            this.materialButton_add = new CustomControls.MaterialButton();
            this.materialButton_close = new CustomControls.MaterialButton();
            this.panel_menuitem = new System.Windows.Forms.Panel();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.betterTextBox_search);
            this.panel1.Controls.Add(this.materialButton_add);
            this.panel1.Controls.Add(this.materialButton_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 1);
            this.panel2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "List of Menu Items ";
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
            this.betterTextBox_search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_search.intVal = 0;
            this.betterTextBox_search.Location = new System.Drawing.Point(755, 8);
            this.betterTextBox_search.Name = "betterTextBox_search";
            this.betterTextBox_search.prepend = "";
            this.betterTextBox_search.Rules = null;
            this.betterTextBox_search.Size = new System.Drawing.Size(215, 25);
            this.betterTextBox_search.TabIndex = 3;
            this.betterTextBox_search.textboxType = CustomControls.TextboxType.Text;
            this.betterTextBox_search.TextChanged += new System.EventHandler(this.betterTextBox_search_TextChanged);
            // 
            // materialButton_add
            // 
            this.materialButton_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.materialButton_add.Location = new System.Drawing.Point(641, 8);
            this.materialButton_add.Name = "materialButton_add";
            this.materialButton_add.role = 0;
            this.materialButton_add.Size = new System.Drawing.Size(108, 30);
            this.materialButton_add.TabIndex = 1;
            this.materialButton_add.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_add.tempforefont = null;
            this.materialButton_add.Text = "Add New";
            this.materialButton_add.Totext = null;
            this.materialButton_add.userole = false;
            this.materialButton_add.UseVisualStyleBackColor = false;
            this.materialButton_add.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton_close
            // 
            this.materialButton_close.BackgroundImage = global::RestaurantSystem.Properties.Resources.back_64x64;
            this.materialButton_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialButton_close.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_close.FlatAppearance.BorderSize = 0;
            this.materialButton_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_close.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_close.fontIncrement = 0F;
            this.materialButton_close.FontStyle = null;
            this.materialButton_close.ForeColor = System.Drawing.Color.White;
            this.materialButton_close.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_close.hoverforefont = null;
            this.materialButton_close.hoverimage = null;
            this.materialButton_close.Location = new System.Drawing.Point(3, 4);
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
            // panel_menuitem
            // 
            this.panel_menuitem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_menuitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menuitem.Location = new System.Drawing.Point(2, 67);
            this.panel_menuitem.Name = "panel_menuitem";
            this.panel_menuitem.Size = new System.Drawing.Size(980, 460);
            this.panel_menuitem.TabIndex = 1;
            this.panel_menuitem.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menuitem_Paint);
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.lbl_qty.Location = new System.Drawing.Point(324, 44);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(33, 19);
            this.lbl_qty.TabIndex = 13;
            this.lbl_qty.Text = "Qty";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.lbl_category.Location = new System.Drawing.Point(408, 44);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(36, 19);
            this.lbl_category.TabIndex = 12;
            this.lbl_category.Text = "Unit";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.lbl_price.Location = new System.Drawing.Point(244, 44);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(43, 19);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "Price";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.lbl_name.Location = new System.Drawing.Point(9, 44);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 19);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(324, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Qty";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(408, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Unit";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(244, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(4, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label6.Location = new System.Drawing.Point(493, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Categories";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label7.Location = new System.Drawing.Point(493, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Categories";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 560);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel_menuitem);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "List";
            this.Text = "List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.MaterialButton materialButton_add;
        private System.Windows.Forms.Panel panel_menuitem;
        private CustomControls.MaterialButton materialButton_close;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomControls.BetterTextBox betterTextBox_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}