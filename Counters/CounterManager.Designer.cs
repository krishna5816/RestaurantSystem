namespace RestaurantSystem.Counters
{
    partial class CounterManager
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
            this.components = new System.ComponentModel.Container();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1_Add = new System.Windows.Forms.Label();
            this.betterTextBox_search = new CustomControls.BetterTextBox();
            this.materialButton_requests = new CustomControls.MaterialButton();
            this.materialButton_close = new CustomControls.MaterialButton();
            this.materialButton_addnew = new CustomControls.MaterialButton();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_fill = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_top.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.panel_fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel_top.Controls.Add(this.panel1);
            this.panel_top.Controls.Add(this.label1_Add);
            this.panel_top.Controls.Add(this.betterTextBox_search);
            this.panel_top.Controls.Add(this.materialButton_requests);
            this.panel_top.Controls.Add(this.materialButton_close);
            this.panel_top.Controls.Add(this.materialButton_addnew);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.ForeColor = System.Drawing.Color.White;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(840, 40);
            this.panel_top.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 1);
            this.panel1.TabIndex = 57;
            // 
            // label1_Add
            // 
            this.label1_Add.AutoSize = true;
            this.label1_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Add.ForeColor = System.Drawing.Color.White;
            this.label1_Add.Location = new System.Drawing.Point(48, 16);
            this.label1_Add.Name = "label1_Add";
            this.label1_Add.Size = new System.Drawing.Size(116, 17);
            this.label1_Add.TabIndex = 56;
            this.label1_Add.Text = "Manage Counters";
            // 
            // betterTextBox_search
            // 
            this.betterTextBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.betterTextBox_search.append = "";
            this.betterTextBox_search.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_search.intVal = 0;
            this.betterTextBox_search.Location = new System.Drawing.Point(619, 12);
            this.betterTextBox_search.Name = "betterTextBox_search";
            this.betterTextBox_search.prepend = "";
            this.betterTextBox_search.Rules = null;
            this.betterTextBox_search.Size = new System.Drawing.Size(217, 25);
            this.betterTextBox_search.TabIndex = 2;
            this.betterTextBox_search.textboxType = CustomControls.TextboxType.Text;
            this.betterTextBox_search.TextChanged += new System.EventHandler(this.betterTextBox_search_TextChanged);
            // 
            // materialButton_requests
            // 
            this.materialButton_requests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_requests.BackColor = System.Drawing.Color.Transparent;
            this.materialButton_requests.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_requests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_requests.FlatAppearance.BorderSize = 0;
            this.materialButton_requests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_requests.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_requests.fontIncrement = 0F;
            this.materialButton_requests.FontStyle = null;
            this.materialButton_requests.ForeColor = System.Drawing.Color.White;
            this.materialButton_requests.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_requests.hoverforefont = null;
            this.materialButton_requests.hoverimage = null;
            this.materialButton_requests.Location = new System.Drawing.Point(419, 9);
            this.materialButton_requests.Name = "materialButton_requests";
            this.materialButton_requests.role = 1;
            this.materialButton_requests.Size = new System.Drawing.Size(136, 27);
            this.materialButton_requests.TabIndex = 4;
            this.materialButton_requests.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_requests.tempforefont = null;
            this.materialButton_requests.Text = "Current Requests";
            this.materialButton_requests.Totext = null;
            this.materialButton_requests.userole = true;
            this.materialButton_requests.UseVisualStyleBackColor = false;
            this.materialButton_requests.Click += new System.EventHandler(this.materialButton_requests_Click);
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
            this.materialButton_close.Click += new System.EventHandler(this.materialButton_close_Click_1);
            // 
            // materialButton_addnew
            // 
            this.materialButton_addnew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_addnew.BackColor = System.Drawing.Color.Transparent;
            this.materialButton_addnew.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_addnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_addnew.FlatAppearance.BorderSize = 0;
            this.materialButton_addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_addnew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_addnew.fontIncrement = 0F;
            this.materialButton_addnew.FontStyle = null;
            this.materialButton_addnew.ForeColor = System.Drawing.Color.White;
            this.materialButton_addnew.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_addnew.hoverforefont = null;
            this.materialButton_addnew.hoverimage = null;
            this.materialButton_addnew.Location = new System.Drawing.Point(561, 11);
            this.materialButton_addnew.Name = "materialButton_addnew";
            this.materialButton_addnew.role = 1;
            this.materialButton_addnew.Size = new System.Drawing.Size(51, 27);
            this.materialButton_addnew.TabIndex = 3;
            this.materialButton_addnew.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_addnew.tempforefont = null;
            this.materialButton_addnew.Text = "Add";
            this.materialButton_addnew.Totext = null;
            this.materialButton_addnew.userole = true;
            this.materialButton_addnew.UseVisualStyleBackColor = false;
            this.materialButton_addnew.Click += new System.EventHandler(this.materialButton_addnew_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(98, 26);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // panel_fill
            // 
            this.panel_fill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_fill.Controls.Add(this.flowLayoutPanel);
            this.panel_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fill.Location = new System.Drawing.Point(0, 40);
            this.panel_fill.Name = "panel_fill";
            this.panel_fill.Size = new System.Drawing.Size(840, 456);
            this.panel_fill.TabIndex = 6;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(838, 454);
            this.flowLayoutPanel.TabIndex = 0;
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // CounterManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 496);
            this.Controls.Add(this.panel_fill);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CounterManager";
            this.Text = "f";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.panel_fill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private CustomControls.MaterialButton materialButton_addnew;
        private CustomControls.BetterTextBox betterTextBox_search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.Panel panel_fill;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private CustomControls.MaterialButton materialButton_requests;
        private CustomControls.MaterialButton materialButton_close;
        private System.Windows.Forms.Label label1_Add;
        private System.Windows.Forms.Panel panel1;
    }
}