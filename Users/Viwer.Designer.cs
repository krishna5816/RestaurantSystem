namespace RestaurantSystem.Users
{
    partial class Viwer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_role = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_enabled = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton_ChangePassword = new CustomControls.MaterialButton();
            this.panel_fill = new System.Windows.Forms.Panel();
            this.panel_fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(25, 24);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(79, 19);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "UserName";
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_role.Location = new System.Drawing.Point(25, 72);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(79, 19);
            this.label_role.TabIndex = 3;
            this.label_role.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Role";
            // 
            // checkBox_enabled
            // 
            this.checkBox_enabled.AutoSize = true;
            this.checkBox_enabled.Location = new System.Drawing.Point(7, 107);
            this.checkBox_enabled.Name = "checkBox_enabled";
            this.checkBox_enabled.Size = new System.Drawing.Size(76, 23);
            this.checkBox_enabled.TabIndex = 4;
            this.checkBox_enabled.Text = "Enabled";
            this.checkBox_enabled.UseVisualStyleBackColor = true;
            this.checkBox_enabled.CheckedChanged += new System.EventHandler(this.checkBox_enabled_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 2);
            this.panel1.TabIndex = 5;
            // 
            // materialButton_ChangePassword
            // 
            this.materialButton_ChangePassword.BackColor = System.Drawing.Color.Navy;
            this.materialButton_ChangePassword.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_ChangePassword.FlatAppearance.BorderSize = 0;
            this.materialButton_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_ChangePassword.fontIncrement = 0F;
            this.materialButton_ChangePassword.FontStyle = null;
            this.materialButton_ChangePassword.ForeColor = System.Drawing.Color.White;
            this.materialButton_ChangePassword.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_ChangePassword.hoverforefont = null;
            this.materialButton_ChangePassword.hoverimage = null;
            this.materialButton_ChangePassword.Location = new System.Drawing.Point(86, 104);
            this.materialButton_ChangePassword.Name = "materialButton_ChangePassword";
            this.materialButton_ChangePassword.role = 0;
            this.materialButton_ChangePassword.Size = new System.Drawing.Size(205, 27);
            this.materialButton_ChangePassword.TabIndex = 6;
            this.materialButton_ChangePassword.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_ChangePassword.tempforefont = null;
            this.materialButton_ChangePassword.Text = "Change Password";
            this.materialButton_ChangePassword.Totext = null;
            this.materialButton_ChangePassword.userole = true;
            this.materialButton_ChangePassword.UseVisualStyleBackColor = false;
            this.materialButton_ChangePassword.Click += new System.EventHandler(this.materialButton_ChangePassword_Click);
            // 
            // panel_fill
            // 
            this.panel_fill.Controls.Add(this.materialButton_ChangePassword);
            this.panel_fill.Controls.Add(this.checkBox_enabled);
            this.panel_fill.Controls.Add(this.label_role);
            this.panel_fill.Controls.Add(this.label4);
            this.panel_fill.Controls.Add(this.label_username);
            this.panel_fill.Controls.Add(this.label1);
            this.panel_fill.Location = new System.Drawing.Point(3, 3);
            this.panel_fill.Name = "panel_fill";
            this.panel_fill.Size = new System.Drawing.Size(300, 140);
            this.panel_fill.TabIndex = 7;
            // 
            // Viwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_fill);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Viwer";
            this.Size = new System.Drawing.Size(306, 146);
            this.Load += new System.EventHandler(this.Viwer_Load);
            this.panel_fill.ResumeLayout(false);
            this.panel_fill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_enabled;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.MaterialButton materialButton_ChangePassword;
        private System.Windows.Forms.Panel panel_fill;
    }
}
