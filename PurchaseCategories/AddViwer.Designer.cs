namespace RestaurantSystem.PurchaseCategories
{
    partial class AddViwer
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
            this.betterTextBox_name = new CustomControls.BetterTextBox();
            this.materialButton_save = new CustomControls.MaterialButton();
            this.materialButton_delete = new CustomControls.MaterialButton();
            this.SuspendLayout();
            // 
            // betterTextBox_name
            // 
            this.betterTextBox_name.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_name.intVal = 0;
            this.betterTextBox_name.Location = new System.Drawing.Point(5, 11);
            this.betterTextBox_name.Name = "betterTextBox_name";
            this.betterTextBox_name.Size = new System.Drawing.Size(255, 23);
            this.betterTextBox_name.TabIndex = 6;
            this.betterTextBox_name.textboxType = CustomControls.TextboxType.Text;
            // 
            // materialButton_save
            // 
            this.materialButton_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_save.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_save.FlatAppearance.BorderSize = 0;
            this.materialButton_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_save.fontIncrement = 0F;
            this.materialButton_save.FontStyle = null;
            this.materialButton_save.ForeColor = System.Drawing.Color.White;
            this.materialButton_save.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_save.hoverforefont = null;
            this.materialButton_save.hoverimage = null;
            this.materialButton_save.Location = new System.Drawing.Point(270, 8);
            this.materialButton_save.Name = "materialButton_save";
            this.materialButton_save.role = 0;
            this.materialButton_save.Size = new System.Drawing.Size(93, 25);
            this.materialButton_save.TabIndex = 5;
            this.materialButton_save.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_save.tempforefont = null;
            this.materialButton_save.Text = "SAVE";
            this.materialButton_save.Totext = null;
            this.materialButton_save.userole = false;
            this.materialButton_save.UseVisualStyleBackColor = false;
            this.materialButton_save.Click += new System.EventHandler(this.materialButton_save_Click);
            // 
            // materialButton_delete
            // 
            this.materialButton_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_delete.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_delete.FlatAppearance.BorderSize = 0;
            this.materialButton_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_delete.fontIncrement = 0F;
            this.materialButton_delete.FontStyle = null;
            this.materialButton_delete.ForeColor = System.Drawing.Color.White;
            this.materialButton_delete.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_delete.hoverforefont = null;
            this.materialButton_delete.hoverimage = null;
            this.materialButton_delete.Location = new System.Drawing.Point(375, 8);
            this.materialButton_delete.Name = "materialButton_delete";
            this.materialButton_delete.role = 0;
            this.materialButton_delete.Size = new System.Drawing.Size(93, 25);
            this.materialButton_delete.TabIndex = 4;
            this.materialButton_delete.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_delete.tempforefont = null;
            this.materialButton_delete.Text = "DELETE";
            this.materialButton_delete.Totext = null;
            this.materialButton_delete.userole = false;
            this.materialButton_delete.UseVisualStyleBackColor = false;
            // 
            // AddViwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.betterTextBox_name);
            this.Controls.Add(this.materialButton_save);
            this.Controls.Add(this.materialButton_delete);
            this.Name = "AddViwer";
            this.Size = new System.Drawing.Size(473, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.BetterTextBox betterTextBox_name;
        private CustomControls.MaterialButton materialButton_save;
        private CustomControls.MaterialButton materialButton_delete;
    }
}
