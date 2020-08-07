namespace RestaurantSystem.Counters
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
            this.label1 = new System.Windows.Forms.Label();
            this.betterTextBox_counterno = new CustomControls.BetterTextBox();
            this.materialButton_addnew = new CustomControls.MaterialButton();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Size = new System.Drawing.Size(94, 19);
            this.label_title.Text = "Add Counter";
            // 
            // panel_Divider
            // 
            this.panel_Divider.Size = new System.Drawing.Size(212, 2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Counter No";
            // 
            // betterTextBox_counterno
            // 
            this.betterTextBox_counterno.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_counterno.intVal = 0;
            this.betterTextBox_counterno.Location = new System.Drawing.Point(6, 81);
            this.betterTextBox_counterno.Name = "betterTextBox_counterno";
            this.betterTextBox_counterno.Size = new System.Drawing.Size(193, 25);
            this.betterTextBox_counterno.TabIndex = 4;
            this.betterTextBox_counterno.textboxType = CustomControls.TextboxType.Text;
            // 
            // materialButton_addnew
            // 
            this.materialButton_addnew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_addnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialButton_addnew.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_addnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_addnew.FlatAppearance.BorderSize = 0;
            this.materialButton_addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_addnew.fontIncrement = 0F;
            this.materialButton_addnew.FontStyle = null;
            this.materialButton_addnew.ForeColor = System.Drawing.Color.White;
            this.materialButton_addnew.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_addnew.hoverforefont = null;
            this.materialButton_addnew.hoverimage = null;
            this.materialButton_addnew.Location = new System.Drawing.Point(86, 112);
            this.materialButton_addnew.Name = "materialButton_addnew";
            this.materialButton_addnew.role = 0;
            this.materialButton_addnew.Size = new System.Drawing.Size(113, 29);
            this.materialButton_addnew.TabIndex = 8;
            this.materialButton_addnew.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_addnew.tempforefont = null;
            this.materialButton_addnew.Text = "Add";
            this.materialButton_addnew.Totext = null;
            this.materialButton_addnew.userole = false;
            this.materialButton_addnew.UseVisualStyleBackColor = false;
            this.materialButton_addnew.Click += new System.EventHandler(this.materialButton_addnew_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(213, 150);
            this.Controls.Add(this.materialButton_addnew);
            this.Controls.Add(this.betterTextBox_counterno);
            this.Controls.Add(this.label1);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Counter";
            this.Save += new CustomControls.MaterialForm.Actions(this.AddCounter_Save);
            this.Controls.SetChildIndex(this.label_title, 0);
            this.Controls.SetChildIndex(this.panel_Divider, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.betterTextBox_counterno, 0);
            this.Controls.SetChildIndex(this.materialButton_addnew, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.BetterTextBox betterTextBox_counterno;
        private CustomControls.MaterialButton materialButton_addnew;
    }
}
