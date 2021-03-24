namespace RestaurantSystem.Wastage
{
    partial class Manu
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
            this.label1_Add = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton_close = new CustomControls.MaterialButton();
            this.label_totalamount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_purchaseitems = new CustomControls.MaterialButton();
            this.btn_menuitems = new CustomControls.MaterialButton();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1_Add
            // 
            this.label1_Add.AutoSize = true;
            this.label1_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Add.ForeColor = System.Drawing.Color.White;
            this.label1_Add.Location = new System.Drawing.Point(48, 12);
            this.label1_Add.Name = "label1_Add";
            this.label1_Add.Size = new System.Drawing.Size(98, 17);
            this.label1_Add.TabIndex = 56;
            this.label1_Add.Text = "Wastage Items";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel_top.Controls.Add(this.panel1);
            this.panel_top.Controls.Add(this.label1_Add);
            this.panel_top.Controls.Add(this.materialButton_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_top.ForeColor = System.Drawing.Color.White;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(800, 40);
            this.panel_top.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1);
            this.panel1.TabIndex = 57;
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
            // label_totalamount
            // 
            this.label_totalamount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_totalamount.AutoSize = true;
            this.label_totalamount.Location = new System.Drawing.Point(112, 453);
            this.label_totalamount.Name = "label_totalamount";
            this.label_totalamount.Size = new System.Drawing.Size(13, 13);
            this.label_totalamount.TabIndex = 40;
            this.label_totalamount.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Total Amount:";
            // 
            // btn_purchaseitems
            // 
            this.btn_purchaseitems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_purchaseitems.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.btn_purchaseitems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_purchaseitems.FlatAppearance.BorderSize = 0;
            this.btn_purchaseitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchaseitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchaseitems.fontIncrement = 0F;
            this.btn_purchaseitems.FontStyle = null;
            this.btn_purchaseitems.ForeColor = System.Drawing.Color.White;
            this.btn_purchaseitems.hoverforecolor = System.Drawing.Color.Empty;
            this.btn_purchaseitems.hoverforefont = null;
            this.btn_purchaseitems.hoverimage = null;
            this.btn_purchaseitems.Location = new System.Drawing.Point(12, 61);
            this.btn_purchaseitems.Name = "btn_purchaseitems";
            this.btn_purchaseitems.role = 0;
            this.btn_purchaseitems.Size = new System.Drawing.Size(178, 69);
            this.btn_purchaseitems.TabIndex = 59;
            this.btn_purchaseitems.tempforecolor = System.Drawing.Color.Empty;
            this.btn_purchaseitems.tempforefont = null;
            this.btn_purchaseitems.Text = "Wastage Purchase Item";
            this.btn_purchaseitems.Totext = null;
            this.btn_purchaseitems.userole = false;
            this.btn_purchaseitems.UseVisualStyleBackColor = false;
            this.btn_purchaseitems.Click += new System.EventHandler(this.btn_purchaseitems_Click);
            // 
            // btn_menuitems
            // 
            this.btn_menuitems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_menuitems.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.btn_menuitems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menuitems.FlatAppearance.BorderSize = 0;
            this.btn_menuitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuitems.fontIncrement = 0F;
            this.btn_menuitems.FontStyle = null;
            this.btn_menuitems.ForeColor = System.Drawing.Color.White;
            this.btn_menuitems.hoverforecolor = System.Drawing.Color.Empty;
            this.btn_menuitems.hoverforefont = null;
            this.btn_menuitems.hoverimage = null;
            this.btn_menuitems.Location = new System.Drawing.Point(209, 61);
            this.btn_menuitems.Name = "btn_menuitems";
            this.btn_menuitems.role = 0;
            this.btn_menuitems.Size = new System.Drawing.Size(178, 69);
            this.btn_menuitems.TabIndex = 60;
            this.btn_menuitems.tempforecolor = System.Drawing.Color.Empty;
            this.btn_menuitems.tempforefont = null;
            this.btn_menuitems.Text = "Wastage Menuitems";
            this.btn_menuitems.Totext = null;
            this.btn_menuitems.userole = false;
            this.btn_menuitems.UseVisualStyleBackColor = false;
            this.btn_menuitems.Click += new System.EventHandler(this.btn_menuitems_Click);
            // 
            // Manu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_menuitems);
            this.Controls.Add(this.btn_purchaseitems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_totalamount);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manu";
            this.Text = "Manu";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1_Add;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.MaterialButton materialButton_close;
        private System.Windows.Forms.Label label_totalamount;
        private System.Windows.Forms.Label label2;
        private CustomControls.MaterialButton btn_purchaseitems;
        private CustomControls.MaterialButton btn_menuitems;
    }
}