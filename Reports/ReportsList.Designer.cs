﻿namespace RestaurantSystem.Reports
{
    partial class ReportsList
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1_Add = new System.Windows.Forms.Label();
            this.materialButton_close = new CustomControls.MaterialButton();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 493);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Purchase Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sales Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Expenses Report";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel_top.Controls.Add(this.panel1);
            this.panel_top.Controls.Add(this.label1_Add);
            this.panel_top.Controls.Add(this.materialButton_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.ForeColor = System.Drawing.Color.White;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(984, 40);
            this.panel_top.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 1);
            this.panel1.TabIndex = 57;
            // 
            // label1_Add
            // 
            this.label1_Add.AutoSize = true;
            this.label1_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Add.ForeColor = System.Drawing.Color.White;
            this.label1_Add.Location = new System.Drawing.Point(48, 12);
            this.label1_Add.Name = "label1_Add";
            this.label1_Add.Size = new System.Drawing.Size(75, 17);
            this.label1_Add.TabIndex = 56;
            this.label1_Add.Text = "Report List";
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
            // 
            // ReportsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 533);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsList";
            this.Load += new System.EventHandler(this.ReportsList_Load);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1_Add;
        private CustomControls.MaterialButton materialButton_close;
    }
}