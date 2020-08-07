namespace RestaurantSystem.Items
{
    partial class ItemDetails
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
            this.materialButton_close = new CustomControls.MaterialButton();
            this.label1_Add = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_categories = new System.Windows.Forms.Label();
            this.label_itemname = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label1_category = new System.Windows.Forms.Label();
            this.label1_price = new System.Windows.Forms.Label();
            this.label1_name = new System.Windows.Forms.Label();
            this.betterListView1 = new CustomControls.BetterListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Estimatedby = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.materialButton_close);
            this.panel1.Controls.Add(this.label1_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 38);
            this.panel1.TabIndex = 2;
            // 
            // materialButton_close
            // 
            this.materialButton_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.materialButton_close.Location = new System.Drawing.Point(597, 5);
            this.materialButton_close.Name = "materialButton_close";
            this.materialButton_close.role = 0;
            this.materialButton_close.Size = new System.Drawing.Size(30, 30);
            this.materialButton_close.TabIndex = 53;
            this.materialButton_close.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_close.tempforefont = null;
            this.materialButton_close.Text = "X";
            this.materialButton_close.Totext = null;
            this.materialButton_close.userole = false;
            this.materialButton_close.UseVisualStyleBackColor = true;
            this.materialButton_close.Click += new System.EventHandler(this.materialButton_close_Click);
            // 
            // label1_Add
            // 
            this.label1_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1_Add.AutoSize = true;
            this.label1_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Add.ForeColor = System.Drawing.Color.White;
            this.label1_Add.Location = new System.Drawing.Point(288, 11);
            this.label1_Add.Name = "label1_Add";
            this.label1_Add.Size = new System.Drawing.Size(51, 17);
            this.label1_Add.TabIndex = 52;
            this.label1_Add.Text = "Details";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(630, 96);
            this.panel6.TabIndex = 89;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_Estimatedby);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label_categories);
            this.panel2.Controls.Add(this.label_itemname);
            this.panel2.Controls.Add(this.label_price);
            this.panel2.Controls.Add(this.label1_category);
            this.panel2.Controls.Add(this.label1_price);
            this.panel2.Controls.Add(this.label1_name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 95);
            this.panel2.TabIndex = 93;
            // 
            // label_categories
            // 
            this.label_categories.AutoSize = true;
            this.label_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_categories.Location = new System.Drawing.Point(97, 44);
            this.label_categories.Name = "label_categories";
            this.label_categories.Size = new System.Drawing.Size(80, 17);
            this.label_categories.TabIndex = 95;
            this.label_categories.Text = "priceprice";
            // 
            // label_itemname
            // 
            this.label_itemname.AutoSize = true;
            this.label_itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_itemname.Location = new System.Drawing.Point(97, 12);
            this.label_itemname.Name = "label_itemname";
            this.label_itemname.Size = new System.Drawing.Size(80, 17);
            this.label_itemname.TabIndex = 94;
            this.label_itemname.Text = "priceprice";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(453, 10);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(80, 17);
            this.label_price.TabIndex = 93;
            this.label_price.Text = "priceprice";
            // 
            // label1_category
            // 
            this.label1_category.AutoSize = true;
            this.label1_category.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_category.Location = new System.Drawing.Point(26, 44);
            this.label1_category.Name = "label1_category";
            this.label1_category.Size = new System.Drawing.Size(64, 17);
            this.label1_category.TabIndex = 91;
            this.label1_category.Text = "Category";
            // 
            // label1_price
            // 
            this.label1_price.AutoSize = true;
            this.label1_price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_price.Location = new System.Drawing.Point(409, 11);
            this.label1_price.Name = "label1_price";
            this.label1_price.Size = new System.Drawing.Size(38, 17);
            this.label1_price.TabIndex = 90;
            this.label1_price.Text = "Price";
            // 
            // label1_name
            // 
            this.label1_name.AutoSize = true;
            this.label1_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_name.Location = new System.Drawing.Point(46, 10);
            this.label1_name.Name = "label1_name";
            this.label1_name.Size = new System.Drawing.Size(44, 17);
            this.label1_name.TabIndex = 89;
            this.label1_name.Text = "Name";
            // 
            // betterListView1
            // 
            this.betterListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.betterListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterListView1.FullRowSelect = true;
            this.betterListView1.GridLines = true;
            this.betterListView1.HideSelection = false;
            this.betterListView1.Location = new System.Drawing.Point(0, 140);
            this.betterListView1.Name = "betterListView1";
            this.betterListView1.Size = new System.Drawing.Size(630, 271);
            this.betterListView1.sortable = false;
            this.betterListView1.TabIndex = 90;
            this.betterListView1.UseCompatibleStateImageBehavior = false;
            this.betterListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "S.N.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 268;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 235;
            // 
            // label_Estimatedby
            // 
            this.label_Estimatedby.AutoSize = true;
            this.label_Estimatedby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Estimatedby.Location = new System.Drawing.Point(97, 71);
            this.label_Estimatedby.Name = "label_Estimatedby";
            this.label_Estimatedby.Size = new System.Drawing.Size(80, 17);
            this.label_Estimatedby.TabIndex = 99;
            this.label_Estimatedby.Text = "priceprice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 98;
            this.label4.Text = "Estimated By";
            // 
            // ItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 411);
            this.Controls.Add(this.betterListView1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1_Add;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_categories;
        private System.Windows.Forms.Label label_itemname;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label1_category;
        private System.Windows.Forms.Label label1_price;
        private System.Windows.Forms.Label label1_name;
        private CustomControls.BetterListView betterListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private CustomControls.MaterialButton materialButton_close;
        private System.Windows.Forms.Label label_Estimatedby;
        private System.Windows.Forms.Label label4;
    }
}