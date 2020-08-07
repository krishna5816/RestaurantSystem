namespace RestaurantSystem.Users
{
    partial class PasswordChange
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
            this.betterTextBox_retypepassword = new CustomControls.BetterTextBox();
            this.betterTextBox_password = new CustomControls.BetterTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialButton_save = new CustomControls.MaterialButton();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Size = new System.Drawing.Size(127, 19);
            this.label_title.Text = "Change Password";
            // 
            // panel_Divider
            // 
            this.panel_Divider.Size = new System.Drawing.Size(261, 2);
            // 
            // betterTextBox_retypepassword
            // 
            this.betterTextBox_retypepassword.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_retypepassword.intVal = 0;
            this.betterTextBox_retypepassword.Location = new System.Drawing.Point(6, 142);
            this.betterTextBox_retypepassword.Name = "betterTextBox_retypepassword";
            this.betterTextBox_retypepassword.Size = new System.Drawing.Size(247, 25);
            this.betterTextBox_retypepassword.TabIndex = 7;
            this.betterTextBox_retypepassword.textboxType = CustomControls.TextboxType.Text;
            // 
            // betterTextBox_password
            // 
            this.betterTextBox_password.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_password.intVal = 0;
            this.betterTextBox_password.Location = new System.Drawing.Point(6, 87);
            this.betterTextBox_password.Name = "betterTextBox_password";
            this.betterTextBox_password.Size = new System.Drawing.Size(247, 25);
            this.betterTextBox_password.TabIndex = 6;
            this.betterTextBox_password.textboxType = CustomControls.TextboxType.Text;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Retype Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // materialButton_save
            // 
            this.materialButton_save.BackColor = System.Drawing.Color.Navy;
            this.materialButton_save.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_save.FlatAppearance.BorderSize = 0;
            this.materialButton_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_save.fontIncrement = 0F;
            this.materialButton_save.FontStyle = null;
            this.materialButton_save.ForeColor = System.Drawing.Color.White;
            this.materialButton_save.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_save.hoverforefont = null;
            this.materialButton_save.hoverimage = null;
            this.materialButton_save.Location = new System.Drawing.Point(6, 173);
            this.materialButton_save.Name = "materialButton_save";
            this.materialButton_save.role = 0;
            this.materialButton_save.Size = new System.Drawing.Size(120, 37);
            this.materialButton_save.TabIndex = 12;
            this.materialButton_save.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_save.tempforefont = null;
            this.materialButton_save.Text = "Save";
            this.materialButton_save.Totext = null;
            this.materialButton_save.userole = true;
            this.materialButton_save.UseVisualStyleBackColor = false;
            this.materialButton_save.Click += new System.EventHandler(this.materialButton_save_Click);
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(262, 219);
            this.Controls.Add(this.materialButton_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.betterTextBox_retypepassword);
            this.Controls.Add(this.betterTextBox_password);
            this.Name = "PasswordChange";
            this.Save += new CustomControls.MaterialForm.Actions(this.PAsswordChange_Save);
            this.Controls.SetChildIndex(this.label_title, 0);
            this.Controls.SetChildIndex(this.panel_Divider, 0);
            this.Controls.SetChildIndex(this.betterTextBox_password, 0);
            this.Controls.SetChildIndex(this.betterTextBox_retypepassword, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.materialButton_save, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.BetterTextBox betterTextBox_retypepassword;
        private CustomControls.BetterTextBox betterTextBox_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.MaterialButton materialButton_save;
    }
}
