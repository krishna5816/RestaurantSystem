namespace RestaurantSystem.IssueKitchen
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
            this.rangeSelector = new CustomControls.RangeSelector();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_grouping = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_export = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.betterListView1 = new CustomControls.BetterListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label_totalamount = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.materialButton_issuestock = new CustomControls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1_Add = new System.Windows.Forms.Label();
            this.materialButton_close = new CustomControls.MaterialButton();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // rangeSelector
            // 
            this.rangeSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.rangeSelector.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeSelector.fYViwers = null;
            this.rangeSelector.Location = new System.Drawing.Point(0, 0);
            this.rangeSelector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rangeSelector.Name = "rangeSelector";
            this.rangeSelector.Size = new System.Drawing.Size(378, 200);
            this.rangeSelector.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.rangeSelector);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 471);
            this.panel2.TabIndex = 38;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.comboBox_grouping);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 56);
            this.panel4.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(6, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Group Result By";
            // 
            // comboBox_grouping
            // 
            this.comboBox_grouping.FormattingEnabled = true;
            this.comboBox_grouping.Items.AddRange(new object[] {
            "none",
            "Item Wise Report",
            "Category Wise Report"});
            this.comboBox_grouping.Location = new System.Drawing.Point(8, 28);
            this.comboBox_grouping.Name = "comboBox_grouping";
            this.comboBox_grouping.Size = new System.Drawing.Size(365, 21);
            this.comboBox_grouping.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button_export);
            this.panel3.Controls.Add(this.button_Reset);
            this.panel3.Controls.Add(this.button_load);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 428);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 41);
            this.panel3.TabIndex = 27;
            // 
            // button_export
            // 
            this.button_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_export.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_export.Location = new System.Drawing.Point(171, 4);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(77, 30);
            this.button_export.TabIndex = 3;
            this.button_export.Text = "Export";
            this.button_export.UseVisualStyleBackColor = true;
            // 
            // button_Reset
            // 
            this.button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_Reset.Location = new System.Drawing.Point(88, 4);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(77, 30);
            this.button_Reset.TabIndex = 1;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_load
            // 
            this.button_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_load.Location = new System.Drawing.Point(5, 4);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(77, 30);
            this.button_load.TabIndex = 0;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // betterListView1
            // 
            this.betterListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betterListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterListView1.FullRowSelect = true;
            this.betterListView1.GridLines = true;
            this.betterListView1.HideSelection = false;
            this.betterListView1.Location = new System.Drawing.Point(380, 40);
            this.betterListView1.Name = "betterListView1";
            this.betterListView1.Size = new System.Drawing.Size(440, 471);
            this.betterListView1.sortable = false;
            this.betterListView1.TabIndex = 41;
            this.betterListView1.UseCompatibleStateImageBehavior = false;
            this.betterListView1.View = System.Windows.Forms.View.Details;
            this.betterListView1.SelectedIndexChanged += new System.EventHandler(this.betterListView1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Total Amount:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_totalamount
            // 
            this.label_totalamount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_totalamount.AutoSize = true;
            this.label_totalamount.Location = new System.Drawing.Point(112, 468);
            this.label_totalamount.Name = "label_totalamount";
            this.label_totalamount.Size = new System.Drawing.Size(13, 13);
            this.label_totalamount.TabIndex = 40;
            this.label_totalamount.Text = "0";
            this.label_totalamount.Click += new System.EventHandler(this.label_totalamount_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel_top.Controls.Add(this.materialButton_issuestock);
            this.panel_top.Controls.Add(this.panel1);
            this.panel_top.Controls.Add(this.label1_Add);
            this.panel_top.Controls.Add(this.materialButton_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_top.ForeColor = System.Drawing.Color.White;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(820, 40);
            this.panel_top.TabIndex = 42;
            // 
            // materialButton_issuestock
            // 
            this.materialButton_issuestock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_issuestock.BackColor = System.Drawing.Color.Blue;
            this.materialButton_issuestock.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_issuestock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_issuestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_issuestock.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_issuestock.fontIncrement = 0F;
            this.materialButton_issuestock.FontStyle = null;
            this.materialButton_issuestock.ForeColor = System.Drawing.Color.White;
            this.materialButton_issuestock.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_issuestock.hoverforefont = null;
            this.materialButton_issuestock.hoverimage = null;
            this.materialButton_issuestock.Location = new System.Drawing.Point(706, 6);
            this.materialButton_issuestock.Name = "materialButton_issuestock";
            this.materialButton_issuestock.role = 0;
            this.materialButton_issuestock.Size = new System.Drawing.Size(102, 30);
            this.materialButton_issuestock.TabIndex = 58;
            this.materialButton_issuestock.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_issuestock.tempforefont = null;
            this.materialButton_issuestock.Text = "Issue Stock";
            this.materialButton_issuestock.Totext = null;
            this.materialButton_issuestock.userole = false;
            this.materialButton_issuestock.UseVisualStyleBackColor = false;
            this.materialButton_issuestock.Click += new System.EventHandler(this.materialButton_issuestock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 1);
            this.panel1.TabIndex = 57;
            // 
            // label1_Add
            // 
            this.label1_Add.AutoSize = true;
            this.label1_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Add.ForeColor = System.Drawing.Color.White;
            this.label1_Add.Location = new System.Drawing.Point(48, 12);
            this.label1_Add.Name = "label1_Add";
            this.label1_Add.Size = new System.Drawing.Size(188, 17);
            this.label1_Add.TabIndex = 56;
            this.label1_Add.Text = "Kitchen Items Issued Recored";
            // 
            // materialButton_close
            // 
            this.materialButton_close.BackgroundImage = global::RestaurantSystem.Properties.Resources.back_64x64;
            this.materialButton_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialButton_close.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_close.FlatAppearance.BorderSize = 0;
            this.materialButton_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_close.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_close.fontIncrement = 0F;
            this.materialButton_close.FontStyle = null;
            this.materialButton_close.ForeColor = System.Drawing.Color.White;
            this.materialButton_close.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_close.hoverforefont = null;
            this.materialButton_close.hoverimage = null;
            this.materialButton_close.Location = new System.Drawing.Point(7, 6);
            this.materialButton_close.Name = "materialButton_close";
            this.materialButton_close.role = 0;
            this.materialButton_close.Size = new System.Drawing.Size(30, 30);
            this.materialButton_close.TabIndex = 5;
            this.materialButton_close.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_close.tempforefont = null;
            this.materialButton_close.Totext = null;
            this.materialButton_close.userole = false;
            this.materialButton_close.UseVisualStyleBackColor = true;
            this.materialButton_close.Click += new System.EventHandler(this.materialButton_close_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 511);
            this.Controls.Add(this.betterListView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_totalamount);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "List";
            this.Text = "List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RangeSelector rangeSelector;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox comboBox_grouping;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_load;
        private CustomControls.BetterListView betterListView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_totalamount;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1_Add;
        private CustomControls.MaterialButton materialButton_close;
        private CustomControls.MaterialButton materialButton_issuestock;
    }
}