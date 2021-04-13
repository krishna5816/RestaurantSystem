namespace RestaurantSystem.Parties
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
            this.betterTextBox_search = new CustomControls.BetterTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add = new CustomControls.MaterialButton();
            this.materialButton_close = new CustomControls.MaterialButton();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.betterTextBox_search);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.materialButton_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 40);
            this.panel1.TabIndex = 0;
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
            this.betterTextBox_search.Location = new System.Drawing.Point(775, 8);
            this.betterTextBox_search.Name = "betterTextBox_search";
            this.betterTextBox_search.prepend = "";
            this.betterTextBox_search.Rules = null;
            this.betterTextBox_search.Size = new System.Drawing.Size(215, 25);
            this.betterTextBox_search.TabIndex = 21;
            this.betterTextBox_search.textboxType = CustomControls.TextboxType.Text;
            this.betterTextBox_search.TextChanged += new System.EventHandler(this.betterTextBox_search_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 1);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "List of Parties";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_add.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.fontIncrement = 0F;
            this.btn_add.FontStyle = null;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.hoverforecolor = System.Drawing.Color.Empty;
            this.btn_add.hoverforefont = null;
            this.btn_add.hoverimage = null;
            this.btn_add.Location = new System.Drawing.Point(670, 7);
            this.btn_add.Name = "btn_add";
            this.btn_add.role = 0;
            this.btn_add.Size = new System.Drawing.Size(99, 30);
            this.btn_add.TabIndex = 0;
            this.btn_add.tempforecolor = System.Drawing.Color.Empty;
            this.btn_add.tempforefont = null;
            this.btn_add.Text = "Add New";
            this.btn_add.Totext = null;
            this.btn_add.userole = false;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // materialButton_close
            // 
            this.materialButton_close.BackgroundImage = global::RestaurantSystem.Properties.Resources.back_64x64;
            this.materialButton_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialButton_close.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_close.FlatAppearance.BorderSize = 0;
            this.materialButton_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.materialButton_close.TabIndex = 1;
            this.materialButton_close.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_close.tempforefont = null;
            this.materialButton_close.Totext = null;
            this.materialButton_close.userole = false;
            this.materialButton_close.UseVisualStyleBackColor = true;
            this.materialButton_close.Click += new System.EventHandler(this.materialButton_close_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_menu.BackColor = System.Drawing.Color.White;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Location = new System.Drawing.Point(0, 78);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(999, 386);
            this.panel_menu.TabIndex = 1;
            this.panel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(477, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "PAN Number";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.lbl_phone.Location = new System.Drawing.Point(385, 54);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(54, 17);
            this.lbl_phone.TabIndex = 11;
            this.lbl_phone.Text = "Phone";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.lbl_address.Location = new System.Drawing.Point(236, 54);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(67, 17);
            this.lbl_address.TabIndex = 10;
            this.lbl_address.Text = "Address";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.lbl_name.Location = new System.Drawing.Point(3, 54);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 17);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label11.Location = new System.Drawing.Point(477, 468);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "PAN Number";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label12.Location = new System.Drawing.Point(385, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Phone";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label13.Location = new System.Drawing.Point(236, 468);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "Address";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label14.Location = new System.Drawing.Point(3, 468);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "Name";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 497);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.MaterialButton btn_add;
        private System.Windows.Forms.Panel panel_menu;
        private CustomControls.MaterialButton materialButton_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.BetterTextBox betterTextBox_search;
    }
}