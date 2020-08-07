namespace RestaurantSystem.Setting.DayManagement
{
    partial class CounterRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_counterno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.materialButton_accecptAmount = new CustomControls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.betterTextBox_accecpted = new CustomControls.BetterTextBox();
            this.materialButton_cancel = new CustomControls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "#Req ID";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(108, 12);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(45, 19);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "label2";
            // 
            // label_counterno
            // 
            this.label_counterno.AutoSize = true;
            this.label_counterno.Location = new System.Drawing.Point(296, 9);
            this.label_counterno.Name = "label_counterno";
            this.label_counterno.Size = new System.Drawing.Size(45, 19);
            this.label_counterno.TabIndex = 3;
            this.label_counterno.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Counter No";
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(108, 44);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(45, 19);
            this.label_amount.TabIndex = 5;
            this.label_amount.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Req Amount";
            // 
            // materialButton_accecptAmount
            // 
            this.materialButton_accecptAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialButton_accecptAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_accecptAmount.FlatAppearance.BorderSize = 0;
            this.materialButton_accecptAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_accecptAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_accecptAmount.ForeColor = System.Drawing.Color.White;
            this.materialButton_accecptAmount.Location = new System.Drawing.Point(144, 88);
            this.materialButton_accecptAmount.Name = "materialButton_accecptAmount";
            this.materialButton_accecptAmount.role = 0;
            this.materialButton_accecptAmount.Size = new System.Drawing.Size(146, 31);
            this.materialButton_accecptAmount.TabIndex = 6;
            this.materialButton_accecptAmount.Text = "Accept";
            this.materialButton_accecptAmount.Totext = null;
            this.materialButton_accecptAmount.userole = false;
            this.materialButton_accecptAmount.UseVisualStyleBackColor = false;
            this.materialButton_accecptAmount.Click += new System.EventHandler(this.materialButton_accecptAmount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Accepted\r\nAmount\r\n";
            // 
            // betterTextBox_accecpted
            // 
            this.betterTextBox_accecpted.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_accecpted.intVal = 0;
            this.betterTextBox_accecpted.Location = new System.Drawing.Point(296, 38);
            this.betterTextBox_accecpted.Name = "betterTextBox_accecpted";
            this.betterTextBox_accecpted.Size = new System.Drawing.Size(146, 25);
            this.betterTextBox_accecpted.TabIndex = 8;
            this.betterTextBox_accecpted.textboxType = CustomControls.TextboxType.Decimal;
            // 
            // materialButton_cancel
            // 
            this.materialButton_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.materialButton_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_cancel.FlatAppearance.BorderSize = 0;
            this.materialButton_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_cancel.ForeColor = System.Drawing.Color.White;
            this.materialButton_cancel.Location = new System.Drawing.Point(300, 88);
            this.materialButton_cancel.Name = "materialButton_cancel";
            this.materialButton_cancel.role = 0;
            this.materialButton_cancel.Size = new System.Drawing.Size(146, 31);
            this.materialButton_cancel.TabIndex = 9;
            this.materialButton_cancel.Text = "Cancel";
            this.materialButton_cancel.Totext = null;
            this.materialButton_cancel.userole = false;
            this.materialButton_cancel.UseVisualStyleBackColor = false;
            this.materialButton_cancel.Click += new System.EventHandler(this.materialButton_cancel_Click);
            // 
            // CounterRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.materialButton_cancel);
            this.Controls.Add(this.betterTextBox_accecpted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialButton_accecptAmount);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_counterno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CounterRequest";
            this.Size = new System.Drawing.Size(452, 125);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_counterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label6;
        private CustomControls.MaterialButton materialButton_accecptAmount;
        private System.Windows.Forms.Label label2;
        private CustomControls.BetterTextBox betterTextBox_accecpted;
        private CustomControls.MaterialButton materialButton_cancel;
    }
}
