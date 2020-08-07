namespace RestaurantSystem.Party
{
    partial class party_viwer
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
            this.btn_delete = new CustomControls.MaterialButton();
            this.materialButton_details = new CustomControls.MaterialButton();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.btn_edit = new CustomControls.MaterialButton();
            this.label_pan = new System.Windows.Forms.Label();
            this.label_due = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.fontIncrement = 0F;
            this.btn_delete.FontStyle = null;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.hoverforecolor = System.Drawing.Color.Empty;
            this.btn_delete.hoverforefont = null;
            this.btn_delete.hoverimage = null;
            this.btn_delete.Location = new System.Drawing.Point(860, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.role = 0;
            this.btn_delete.Size = new System.Drawing.Size(83, 20);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.tempforecolor = System.Drawing.Color.Empty;
            this.btn_delete.tempforefont = null;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.Totext = null;
            this.btn_delete.userole = false;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // materialButton_details
            // 
            this.materialButton_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.materialButton_details.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_details.FlatAppearance.BorderSize = 0;
            this.materialButton_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_details.fontIncrement = 0F;
            this.materialButton_details.FontStyle = null;
            this.materialButton_details.ForeColor = System.Drawing.Color.White;
            this.materialButton_details.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_details.hoverforefont = null;
            this.materialButton_details.hoverimage = null;
            this.materialButton_details.Location = new System.Drawing.Point(771, 5);
            this.materialButton_details.Name = "materialButton_details";
            this.materialButton_details.role = 0;
            this.materialButton_details.Size = new System.Drawing.Size(83, 20);
            this.materialButton_details.TabIndex = 7;
            this.materialButton_details.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_details.tempforefont = null;
            this.materialButton_details.Text = "DETAILS\r\n";
            this.materialButton_details.Totext = null;
            this.materialButton_details.userole = false;
            this.materialButton_details.UseVisualStyleBackColor = false;
            this.materialButton_details.Click += new System.EventHandler(this.materialButton_details_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_name.Location = new System.Drawing.Point(4, 6);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(227, 15);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "mmmmmmmmmmmmmmmmmmmm";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_address.Location = new System.Drawing.Point(236, 6);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(147, 15);
            this.lbl_address.TabIndex = 1;
            this.lbl_address.Text = "aaaaaaaaaaaaaaaaaaaa";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_phone.Location = new System.Drawing.Point(385, 6);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(91, 15);
            this.lbl_phone.TabIndex = 2;
            this.lbl_phone.Text = "999999999999";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_edit.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.fontIncrement = 0F;
            this.btn_edit.FontStyle = null;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.hoverforecolor = System.Drawing.Color.Empty;
            this.btn_edit.hoverforefont = null;
            this.btn_edit.hoverimage = null;
            this.btn_edit.Location = new System.Drawing.Point(694, 5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.role = 0;
            this.btn_edit.Size = new System.Drawing.Size(69, 20);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.tempforecolor = System.Drawing.Color.Empty;
            this.btn_edit.tempforefont = null;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.Totext = null;
            this.btn_edit.userole = false;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label_pan
            // 
            this.label_pan.AutoSize = true;
            this.label_pan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_pan.Location = new System.Drawing.Point(477, 6);
            this.label_pan.Name = "label_pan";
            this.label_pan.Size = new System.Drawing.Size(112, 15);
            this.label_pan.TabIndex = 8;
            this.label_pan.Text = "999999999999999";
            // 
            // label_due
            // 
            this.label_due.AutoSize = true;
            this.label_due.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_due.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_due.Location = new System.Drawing.Point(595, 5);
            this.label_due.Name = "label_due";
            this.label_due.Size = new System.Drawing.Size(91, 15);
            this.label_due.TabIndex = 9;
            this.label_due.Text = "999999999999";
            // 
            // party_viwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label_due);
            this.Controls.Add(this.label_pan);
            this.Controls.Add(this.materialButton_details);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.Name = "party_viwer";
            this.Size = new System.Drawing.Size(961, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.MaterialButton btn_delete;
        private CustomControls.MaterialButton materialButton_details;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_phone;
        private CustomControls.MaterialButton btn_edit;
        private System.Windows.Forms.Label label_pan;
        private System.Windows.Forms.Label label_due;
    }
}
