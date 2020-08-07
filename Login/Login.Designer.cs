﻿namespace RestaurantSystem.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gradientPanel1 = new CustomControls.GradientPanel();
            this.panel_login = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel_link = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_image = new System.Windows.Forms.Panel();
            this.gradientPanel2 = new CustomControls.GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.materialButton1_forgotpassword = new CustomControls.MaterialButton();
            this.materialButton1_login = new CustomControls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.betterTextBox2_password = new CustomControls.BetterTextBox();
            this.betterTextBox1_username = new CustomControls.BetterTextBox();
            this.materialButton2_closeX = new CustomControls.MaterialButton();
            this.gradientPanel1.SuspendLayout();
            this.panel_login.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.White;
            this.gradientPanel1.ColorTop = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.materialButton2_closeX);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1084, 660);
            this.gradientPanel1.TabIndex = 6;
            // 
            // panel_login
            // 
            this.panel_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_login.BackColor = System.Drawing.Color.White;
            this.panel_login.BackgroundImage = global::RestaurantSystem.Properties.Resources.panel;
            this.panel_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_login.Controls.Add(this.panel4);
            this.panel_login.Controls.Add(this.panel1);
            this.panel_login.Controls.Add(this.materialButton1_forgotpassword);
            this.panel_login.Controls.Add(this.materialButton1_login);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Controls.Add(this.panel3);
            this.panel_login.Controls.Add(this.panel2);
            this.panel_login.Controls.Add(this.betterTextBox2_password);
            this.panel_login.Controls.Add(this.betterTextBox1_username);
            this.panel_login.Location = new System.Drawing.Point(96, 61);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(900, 525);
            this.panel_login.TabIndex = 0;
            this.panel_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::RestaurantSystem.Properties.Resources.login_logo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(621, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 125);
            this.panel4.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.linkLabel_link);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel_image);
            this.panel1.Controls.Add(this.gradientPanel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(57, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 427);
            this.panel1.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(210, 385);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 15);
            this.panel5.TabIndex = 7;
            // 
            // linkLabel_link
            // 
            this.linkLabel_link.AutoSize = true;
            this.linkLabel_link.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_link.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel_link.Location = new System.Drawing.Point(227, 383);
            this.linkLabel_link.Name = "linkLabel_link";
            this.linkLabel_link.Size = new System.Drawing.Size(126, 17);
            this.linkLabel_link.TabIndex = 6;
            this.linkLabel_link.TabStop = true;
            this.linkLabel_link.Text = "By NeedTechnoSoft";
            this.linkLabel_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_link_LinkClicked);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(124, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Crafted With";
            // 
            // panel_image
            // 
            this.panel_image.BackgroundImage = global::RestaurantSystem.Properties.Resources.Dashboard;
            this.panel_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_image.Location = new System.Drawing.Point(19, 59);
            this.panel_image.Name = "panel_image";
            this.panel_image.Size = new System.Drawing.Size(446, 306);
            this.panel_image.TabIndex = 3;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.gradientPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(127)))));
            this.gradientPanel2.Location = new System.Drawing.Point(481, 10);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(3, 406);
            this.gradientPanel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(11, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(467, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "Restaurant Management System";
            // 
            // materialButton1_forgotpassword
            // 
            this.materialButton1_forgotpassword.BackColor = System.Drawing.Color.Transparent;
            this.materialButton1_forgotpassword.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton1_forgotpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1_forgotpassword.FlatAppearance.BorderSize = 0;
            this.materialButton1_forgotpassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.materialButton1_forgotpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1_forgotpassword.fontIncrement = 0F;
            this.materialButton1_forgotpassword.FontStyle = null;
            this.materialButton1_forgotpassword.hoverforecolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(150)))), ((int)(((byte)(121)))));
            this.materialButton1_forgotpassword.hoverforefont = null;
            this.materialButton1_forgotpassword.hoverimage = null;
            this.materialButton1_forgotpassword.Location = new System.Drawing.Point(622, 396);
            this.materialButton1_forgotpassword.Name = "materialButton1_forgotpassword";
            this.materialButton1_forgotpassword.role = 0;
            this.materialButton1_forgotpassword.Size = new System.Drawing.Size(123, 23);
            this.materialButton1_forgotpassword.TabIndex = 3;
            this.materialButton1_forgotpassword.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton1_forgotpassword.tempforefont = null;
            this.materialButton1_forgotpassword.Text = "Forgot Password?";
            this.materialButton1_forgotpassword.Totext = null;
            this.materialButton1_forgotpassword.userole = false;
            this.materialButton1_forgotpassword.UseVisualStyleBackColor = false;
            this.materialButton1_forgotpassword.Click += new System.EventHandler(this.materialButton1_forgotpassword_Click);
            // 
            // materialButton1_login
            // 
            this.materialButton1_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(150)))), ((int)(((byte)(121)))));
            this.materialButton1_login.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton1_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1_login.FlatAppearance.BorderSize = 0;
            this.materialButton1_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.materialButton1_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1_login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1_login.fontIncrement = 0F;
            this.materialButton1_login.FontStyle = null;
            this.materialButton1_login.ForeColor = System.Drawing.Color.White;
            this.materialButton1_login.hoverforecolor = System.Drawing.Color.White;
            this.materialButton1_login.hoverforefont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1_login.hoverimage = null;
            this.materialButton1_login.Location = new System.Drawing.Point(633, 353);
            this.materialButton1_login.Name = "materialButton1_login";
            this.materialButton1_login.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.materialButton1_login.role = 0;
            this.materialButton1_login.Size = new System.Drawing.Size(100, 37);
            this.materialButton1_login.TabIndex = 2;
            this.materialButton1_login.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton1_login.tempforefont = null;
            this.materialButton1_login.Text = "Login";
            this.materialButton1_login.Totext = null;
            this.materialButton1_login.userole = false;
            this.materialButton1_login.UseVisualStyleBackColor = false;
            this.materialButton1_login.Click += new System.EventHandler(this.materialButton1_login_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(560, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(557, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(120)))), ((int)(((byte)(121)))));
            this.panel3.Location = new System.Drawing.Point(565, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(120)))), ((int)(((byte)(121)))));
            this.panel2.Location = new System.Drawing.Point(565, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 1;
            // 
            // betterTextBox2_password
            // 
            this.betterTextBox2_password.BackColor = System.Drawing.Color.White;
            this.betterTextBox2_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betterTextBox2_password.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox2_password.intVal = 0;
            this.betterTextBox2_password.Location = new System.Drawing.Point(567, 309);
            this.betterTextBox2_password.Name = "betterTextBox2_password";
            this.betterTextBox2_password.PasswordChar = '*';
            this.betterTextBox2_password.Size = new System.Drawing.Size(232, 16);
            this.betterTextBox2_password.TabIndex = 1;
            this.betterTextBox2_password.textboxType = CustomControls.TextboxType.Text;
            this.betterTextBox2_password.Enter += new System.EventHandler(this.betterTextBox2_password_Enter);
            this.betterTextBox2_password.Leave += new System.EventHandler(this.betterTextBox2_password_Leave);
            // 
            // betterTextBox1_username
            // 
            this.betterTextBox1_username.BackColor = System.Drawing.Color.White;
            this.betterTextBox1_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betterTextBox1_username.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox1_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox1_username.intVal = 0;
            this.betterTextBox1_username.Location = new System.Drawing.Point(567, 249);
            this.betterTextBox1_username.Name = "betterTextBox1_username";
            this.betterTextBox1_username.Size = new System.Drawing.Size(232, 18);
            this.betterTextBox1_username.TabIndex = 0;
            this.betterTextBox1_username.textboxType = CustomControls.TextboxType.Text;
            this.betterTextBox1_username.TextChanged += new System.EventHandler(this.betterTextBox1_username_TextChanged);
            this.betterTextBox1_username.Enter += new System.EventHandler(this.betterTextBox1_username_Enter);
            this.betterTextBox1_username.Leave += new System.EventHandler(this.betterTextBox1_username_Leave);
            // 
            // materialButton2_closeX
            // 
            this.materialButton2_closeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton2_closeX.BackgroundImage = global::RestaurantSystem.Properties.Resources.close_96x96;
            this.materialButton2_closeX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialButton2_closeX.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton2_closeX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton2_closeX.FlatAppearance.BorderSize = 0;
            this.materialButton2_closeX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2_closeX.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton2_closeX.fontIncrement = 0F;
            this.materialButton2_closeX.FontStyle = null;
            this.materialButton2_closeX.ForeColor = System.Drawing.Color.Maroon;
            this.materialButton2_closeX.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton2_closeX.hoverforefont = null;
            this.materialButton2_closeX.hoverimage = null;
            this.materialButton2_closeX.Location = new System.Drawing.Point(1050, 3);
            this.materialButton2_closeX.Name = "materialButton2_closeX";
            this.materialButton2_closeX.role = 0;
            this.materialButton2_closeX.Size = new System.Drawing.Size(30, 30);
            this.materialButton2_closeX.TabIndex = 5;
            this.materialButton2_closeX.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton2_closeX.tempforefont = null;
            this.materialButton2_closeX.Totext = null;
            this.materialButton2_closeX.userole = false;
            this.materialButton2_closeX.UseVisualStyleBackColor = false;
            this.materialButton2_closeX.Click += new System.EventHandler(this.materialButton2_closeX_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 660);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.gradientPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_login;
        private CustomControls.MaterialButton materialButton1_forgotpassword;
        private CustomControls.MaterialButton materialButton1_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.BetterTextBox betterTextBox2_password;
        private CustomControls.BetterTextBox betterTextBox1_username;
        private CustomControls.MaterialButton materialButton2_closeX;
        private CustomControls.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.GradientPanel gradientPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_image;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel linkLabel_link;
        private System.Windows.Forms.Label label6;
    }
}