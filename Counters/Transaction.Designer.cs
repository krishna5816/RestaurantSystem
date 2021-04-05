namespace RestaurantSystem.Counters
{
    partial class Transaction
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
            this.betterListView = new CustomControls.BetterListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.materialButton_refresh = new CustomControls.MaterialButton();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_fill = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.betterTextBox_grosstotal = new CustomControls.BetterTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.betterTextBox_discount = new CustomControls.BetterTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.betterTextBox_tax = new CustomControls.BetterTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.betterTextBox_nettotal = new CustomControls.BetterTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.betterTextBox_paidamount = new CustomControls.BetterTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.betterTextBox_dueamount = new CustomControls.BetterTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.betterTextBox_return = new CustomControls.BetterTextBox();
            this.panel1.SuspendLayout();
            this.panel_fill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // betterListView
            // 
            this.betterListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.betterListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betterListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterListView.FullRowSelect = true;
            this.betterListView.GridLines = true;
            this.betterListView.HideSelection = false;
            this.betterListView.Location = new System.Drawing.Point(0, 0);
            this.betterListView.Name = "betterListView";
            this.betterListView.Size = new System.Drawing.Size(910, 463);
            this.betterListView.sortable = false;
            this.betterListView.TabIndex = 0;
            this.betterListView.UseCompatibleStateImageBehavior = false;
            this.betterListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SN";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "BillNo";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gross Total";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Discount";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TaxAmount";
            this.columnHeader6.Width = 98;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Net Total";
            this.columnHeader7.Width = 88;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Paid Amount";
            this.columnHeader8.Width = 106;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Due Amount";
            this.columnHeader9.Width = 117;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Return";
            this.columnHeader10.Width = 107;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(96)))), ((int)(((byte)(119)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.materialButton_refresh);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 40);
            this.panel1.TabIndex = 18;
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(96)))), ((int)(((byte)(119)))));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(875, 5);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(30, 30);
            this.button_close.TabIndex = 16;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // materialButton_refresh
            // 
            this.materialButton_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialButton_refresh.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_refresh.FlatAppearance.BorderSize = 0;
            this.materialButton_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_refresh.fontIncrement = 0F;
            this.materialButton_refresh.FontStyle = null;
            this.materialButton_refresh.ForeColor = System.Drawing.Color.White;
            this.materialButton_refresh.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_refresh.hoverforefont = null;
            this.materialButton_refresh.hoverimage = null;
            this.materialButton_refresh.Location = new System.Drawing.Point(765, 5);
            this.materialButton_refresh.Name = "materialButton_refresh";
            this.materialButton_refresh.role = 1;
            this.materialButton_refresh.Size = new System.Drawing.Size(104, 27);
            this.materialButton_refresh.TabIndex = 14;
            this.materialButton_refresh.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_refresh.tempforefont = null;
            this.materialButton_refresh.Text = "Refresh";
            this.materialButton_refresh.Totext = null;
            this.materialButton_refresh.userole = true;
            this.materialButton_refresh.UseVisualStyleBackColor = false;
            this.materialButton_refresh.Click += new System.EventHandler(this.materialButton_refresh_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(3, 10);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(129, 19);
            this.label_title.TabIndex = 13;
            this.label_title.Text = "Daily Transactions";
            // 
            // panel_fill
            // 
            this.panel_fill.Controls.Add(this.betterListView);
            this.panel_fill.Controls.Add(this.panel2);
            this.panel_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fill.Location = new System.Drawing.Point(0, 40);
            this.panel_fill.Name = "panel_fill";
            this.panel_fill.Size = new System.Drawing.Size(910, 525);
            this.panel_fill.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.betterTextBox_return);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.betterTextBox_dueamount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.betterTextBox_paidamount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.betterTextBox_nettotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.betterTextBox_tax);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.betterTextBox_discount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.betterTextBox_grosstotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 463);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 62);
            this.panel2.TabIndex = 1;
            // 
            // betterTextBox_grosstotal
            // 
            this.betterTextBox_grosstotal.append = "";
            this.betterTextBox_grosstotal.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_grosstotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_grosstotal.intVal = 0;
            this.betterTextBox_grosstotal.Location = new System.Drawing.Point(152, 29);
            this.betterTextBox_grosstotal.Name = "betterTextBox_grosstotal";
            this.betterTextBox_grosstotal.prepend = "";
            this.betterTextBox_grosstotal.ReadOnly = true;
            this.betterTextBox_grosstotal.Rules = null;
            this.betterTextBox_grosstotal.Size = new System.Drawing.Size(102, 26);
            this.betterTextBox_grosstotal.TabIndex = 0;
            this.betterTextBox_grosstotal.textboxType = CustomControls.TextboxType.Decimal;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gross Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Discount";
            // 
            // betterTextBox_discount
            // 
            this.betterTextBox_discount.append = "";
            this.betterTextBox_discount.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_discount.intVal = 0;
            this.betterTextBox_discount.Location = new System.Drawing.Point(260, 29);
            this.betterTextBox_discount.Name = "betterTextBox_discount";
            this.betterTextBox_discount.prepend = "";
            this.betterTextBox_discount.ReadOnly = true;
            this.betterTextBox_discount.Rules = null;
            this.betterTextBox_discount.Size = new System.Drawing.Size(102, 26);
            this.betterTextBox_discount.TabIndex = 2;
            this.betterTextBox_discount.textboxType = CustomControls.TextboxType.Decimal;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tax";
            // 
            // betterTextBox_tax
            // 
            this.betterTextBox_tax.append = "";
            this.betterTextBox_tax.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_tax.intVal = 0;
            this.betterTextBox_tax.Location = new System.Drawing.Point(368, 29);
            this.betterTextBox_tax.Name = "betterTextBox_tax";
            this.betterTextBox_tax.prepend = "";
            this.betterTextBox_tax.ReadOnly = true;
            this.betterTextBox_tax.Rules = null;
            this.betterTextBox_tax.Size = new System.Drawing.Size(102, 26);
            this.betterTextBox_tax.TabIndex = 4;
            this.betterTextBox_tax.textboxType = CustomControls.TextboxType.Decimal;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Net Total";
            // 
            // betterTextBox_nettotal
            // 
            this.betterTextBox_nettotal.append = "";
            this.betterTextBox_nettotal.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_nettotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_nettotal.intVal = 0;
            this.betterTextBox_nettotal.Location = new System.Drawing.Point(476, 29);
            this.betterTextBox_nettotal.Name = "betterTextBox_nettotal";
            this.betterTextBox_nettotal.prepend = "";
            this.betterTextBox_nettotal.ReadOnly = true;
            this.betterTextBox_nettotal.Rules = null;
            this.betterTextBox_nettotal.Size = new System.Drawing.Size(102, 26);
            this.betterTextBox_nettotal.TabIndex = 6;
            this.betterTextBox_nettotal.textboxType = CustomControls.TextboxType.Decimal;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Paid Amout";
            // 
            // betterTextBox_paidamount
            // 
            this.betterTextBox_paidamount.append = "";
            this.betterTextBox_paidamount.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_paidamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_paidamount.intVal = 0;
            this.betterTextBox_paidamount.Location = new System.Drawing.Point(584, 29);
            this.betterTextBox_paidamount.Name = "betterTextBox_paidamount";
            this.betterTextBox_paidamount.prepend = "";
            this.betterTextBox_paidamount.ReadOnly = true;
            this.betterTextBox_paidamount.Rules = null;
            this.betterTextBox_paidamount.Size = new System.Drawing.Size(102, 26);
            this.betterTextBox_paidamount.TabIndex = 8;
            this.betterTextBox_paidamount.textboxType = CustomControls.TextboxType.Decimal;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(689, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Due Amount";
            // 
            // betterTextBox_dueamount
            // 
            this.betterTextBox_dueamount.append = "";
            this.betterTextBox_dueamount.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_dueamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_dueamount.intVal = 0;
            this.betterTextBox_dueamount.Location = new System.Drawing.Point(692, 29);
            this.betterTextBox_dueamount.Name = "betterTextBox_dueamount";
            this.betterTextBox_dueamount.prepend = "";
            this.betterTextBox_dueamount.ReadOnly = true;
            this.betterTextBox_dueamount.Rules = null;
            this.betterTextBox_dueamount.Size = new System.Drawing.Size(102, 26);
            this.betterTextBox_dueamount.TabIndex = 10;
            this.betterTextBox_dueamount.textboxType = CustomControls.TextboxType.Decimal;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(799, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Return Amount";
            // 
            // betterTextBox_return
            // 
            this.betterTextBox_return.append = "";
            this.betterTextBox_return.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_return.intVal = 0;
            this.betterTextBox_return.Location = new System.Drawing.Point(802, 29);
            this.betterTextBox_return.Name = "betterTextBox_return";
            this.betterTextBox_return.prepend = "";
            this.betterTextBox_return.ReadOnly = true;
            this.betterTextBox_return.Rules = null;
            this.betterTextBox_return.Size = new System.Drawing.Size(102, 26);
            this.betterTextBox_return.TabIndex = 12;
            this.betterTextBox_return.textboxType = CustomControls.TextboxType.Decimal;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 565);
            this.Controls.Add(this.panel_fill);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_fill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.BetterListView betterListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.MaterialButton materialButton_refresh;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_fill;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private CustomControls.BetterTextBox betterTextBox_return;
        private System.Windows.Forms.Label label6;
        private CustomControls.BetterTextBox betterTextBox_dueamount;
        private System.Windows.Forms.Label label5;
        private CustomControls.BetterTextBox betterTextBox_paidamount;
        private System.Windows.Forms.Label label4;
        private CustomControls.BetterTextBox betterTextBox_nettotal;
        private System.Windows.Forms.Label label3;
        private CustomControls.BetterTextBox betterTextBox_tax;
        private System.Windows.Forms.Label label2;
        private CustomControls.BetterTextBox betterTextBox_discount;
        private System.Windows.Forms.Label label1;
        private CustomControls.BetterTextBox betterTextBox_grosstotal;
    }
}