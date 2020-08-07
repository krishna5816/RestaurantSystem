namespace RestaurantSystem.PurchaseItems
{
    partial class Add
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
            this.betterTextBox_name = new CustomControls.BetterTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_cate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.betterTextBox_currentstock = new CustomControls.BetterTextBox();
            this.materialButton1 = new CustomControls.MaterialButton();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Size = new System.Drawing.Size(37, 19);
            this.label_title.Text = "Add";
            // 
            // panel_Divider
            // 
            this.panel_Divider.Size = new System.Drawing.Size(435, 2);
            // 
            // betterTextBox_name
            // 
            this.betterTextBox_name.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_name.intVal = 0;
            this.betterTextBox_name.Location = new System.Drawing.Point(12, 80);
            this.betterTextBox_name.Name = "betterTextBox_name";
            this.betterTextBox_name.Size = new System.Drawing.Size(412, 25);
            this.betterTextBox_name.TabIndex = 3;
            this.betterTextBox_name.textboxType = CustomControls.TextboxType.Text;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "NAME";
            // 
            // comboBox_cate
            // 
            this.comboBox_cate.FormattingEnabled = true;
            this.comboBox_cate.Location = new System.Drawing.Point(12, 131);
            this.comboBox_cate.Name = "comboBox_cate";
            this.comboBox_cate.Size = new System.Drawing.Size(412, 25);
            this.comboBox_cate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "CATEGORY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 8;
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
            this.betterTextBox_currentstock.Location = new System.Drawing.Point(12, 179);
            this.betterTextBox_currentstock.Name = "betterTextBox_currentstock";
            this.betterTextBox_currentstock.Size = new System.Drawing.Size(412, 25);
            this.betterTextBox_currentstock.TabIndex = 7;
            this.betterTextBox_currentstock.textboxType = CustomControls.TextboxType.Text;
            // 
            // materialButton1
            // 
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton1.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.fontIncrement = 0F;
            this.materialButton1.FontStyle = null;
            this.materialButton1.ForeColor = System.Drawing.Color.White;
            this.materialButton1.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton1.hoverforefont = null;
            this.materialButton1.hoverimage = null;
            this.materialButton1.Location = new System.Drawing.Point(334, 210);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.role = 0;
            this.materialButton1.Size = new System.Drawing.Size(90, 30);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton1.tempforefont = null;
            this.materialButton1.Text = "SAVE";
            this.materialButton1.Totext = null;
            this.materialButton1.userole = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(436, 248);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.betterTextBox_currentstock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_cate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betterTextBox_name);
            this.Name = "Add";
            this.Controls.SetChildIndex(this.label_title, 0);
            this.Controls.SetChildIndex(this.panel_Divider, 0);
            this.Controls.SetChildIndex(this.betterTextBox_name, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboBox_cate, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.betterTextBox_currentstock, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.materialButton1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.BetterTextBox betterTextBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_cate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.BetterTextBox betterTextBox_currentstock;
        private CustomControls.MaterialButton materialButton1;
    }
}
