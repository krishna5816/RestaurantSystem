namespace RestaurantSystem.PurchaseItems
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
            this.materialButton_save = new CustomControls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.betterTextBox_currentstock = new CustomControls.BetterTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_cate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.betterTextBox_name = new CustomControls.BetterTextBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Size = new System.Drawing.Size(34, 19);
            this.label_title.Text = "Edit";
            // 
            // panel_Divider
            // 
            this.panel_Divider.Size = new System.Drawing.Size(437, 2);
            // 
            // materialButton_save
            // 
            this.materialButton_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_save.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_save.FlatAppearance.BorderSize = 0;
            this.materialButton_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_save.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_save.fontIncrement = 0F;
            this.materialButton_save.FontStyle = null;
            this.materialButton_save.ForeColor = System.Drawing.Color.White;
            this.materialButton_save.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_save.hoverforefont = null;
            this.materialButton_save.hoverimage = null;
            this.materialButton_save.Location = new System.Drawing.Point(334, 208);
            this.materialButton_save.Name = "materialButton_save";
            this.materialButton_save.role = 0;
            this.materialButton_save.Size = new System.Drawing.Size(90, 30);
            this.materialButton_save.TabIndex = 16;
            this.materialButton_save.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_save.tempforefont = null;
            this.materialButton_save.Text = "Update";
            this.materialButton_save.Totext = null;
            this.materialButton_save.userole = false;
            this.materialButton_save.UseVisualStyleBackColor = false;
            this.materialButton_save.Click += new System.EventHandler(this.materialButton_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "CURRENT STOCK";
            // 
            // betterTextBox_currentstock
            // 
            this.betterTextBox_currentstock.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_currentstock.intVal = 0;
            this.betterTextBox_currentstock.Location = new System.Drawing.Point(12, 177);
            this.betterTextBox_currentstock.Name = "betterTextBox_currentstock";
            this.betterTextBox_currentstock.Size = new System.Drawing.Size(412, 25);
            this.betterTextBox_currentstock.TabIndex = 14;
            this.betterTextBox_currentstock.textboxType = CustomControls.TextboxType.Text;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "CATEGORY";
            // 
            // comboBox_cate
            // 
            this.comboBox_cate.FormattingEnabled = true;
            this.comboBox_cate.Location = new System.Drawing.Point(12, 129);
            this.comboBox_cate.Name = "comboBox_cate";
            this.comboBox_cate.Size = new System.Drawing.Size(412, 25);
            this.comboBox_cate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "NAME";
            // 
            // betterTextBox_name
            // 
            this.betterTextBox_name.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_name.intVal = 0;
            this.betterTextBox_name.Location = new System.Drawing.Point(12, 78);
            this.betterTextBox_name.Name = "betterTextBox_name";
            this.betterTextBox_name.Size = new System.Drawing.Size(412, 25);
            this.betterTextBox_name.TabIndex = 10;
            this.betterTextBox_name.textboxType = CustomControls.TextboxType.Text;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(438, 252);
            this.Controls.Add(this.materialButton_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.betterTextBox_currentstock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_cate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betterTextBox_name);
            this.Name = "Edit";
            this.Controls.SetChildIndex(this.label_title, 0);
            this.Controls.SetChildIndex(this.panel_Divider, 0);
            this.Controls.SetChildIndex(this.betterTextBox_name, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboBox_cate, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.betterTextBox_currentstock, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.materialButton_save, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.MaterialButton materialButton_save;
        private System.Windows.Forms.Label label3;
        private CustomControls.BetterTextBox betterTextBox_currentstock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_cate;
        private System.Windows.Forms.Label label1;
        private CustomControls.BetterTextBox betterTextBox_name;
    }
}
