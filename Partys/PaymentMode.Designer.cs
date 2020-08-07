namespace RestaurantSystem.Partys
{
    partial class PaymentMode
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_bank = new System.Windows.Forms.Panel();
            this.betterTextBox_depositer = new CustomControls.BetterTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.betterTextBox_accountnum = new CustomControls.BetterTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.betterTextBox_bankname = new CustomControls.BetterTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_cash = new System.Windows.Forms.Panel();
            this.betterTextBox_paidby = new CustomControls.BetterTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.materialButton_save = new CustomControls.MaterialButton();
            this.materialButton_cancel = new CustomControls.MaterialButton();
            this.betterTextBox_due = new CustomControls.BetterTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.betterTextBox_paid = new CustomControls.BetterTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBo_bank = new System.Windows.Forms.CheckBox();
            this.betterTextBox_return = new CustomControls.BetterTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_bank.SuspendLayout();
            this.panel_cash.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Mode";
            // 
            // panel_bank
            // 
            this.panel_bank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bank.Controls.Add(this.betterTextBox_depositer);
            this.panel_bank.Controls.Add(this.label4);
            this.panel_bank.Controls.Add(this.betterTextBox_accountnum);
            this.panel_bank.Controls.Add(this.label3);
            this.panel_bank.Controls.Add(this.betterTextBox_bankname);
            this.panel_bank.Controls.Add(this.label2);
            this.panel_bank.Enabled = false;
            this.panel_bank.Location = new System.Drawing.Point(4, 304);
            this.panel_bank.Name = "panel_bank";
            this.panel_bank.Size = new System.Drawing.Size(332, 141);
            this.panel_bank.TabIndex = 3;
            // 
            // betterTextBox_depositer
            // 
            this.betterTextBox_depositer.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_depositer.intVal = 0;
            this.betterTextBox_depositer.Location = new System.Drawing.Point(13, 112);
            this.betterTextBox_depositer.Name = "betterTextBox_depositer";
            this.betterTextBox_depositer.Size = new System.Drawing.Size(306, 20);
            this.betterTextBox_depositer.TabIndex = 2;
            this.betterTextBox_depositer.textboxType = CustomControls.TextboxType.Text;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Depositer Name";
            // 
            // betterTextBox_accountnum
            // 
            this.betterTextBox_accountnum.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_accountnum.intVal = 0;
            this.betterTextBox_accountnum.Location = new System.Drawing.Point(13, 69);
            this.betterTextBox_accountnum.Name = "betterTextBox_accountnum";
            this.betterTextBox_accountnum.Size = new System.Drawing.Size(306, 20);
            this.betterTextBox_accountnum.TabIndex = 1;
            this.betterTextBox_accountnum.textboxType = CustomControls.TextboxType.Text;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number";
            // 
            // betterTextBox_bankname
            // 
            this.betterTextBox_bankname.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_bankname.intVal = 0;
            this.betterTextBox_bankname.Location = new System.Drawing.Point(12, 24);
            this.betterTextBox_bankname.Name = "betterTextBox_bankname";
            this.betterTextBox_bankname.Size = new System.Drawing.Size(306, 20);
            this.betterTextBox_bankname.TabIndex = 0;
            this.betterTextBox_bankname.textboxType = CustomControls.TextboxType.Text;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bank Name";
            // 
            // panel_cash
            // 
            this.panel_cash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_cash.Controls.Add(this.betterTextBox_paidby);
            this.panel_cash.Controls.Add(this.label5);
            this.panel_cash.Location = new System.Drawing.Point(4, 240);
            this.panel_cash.Name = "panel_cash";
            this.panel_cash.Size = new System.Drawing.Size(332, 62);
            this.panel_cash.TabIndex = 4;
            // 
            // betterTextBox_paidby
            // 
            this.betterTextBox_paidby.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_paidby.intVal = 0;
            this.betterTextBox_paidby.Location = new System.Drawing.Point(6, 26);
            this.betterTextBox_paidby.Name = "betterTextBox_paidby";
            this.betterTextBox_paidby.Size = new System.Drawing.Size(312, 20);
            this.betterTextBox_paidby.TabIndex = 0;
            this.betterTextBox_paidby.textboxType = CustomControls.TextboxType.Text;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Entry By";
            // 
            // materialButton_save
            // 
            this.materialButton_save.BackColor = System.Drawing.Color.Navy;
            this.materialButton_save.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_save.FlatAppearance.BorderSize = 0;
            this.materialButton_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_save.fontIncrement = 0F;
            this.materialButton_save.FontStyle = null;
            this.materialButton_save.ForeColor = System.Drawing.Color.White;
            this.materialButton_save.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_save.hoverforefont = null;
            this.materialButton_save.hoverimage = null;
            this.materialButton_save.Location = new System.Drawing.Point(123, 461);
            this.materialButton_save.Name = "materialButton_save";
            this.materialButton_save.role = 0;
            this.materialButton_save.Size = new System.Drawing.Size(96, 30);
            this.materialButton_save.TabIndex = 1;
            this.materialButton_save.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_save.tempforefont = null;
            this.materialButton_save.Text = "Save";
            this.materialButton_save.Totext = null;
            this.materialButton_save.userole = false;
            this.materialButton_save.UseVisualStyleBackColor = false;
            this.materialButton_save.Click += new System.EventHandler(this.materialButton_save_Click);
            // 
            // materialButton_cancel
            // 
            this.materialButton_cancel.BackColor = System.Drawing.Color.Red;
            this.materialButton_cancel.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_cancel.FlatAppearance.BorderSize = 0;
            this.materialButton_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_cancel.fontIncrement = 0F;
            this.materialButton_cancel.FontStyle = null;
            this.materialButton_cancel.ForeColor = System.Drawing.Color.White;
            this.materialButton_cancel.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_cancel.hoverforefont = null;
            this.materialButton_cancel.hoverimage = null;
            this.materialButton_cancel.Location = new System.Drawing.Point(234, 461);
            this.materialButton_cancel.Name = "materialButton_cancel";
            this.materialButton_cancel.role = 0;
            this.materialButton_cancel.Size = new System.Drawing.Size(96, 30);
            this.materialButton_cancel.TabIndex = 6;
            this.materialButton_cancel.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_cancel.tempforefont = null;
            this.materialButton_cancel.Text = "Cancel";
            this.materialButton_cancel.Totext = null;
            this.materialButton_cancel.userole = false;
            this.materialButton_cancel.UseVisualStyleBackColor = false;
            this.materialButton_cancel.Click += new System.EventHandler(this.materialButton_cancel_Click);
            // 
            // betterTextBox_due
            // 
            this.betterTextBox_due.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_due.Enabled = false;
            this.betterTextBox_due.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_due.intVal = 0;
            this.betterTextBox_due.Location = new System.Drawing.Point(11, 96);
            this.betterTextBox_due.Name = "betterTextBox_due";
            this.betterTextBox_due.Size = new System.Drawing.Size(315, 26);
            this.betterTextBox_due.TabIndex = 8;
            this.betterTextBox_due.textboxType = CustomControls.TextboxType.Decimal;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Due Amount";
            // 
            // betterTextBox_paid
            // 
            this.betterTextBox_paid.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_paid.intVal = 0;
            this.betterTextBox_paid.Location = new System.Drawing.Point(10, 145);
            this.betterTextBox_paid.Name = "betterTextBox_paid";
            this.betterTextBox_paid.Size = new System.Drawing.Size(315, 26);
            this.betterTextBox_paid.TabIndex = 0;
            this.betterTextBox_paid.textboxType = CustomControls.TextboxType.Decimal;
            this.betterTextBox_paid.TextChanged += new System.EventHandler(this.betterTextBox_paid_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Paid Amount";
            // 
            // checkBo_bank
            // 
            this.checkBo_bank.AutoSize = true;
            this.checkBo_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBo_bank.Location = new System.Drawing.Point(11, 45);
            this.checkBo_bank.Name = "checkBo_bank";
            this.checkBo_bank.Size = new System.Drawing.Size(87, 24);
            this.checkBo_bank.TabIndex = 11;
            this.checkBo_bank.Text = "By Cash";
            this.checkBo_bank.UseVisualStyleBackColor = true;
            this.checkBo_bank.CheckedChanged += new System.EventHandler(this.checkBo_bank_CheckedChanged);
            // 
            // betterTextBox_return
            // 
            this.betterTextBox_return.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_return.Enabled = false;
            this.betterTextBox_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_return.intVal = 0;
            this.betterTextBox_return.Location = new System.Drawing.Point(11, 192);
            this.betterTextBox_return.Name = "betterTextBox_return";
            this.betterTextBox_return.Size = new System.Drawing.Size(315, 26);
            this.betterTextBox_return.TabIndex = 13;
            this.betterTextBox_return.textboxType = CustomControls.TextboxType.Decimal;
            this.betterTextBox_return.TextChanged += new System.EventHandler(this.betterTextBox_return_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Return Amount";
            // 
            // PaymentMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 503);
            this.Controls.Add(this.betterTextBox_return);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBo_bank);
            this.Controls.Add(this.betterTextBox_paid);
            this.Controls.Add(this.materialButton_cancel);
            this.Controls.Add(this.panel_cash);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.materialButton_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_bank);
            this.Controls.Add(this.betterTextBox_due);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentMode";
            this.Load += new System.EventHandler(this.PaymentMode_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_bank.ResumeLayout(false);
            this.panel_bank.PerformLayout();
            this.panel_cash.ResumeLayout(false);
            this.panel_cash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_bank;
        private System.Windows.Forms.Panel panel_cash;
        private CustomControls.MaterialButton materialButton_save;
        private CustomControls.BetterTextBox betterTextBox_depositer;
        private System.Windows.Forms.Label label4;
        private CustomControls.BetterTextBox betterTextBox_accountnum;
        private System.Windows.Forms.Label label3;
        private CustomControls.BetterTextBox betterTextBox_bankname;
        private System.Windows.Forms.Label label2;
        private CustomControls.BetterTextBox betterTextBox_paidby;
        private System.Windows.Forms.Label label5;
        private CustomControls.MaterialButton materialButton_cancel;
        private CustomControls.BetterTextBox betterTextBox_due;
        private System.Windows.Forms.Label label6;
        private CustomControls.BetterTextBox betterTextBox_paid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBo_bank;
        private CustomControls.BetterTextBox betterTextBox_return;
        private System.Windows.Forms.Label label8;
    }
}