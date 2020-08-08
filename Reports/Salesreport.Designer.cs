namespace RestaurantSystem.Reports
{
    partial class Salesreport
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
            this.label_totalmargin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_sales_billWise = new System.Windows.Forms.RadioButton();
            this.checkBox_types = new System.Windows.Forms.CheckBox();
            this.radioButton__sales_single = new System.Windows.Forms.RadioButton();
            this.radioButton_sales_group = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_categories = new System.Windows.Forms.ListBox();
            this.comboBox_sales_week = new System.Windows.Forms.ComboBox();
            this.comboBox_sales = new System.Windows.Forms.ComboBox();
            this.button_load = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_totalamount = new System.Windows.Forms.Label();
            this.nepaliCalender_start = new CustomControls.NepaliCalender();
            this.nepaliCalender_End = new CustomControls.NepaliCalender();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_totalmargin
            // 
            this.label_totalmargin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_totalmargin.AutoSize = true;
            this.label_totalmargin.Location = new System.Drawing.Point(308, 498);
            this.label_totalmargin.Name = "label_totalmargin";
            this.label_totalmargin.Size = new System.Drawing.Size(13, 13);
            this.label_totalmargin.TabIndex = 32;
            this.label_totalmargin.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Total Margin:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nepaliCalender_End);
            this.panel2.Controls.Add(this.nepaliCalender_start);
            this.panel2.Controls.Add(this.radioButton_sales_billWise);
            this.panel2.Controls.Add(this.checkBox_types);
            this.panel2.Controls.Add(this.radioButton__sales_single);
            this.panel2.Controls.Add(this.radioButton_sales_group);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listBox_categories);
            this.panel2.Controls.Add(this.comboBox_sales_week);
            this.panel2.Controls.Add(this.comboBox_sales);
            this.panel2.Location = new System.Drawing.Point(4, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 138);
            this.panel2.TabIndex = 26;
            // 
            // radioButton_sales_billWise
            // 
            this.radioButton_sales_billWise.AutoSize = true;
            this.radioButton_sales_billWise.Location = new System.Drawing.Point(214, 6);
            this.radioButton_sales_billWise.Name = "radioButton_sales_billWise";
            this.radioButton_sales_billWise.Size = new System.Drawing.Size(62, 17);
            this.radioButton_sales_billWise.TabIndex = 11;
            this.radioButton_sales_billWise.Text = "BillWise";
            this.radioButton_sales_billWise.UseVisualStyleBackColor = true;
            // 
            // checkBox_types
            // 
            this.checkBox_types.AutoSize = true;
            this.checkBox_types.Location = new System.Drawing.Point(450, 8);
            this.checkBox_types.Name = "checkBox_types";
            this.checkBox_types.Size = new System.Drawing.Size(91, 17);
            this.checkBox_types.TabIndex = 10;
            this.checkBox_types.Text = "CustomSelect";
            this.checkBox_types.UseVisualStyleBackColor = true;
            // 
            // radioButton__sales_single
            // 
            this.radioButton__sales_single.AutoSize = true;
            this.radioButton__sales_single.Location = new System.Drawing.Point(129, 6);
            this.radioButton__sales_single.Name = "radioButton__sales_single";
            this.radioButton__sales_single.Size = new System.Drawing.Size(69, 17);
            this.radioButton__sales_single.TabIndex = 8;
            this.radioButton__sales_single.Text = "ItemWise";
            this.radioButton__sales_single.UseVisualStyleBackColor = true;
            // 
            // radioButton_sales_group
            // 
            this.radioButton_sales_group.AutoSize = true;
            this.radioButton_sales_group.Checked = true;
            this.radioButton_sales_group.Location = new System.Drawing.Point(12, 7);
            this.radioButton_sales_group.Name = "radioButton_sales_group";
            this.radioButton_sales_group.Size = new System.Drawing.Size(96, 17);
            this.radioButton_sales_group.TabIndex = 7;
            this.radioButton_sales_group.TabStop = true;
            this.radioButton_sales_group.Text = "Company Wise";
            this.radioButton_sales_group.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Report Type";
            // 
            // listBox_categories
            // 
            this.listBox_categories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_categories.Enabled = false;
            this.listBox_categories.FormattingEnabled = true;
            this.listBox_categories.Location = new System.Drawing.Point(450, 39);
            this.listBox_categories.Name = "listBox_categories";
            this.listBox_categories.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_categories.Size = new System.Drawing.Size(219, 82);
            this.listBox_categories.TabIndex = 6;
            // 
            // comboBox_sales_week
            // 
            this.comboBox_sales_week.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sales_week.FormattingEnabled = true;
            this.comboBox_sales_week.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Fifth"});
            this.comboBox_sales_week.Location = new System.Drawing.Point(248, 68);
            this.comboBox_sales_week.Name = "comboBox_sales_week";
            this.comboBox_sales_week.Size = new System.Drawing.Size(192, 21);
            this.comboBox_sales_week.TabIndex = 5;
            this.comboBox_sales_week.Visible = false;
            // 
            // comboBox_sales
            // 
            this.comboBox_sales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sales.FormattingEnabled = true;
            this.comboBox_sales.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly",
            "Custom"});
            this.comboBox_sales.Location = new System.Drawing.Point(102, 36);
            this.comboBox_sales.Name = "comboBox_sales";
            this.comboBox_sales.Size = new System.Drawing.Size(338, 21);
            this.comboBox_sales.TabIndex = 2;
            this.comboBox_sales.SelectedIndexChanged += new System.EventHandler(this.comboBox_sales_SelectedIndexChanged);
            // 
            // button_load
            // 
            this.button_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_load.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_load.Location = new System.Drawing.Point(5, 4);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(77, 30);
            this.button_load.TabIndex = 0;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            // 
            // button_export
            // 
            this.button_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_export.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_export.Location = new System.Drawing.Point(5, 39);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(77, 30);
            this.button_export.TabIndex = 3;
            this.button_export.Text = "Export";
            this.button_export.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Total Amount:";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 154);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(892, 335);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button_export);
            this.panel3.Controls.Add(this.button_Reset);
            this.panel3.Controls.Add(this.button_load);
            this.panel3.Location = new System.Drawing.Point(685, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 138);
            this.panel3.TabIndex = 27;
            // 
            // button_Reset
            // 
            this.button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_Reset.Location = new System.Drawing.Point(88, 4);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(77, 30);
            this.button_Reset.TabIndex = 1;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            // 
            // label_totalamount
            // 
            this.label_totalamount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_totalamount.AutoSize = true;
            this.label_totalamount.Location = new System.Drawing.Point(112, 498);
            this.label_totalamount.Name = "label_totalamount";
            this.label_totalamount.Size = new System.Drawing.Size(13, 13);
            this.label_totalamount.TabIndex = 30;
            this.label_totalamount.Text = "0";
            // 
            // nepaliCalender_start
            // 
            this.nepaliCalender_start.BackColor = System.Drawing.Color.White;
            this.nepaliCalender_start.Datestamp = 20770424;
            this.nepaliCalender_start.DateTime = new System.DateTime(2020, 8, 8, 0, 0, 0, 0);
            this.nepaliCalender_start.Location = new System.Drawing.Point(12, 63);
            this.nepaliCalender_start.Name = "nepaliCalender_start";
            this.nepaliCalender_start.Size = new System.Drawing.Size(195, 28);
            this.nepaliCalender_start.TabIndex = 12;
            // 
            // nepaliCalender_End
            // 
            this.nepaliCalender_End.BackColor = System.Drawing.Color.White;
            this.nepaliCalender_End.Datestamp = 20770424;
            this.nepaliCalender_End.DateTime = new System.DateTime(2020, 8, 8, 0, 0, 0, 0);
            this.nepaliCalender_End.Location = new System.Drawing.Point(12, 97);
            this.nepaliCalender_End.Name = "nepaliCalender_End";
            this.nepaliCalender_End.Size = new System.Drawing.Size(195, 28);
            this.nepaliCalender_End.TabIndex = 13;
            // 
            // Salesreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_totalmargin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label_totalamount);
            this.Name = "Salesreport";
            this.Size = new System.Drawing.Size(900, 520);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_totalmargin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.NepaliCalender nepaliCalender_End;
        private CustomControls.NepaliCalender nepaliCalender_start;
        private System.Windows.Forms.RadioButton radioButton_sales_billWise;
        private System.Windows.Forms.CheckBox checkBox_types;
        private System.Windows.Forms.RadioButton radioButton__sales_single;
        private System.Windows.Forms.RadioButton radioButton_sales_group;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBox_categories;
        private System.Windows.Forms.ComboBox comboBox_sales_week;
        private System.Windows.Forms.ComboBox comboBox_sales;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label_totalamount;
    }
}
