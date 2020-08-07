namespace RestaurantSystem.Category
{
    partial class Viwer
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
            this.materialButton1 = new CustomControls.MaterialButton();
            this.materialButton2 = new CustomControls.MaterialButton();
            this.betterTextBox1 = new CustomControls.BetterTextBox();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton1.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.fontIncrement = 0F;
            this.materialButton1.FontStyle = null;
            this.materialButton1.ForeColor = System.Drawing.Color.White;
            this.materialButton1.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton1.hoverforefont = null;
            this.materialButton1.hoverimage = null;
            this.materialButton1.Location = new System.Drawing.Point(374, 8);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.role = 0;
            this.materialButton1.Size = new System.Drawing.Size(93, 32);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton1.tempforefont = null;
            this.materialButton1.Text = "DELETE";
            this.materialButton1.Totext = null;
            this.materialButton1.userole = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton2.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton2.FlatAppearance.BorderSize = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.fontIncrement = 0F;
            this.materialButton2.FontStyle = null;
            this.materialButton2.ForeColor = System.Drawing.Color.White;
            this.materialButton2.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton2.hoverforefont = null;
            this.materialButton2.hoverimage = null;
            this.materialButton2.Location = new System.Drawing.Point(264, 8);
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.role = 0;
            this.materialButton2.Size = new System.Drawing.Size(93, 32);
            this.materialButton2.TabIndex = 2;
            this.materialButton2.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton2.tempforefont = null;
            this.materialButton2.Text = "SAVE";
            this.materialButton2.Totext = null;
            this.materialButton2.userole = false;
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // betterTextBox1
            // 
            this.betterTextBox1.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox1.intVal = 0;
            this.betterTextBox1.Location = new System.Drawing.Point(3, 12);
            this.betterTextBox1.Name = "betterTextBox1";
            this.betterTextBox1.Size = new System.Drawing.Size(255, 26);
            this.betterTextBox1.TabIndex = 3;
            this.betterTextBox1.textboxType = CustomControls.TextboxType.Text;
            this.betterTextBox1.TextChanged += new System.EventHandler(this.betterTextBox1_TextChanged);
            this.betterTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.betterTextBox1_KeyPress);
            // 
            // Viwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.betterTextBox1);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Viwer";
            this.Size = new System.Drawing.Size(481, 44);
            this.Load += new System.EventHandler(this.Viwer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.MaterialButton materialButton1;
        private CustomControls.MaterialButton materialButton2;
        private CustomControls.BetterTextBox betterTextBox1;
    }
}
