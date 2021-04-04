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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton_refresh = new CustomControls.MaterialButton();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_fill = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_fill.SuspendLayout();
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
            this.betterListView.Size = new System.Drawing.Size(910, 457);
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
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 68);
            this.panel2.TabIndex = 1;
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
    }
}