namespace RestaurantSystem.Customer
{
    partial class Edit
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
            this.label1_Add = new System.Windows.Forms.Label();
            this.materialButton_cancel = new CustomControls.MaterialButton();
            this.materialButton_save = new CustomControls.MaterialButton();
            this.betterTextBox_nationality = new CustomControls.BetterTextBox();
            this.betterTextBox_currentAdvance = new CustomControls.BetterTextBox();
            this.betterTextBox_currentDue = new CustomControls.BetterTextBox();
            this.betterTextBox_email = new CustomControls.BetterTextBox();
            this.betterTextBox_phone = new CustomControls.BetterTextBox();
            this.betterTextBox_panno = new CustomControls.BetterTextBox();
            this.betterTextBox_address = new CustomControls.BetterTextBox();
            this.betterTextBox_name = new CustomControls.BetterTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.label1_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 40);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1_Add
            // 
            this.label1_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1_Add.AutoSize = true;
            this.label1_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Add.ForeColor = System.Drawing.Color.White;
            this.label1_Add.Location = new System.Drawing.Point(250, 12);
            this.label1_Add.Name = "label1_Add";
            this.label1_Add.Size = new System.Drawing.Size(32, 17);
            this.label1_Add.TabIndex = 53;
            this.label1_Add.Text = "Edit";
            // 
            // materialButton_cancel
            // 
            this.materialButton_cancel.BackColor = System.Drawing.Color.Red;
            this.materialButton_cancel.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_cancel.FlatAppearance.BorderSize = 0;
            this.materialButton_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_cancel.fontIncrement = 0F;
            this.materialButton_cancel.FontStyle = null;
            this.materialButton_cancel.ForeColor = System.Drawing.Color.White;
            this.materialButton_cancel.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_cancel.hoverforefont = null;
            this.materialButton_cancel.hoverimage = null;
            this.materialButton_cancel.Location = new System.Drawing.Point(400, 264);
            this.materialButton_cancel.Name = "materialButton_cancel";
            this.materialButton_cancel.role = 0;
            this.materialButton_cancel.Size = new System.Drawing.Size(91, 30);
            this.materialButton_cancel.TabIndex = 41;
            this.materialButton_cancel.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_cancel.tempforefont = null;
            this.materialButton_cancel.Text = "CANCEL";
            this.materialButton_cancel.Totext = null;
            this.materialButton_cancel.userole = false;
            this.materialButton_cancel.UseVisualStyleBackColor = false;
            this.materialButton_cancel.Click += new System.EventHandler(this.materialButton_cancel_Click);
            // 
            // materialButton_save
            // 
            this.materialButton_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
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
            this.materialButton_save.Location = new System.Drawing.Point(109, 264);
            this.materialButton_save.Name = "materialButton_save";
            this.materialButton_save.role = 0;
            this.materialButton_save.Size = new System.Drawing.Size(81, 30);
            this.materialButton_save.TabIndex = 40;
            this.materialButton_save.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_save.tempforefont = null;
            this.materialButton_save.Text = "SAVE";
            this.materialButton_save.Totext = null;
            this.materialButton_save.userole = false;
            this.materialButton_save.UseVisualStyleBackColor = false;
            this.materialButton_save.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // betterTextBox_nationality
            // 
            this.betterTextBox_nationality.append = "";
            this.betterTextBox_nationality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betterTextBox_nationality.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_nationality.intVal = 0;
            this.betterTextBox_nationality.Location = new System.Drawing.Point(109, 200);
            this.betterTextBox_nationality.Name = "betterTextBox_nationality";
            this.betterTextBox_nationality.prepend = "";
            this.betterTextBox_nationality.Rules = null;
            this.betterTextBox_nationality.Size = new System.Drawing.Size(415, 19);
            this.betterTextBox_nationality.TabIndex = 39;
            this.betterTextBox_nationality.textboxType = CustomControls.TextboxType.Text;
            // 
            // betterTextBox_currentAdvance
            // 
            this.betterTextBox_currentAdvance.append = "";
            this.betterTextBox_currentAdvance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betterTextBox_currentAdvance.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_currentAdvance.intVal = 0;
            this.betterTextBox_currentAdvance.Location = new System.Drawing.Point(404, 237);
            this.betterTextBox_currentAdvance.Name = "betterTextBox_currentAdvance";
            this.betterTextBox_currentAdvance.prepend = "";
            this.betterTextBox_currentAdvance.Rules = null;
            this.betterTextBox_currentAdvance.Size = new System.Drawing.Size(124, 19);
            this.betterTextBox_currentAdvance.TabIndex = 38;
            this.betterTextBox_currentAdvance.textboxType = CustomControls.TextboxType.Text;
            // 
            // betterTextBox_currentDue
            // 
            this.betterTextBox_currentDue.append = "";
            this.betterTextBox_currentDue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betterTextBox_currentDue.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_currentDue.intVal = 0;
            this.betterTextBox_currentDue.Location = new System.Drawing.Point(109, 232);
            this.betterTextBox_currentDue.Name = "betterTextBox_currentDue";
            this.betterTextBox_currentDue.prepend = "";
            this.betterTextBox_currentDue.Rules = null;
            this.betterTextBox_currentDue.Size = new System.Drawing.Size(146, 19);
            this.betterTextBox_currentDue.TabIndex = 37;
            this.betterTextBox_currentDue.textboxType = CustomControls.TextboxType.Text;
            // 
            // betterTextBox_email
            // 
            this.betterTextBox_email.append = "";
            this.betterTextBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betterTextBox_email.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_email.intVal = 0;
            this.betterTextBox_email.Location = new System.Drawing.Point(109, 169);
            this.betterTextBox_email.Name = "betterTextBox_email";
            this.betterTextBox_email.prepend = "";
            this.betterTextBox_email.Rules = null;
            this.betterTextBox_email.Size = new System.Drawing.Size(415, 19);
            this.betterTextBox_email.TabIndex = 35;
            this.betterTextBox_email.textboxType = CustomControls.TextboxType.Text;
            // 
            // betterTextBox_phone
            // 
            this.betterTextBox_phone.append = "";
            this.betterTextBox_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betterTextBox_phone.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_phone.intVal = 0;
            this.betterTextBox_phone.Location = new System.Drawing.Point(109, 139);
            this.betterTextBox_phone.Name = "betterTextBox_phone";
            this.betterTextBox_phone.prepend = "";
            this.betterTextBox_phone.Rules = null;
            this.betterTextBox_phone.Size = new System.Drawing.Size(415, 19);
            this.betterTextBox_phone.TabIndex = 34;
            this.betterTextBox_phone.textboxType = CustomControls.TextboxType.Text;
            // 
            // betterTextBox_panno
            // 
            this.betterTextBox_panno.append = "";
            this.betterTextBox_panno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betterTextBox_panno.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_panno.intVal = 0;
            this.betterTextBox_panno.Location = new System.Drawing.Point(109, 109);
            this.betterTextBox_panno.Name = "betterTextBox_panno";
            this.betterTextBox_panno.prepend = "";
            this.betterTextBox_panno.Rules = null;
            this.betterTextBox_panno.Size = new System.Drawing.Size(415, 19);
            this.betterTextBox_panno.TabIndex = 33;
            this.betterTextBox_panno.textboxType = CustomControls.TextboxType.Text;
            // 
            // betterTextBox_address
            // 
            this.betterTextBox_address.append = "";
            this.betterTextBox_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betterTextBox_address.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_address.intVal = 0;
            this.betterTextBox_address.Location = new System.Drawing.Point(109, 78);
            this.betterTextBox_address.Name = "betterTextBox_address";
            this.betterTextBox_address.prepend = "";
            this.betterTextBox_address.Rules = null;
            this.betterTextBox_address.Size = new System.Drawing.Size(415, 19);
            this.betterTextBox_address.TabIndex = 32;
            this.betterTextBox_address.textboxType = CustomControls.TextboxType.Text;
            // 
            // betterTextBox_name
            // 
            this.betterTextBox_name.append = "";
            this.betterTextBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betterTextBox_name.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_name.intVal = 0;
            this.betterTextBox_name.Location = new System.Drawing.Point(109, 48);
            this.betterTextBox_name.Name = "betterTextBox_name";
            this.betterTextBox_name.prepend = "";
            this.betterTextBox_name.Rules = null;
            this.betterTextBox_name.Size = new System.Drawing.Size(415, 19);
            this.betterTextBox_name.TabIndex = 31;
            this.betterTextBox_name.textboxType = CustomControls.TextboxType.Text;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "CURRENT DUE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "CURRENT ADVANCE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "NATIONALITY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "EMAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "PANNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "PHONE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "ADDRESS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "NAME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(109, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 1);
            this.panel2.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(109, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 1);
            this.panel3.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(109, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 1);
            this.panel4.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(109, 164);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(415, 1);
            this.panel5.TabIndex = 46;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(109, 193);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(415, 1);
            this.panel6.TabIndex = 46;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(109, 225);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(415, 1);
            this.panel7.TabIndex = 46;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Green;
            this.panel8.Location = new System.Drawing.Point(109, 257);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(144, 1);
            this.panel8.TabIndex = 46;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Green;
            this.panel9.Location = new System.Drawing.Point(406, 257);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(114, 1);
            this.panel9.TabIndex = 46;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 308);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialButton_cancel);
            this.Controls.Add(this.materialButton_save);
            this.Controls.Add(this.betterTextBox_nationality);
            this.Controls.Add(this.betterTextBox_currentAdvance);
            this.Controls.Add(this.betterTextBox_currentDue);
            this.Controls.Add(this.betterTextBox_email);
            this.Controls.Add(this.betterTextBox_phone);
            this.Controls.Add(this.betterTextBox_panno);
            this.Controls.Add(this.betterTextBox_address);
            this.Controls.Add(this.betterTextBox_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.MaterialButton materialButton_cancel;
        private CustomControls.MaterialButton materialButton_save;
        private CustomControls.BetterTextBox betterTextBox_nationality;
        private CustomControls.BetterTextBox betterTextBox_currentAdvance;
        private CustomControls.BetterTextBox betterTextBox_currentDue;
        private CustomControls.BetterTextBox betterTextBox_email;
        private CustomControls.BetterTextBox betterTextBox_phone;
        private CustomControls.BetterTextBox betterTextBox_panno;
        private CustomControls.BetterTextBox betterTextBox_address;
        private CustomControls.BetterTextBox betterTextBox_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1_Add;
    }
}