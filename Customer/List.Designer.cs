namespace RestaurantSystem.Customer
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
            this.betterTextBox_search = new CustomControls.BetterTextBox();
            this.label1_Add = new System.Windows.Forms.Label();
            this.materialButton1 = new CustomControls.MaterialButton();
            this.materialButton_close = new CustomControls.MaterialButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.betterTextBox_search);
            this.panel1.Controls.Add(this.label1_Add);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.materialButton_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 1);
            this.panel2.TabIndex = 56;
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
            this.betterTextBox_search.intVal = 0;
            this.betterTextBox_search.Location = new System.Drawing.Point(722, 14);
            this.betterTextBox_search.Name = "betterTextBox_search";
            this.betterTextBox_search.prepend = "";
            this.betterTextBox_search.Rules = null;
            this.betterTextBox_search.Size = new System.Drawing.Size(217, 26);
            this.betterTextBox_search.TabIndex = 55;
            this.betterTextBox_search.textboxType = CustomControls.TextboxType.Text;
            this.betterTextBox_search.TextChanged += new System.EventHandler(this.betterTextBox_search_TextChanged);
            // 
            // label1_Add
            // 
            this.label1_Add.AutoSize = true;
            this.label1_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Add.ForeColor = System.Drawing.Color.White;
            this.label1_Add.Location = new System.Drawing.Point(39, 13);
            this.label1_Add.Name = "label1_Add";
            this.label1_Add.Size = new System.Drawing.Size(99, 17);
            this.label1_Add.TabIndex = 54;
            this.label1_Add.Text = "Customers List";
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton1.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.fontIncrement = 0F;
            this.materialButton1.FontStyle = null;
            this.materialButton1.ForeColor = System.Drawing.Color.White;
            this.materialButton1.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton1.hoverforefont = null;
            this.materialButton1.hoverimage = null;
            this.materialButton1.Location = new System.Drawing.Point(607, 12);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.role = 0;
            this.materialButton1.Size = new System.Drawing.Size(110, 30);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton1.tempforefont = null;
            this.materialButton1.Text = "Add New";
            this.materialButton1.Totext = null;
            this.materialButton1.userole = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton_close
            // 
            this.materialButton_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_close.BackgroundImage = global::RestaurantSystem.Properties.Resources.back_64x64;
            this.materialButton_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialButton_close.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_close.FlatAppearance.BorderSize = 0;
            this.materialButton_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_close.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_close.fontIncrement = 0F;
            this.materialButton_close.FontStyle = null;
            this.materialButton_close.ForeColor = System.Drawing.Color.White;
            this.materialButton_close.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_close.hoverforefont = null;
            this.materialButton_close.hoverimage = null;
            this.materialButton_close.Location = new System.Drawing.Point(3, 6);
            this.materialButton_close.Name = "materialButton_close";
            this.materialButton_close.role = 0;
            this.materialButton_close.Size = new System.Drawing.Size(30, 30);
            this.materialButton_close.TabIndex = 2;
            this.materialButton_close.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_close.tempforefont = null;
            this.materialButton_close.Totext = null;
            this.materialButton_close.userole = false;
            this.materialButton_close.UseVisualStyleBackColor = false;
            this.materialButton_close.Click += new System.EventHandler(this.materialButton_close_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 75);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(951, 434);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_phone.Location = new System.Drawing.Point(484, 52);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(58, 19);
            this.label_phone.TabIndex = 12;
            this.label_phone.Text = "PHONE";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_address.Location = new System.Drawing.Point(216, 53);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(71, 19);
            this.label_address.TabIndex = 10;
            this.label_address.Text = "ADDRESS";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_name.Location = new System.Drawing.Point(5, 53);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(50, 19);
            this.label_name.TabIndex = 9;
            this.label_name.Text = "NAME";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(484, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "PHONE";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(216, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "ADDRESS";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(5, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "NAME";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.flowLayoutPanel1);
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
        private CustomControls.MaterialButton materialButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.MaterialButton materialButton_close;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1_Add;
        private CustomControls.BetterTextBox betterTextBox_search;
        private System.Windows.Forms.Panel panel2;
    }
}