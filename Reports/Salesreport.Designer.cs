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
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox_categories = new System.Windows.Forms.ListBox();
            this.button_load = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_totalamount = new System.Windows.Forms.Label();
            this.rangeSelector = new CustomControls.RangeSelector();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listBox_categories);
            this.panel2.Controls.Add(this.rangeSelector);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 520);
            this.panel2.TabIndex = 26;
            // 
            // listBox_categories
            // 
            this.listBox_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_categories.Enabled = false;
            this.listBox_categories.FormattingEnabled = true;
            this.listBox_categories.Items.AddRange(new object[] {
            "All"});
            this.listBox_categories.Location = new System.Drawing.Point(0, 200);
            this.listBox_categories.Name = "listBox_categories";
            this.listBox_categories.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_categories.Size = new System.Drawing.Size(378, 277);
            this.listBox_categories.TabIndex = 6;
            this.listBox_categories.SelectedIndexChanged += new System.EventHandler(this.listBox_categories_SelectedIndexChanged);
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
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_export
            // 
            this.button_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_export.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_export.Location = new System.Drawing.Point(171, 4);
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
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(900, 520);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button_export);
            this.panel3.Controls.Add(this.button_Reset);
            this.panel3.Controls.Add(this.button_load);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 41);
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
            this.rangeSelector.Load += new System.EventHandler(this.rangeSelector1_Load);
            // 
            // Salesreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_totalamount);
            this.Name = "Salesreport";
            this.Size = new System.Drawing.Size(900, 520);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListBox listBox_categories;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label_totalamount;
        private CustomControls.RangeSelector rangeSelector;
    }
}
