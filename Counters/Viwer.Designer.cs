namespace RestaurantSystem.Counters
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.materialButton_Edit = new CustomControls.MaterialButton();
            this.label_counter = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_dailyclosingamount = new System.Windows.Forms.Label();
            this.label_dailystockamount = new System.Windows.Forms.Label();
            this.label_dailyopeningamount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_dailyrequestedAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_dailystatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nepaliCalender = new CustomControls.NepaliCalender();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.materialButton_Edit);
            this.splitContainer.Panel1.Controls.Add(this.label_counter);
            this.splitContainer.Panel1.Controls.Add(this.pictureBox);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1MinSize = 50;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.label_dailyclosingamount);
            this.splitContainer.Panel2.Controls.Add(this.label_dailystockamount);
            this.splitContainer.Panel2.Controls.Add(this.label_dailyopeningamount);
            this.splitContainer.Panel2.Controls.Add(this.label8);
            this.splitContainer.Panel2.Controls.Add(this.label7);
            this.splitContainer.Panel2.Controls.Add(this.label5);
            this.splitContainer.Panel2.Controls.Add(this.label_dailyrequestedAmount);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.label_dailystatus);
            this.splitContainer.Panel2.Controls.Add(this.label6);
            this.splitContainer.Panel2.Controls.Add(this.nepaliCalender);
            this.splitContainer.Size = new System.Drawing.Size(240, 473);
            this.splitContainer.SplitterDistance = 106;
            this.splitContainer.TabIndex = 0;
            // 
            // materialButton_Edit
            // 
            this.materialButton_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialButton_Edit.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_Edit.FlatAppearance.BorderSize = 0;
            this.materialButton_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_Edit.fontIncrement = 0F;
            this.materialButton_Edit.FontStyle = null;
            this.materialButton_Edit.ForeColor = System.Drawing.Color.White;
            this.materialButton_Edit.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_Edit.hoverforefont = null;
            this.materialButton_Edit.hoverimage = null;
            this.materialButton_Edit.Location = new System.Drawing.Point(10, 64);
            this.materialButton_Edit.Name = "materialButton_Edit";
            this.materialButton_Edit.role = 0;
            this.materialButton_Edit.Size = new System.Drawing.Size(219, 29);
            this.materialButton_Edit.TabIndex = 9;
            this.materialButton_Edit.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_Edit.tempforefont = null;
            this.materialButton_Edit.Text = "Edit";
            this.materialButton_Edit.Totext = null;
            this.materialButton_Edit.userole = false;
            this.materialButton_Edit.UseVisualStyleBackColor = false;
            this.materialButton_Edit.Click += new System.EventHandler(this.materialButton_Edit_Click);
            // 
            // label_counter
            // 
            this.label_counter.AutoSize = true;
            this.label_counter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_counter.ForeColor = System.Drawing.Color.Black;
            this.label_counter.Location = new System.Drawing.Point(97, 22);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(82, 19);
            this.label_counter.TabIndex = 2;
            this.label_counter.Text = "CounterNo";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = global::RestaurantSystem.Properties.Resources.Rms_Connection_off;
            this.pictureBox.Location = new System.Drawing.Point(190, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(40, 40);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CounterNo";
            // 
            // label_dailyclosingamount
            // 
            this.label_dailyclosingamount.AutoSize = true;
            this.label_dailyclosingamount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dailyclosingamount.ForeColor = System.Drawing.Color.Black;
            this.label_dailyclosingamount.Location = new System.Drawing.Point(101, 242);
            this.label_dailyclosingamount.Name = "label_dailyclosingamount";
            this.label_dailyclosingamount.Size = new System.Drawing.Size(62, 19);
            this.label_dailyclosingamount.TabIndex = 14;
            this.label_dailyclosingamount.Text = "Amount";
            // 
            // label_dailystockamount
            // 
            this.label_dailystockamount.AutoSize = true;
            this.label_dailystockamount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dailystockamount.ForeColor = System.Drawing.Color.Black;
            this.label_dailystockamount.Location = new System.Drawing.Point(101, 193);
            this.label_dailystockamount.Name = "label_dailystockamount";
            this.label_dailystockamount.Size = new System.Drawing.Size(62, 19);
            this.label_dailystockamount.TabIndex = 13;
            this.label_dailystockamount.Text = "Amount";
            // 
            // label_dailyopeningamount
            // 
            this.label_dailyopeningamount.AutoSize = true;
            this.label_dailyopeningamount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dailyopeningamount.ForeColor = System.Drawing.Color.Black;
            this.label_dailyopeningamount.Location = new System.Drawing.Point(101, 142);
            this.label_dailyopeningamount.Name = "label_dailyopeningamount";
            this.label_dailyopeningamount.Size = new System.Drawing.Size(62, 19);
            this.label_dailyopeningamount.TabIndex = 12;
            this.label_dailyopeningamount.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(30, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 38);
            this.label8.TabIndex = 11;
            this.label8.Text = "Closing\r\nAmount\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(30, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 38);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stock\r\nAmount\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Opening\r\nAmount\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_dailyrequestedAmount
            // 
            this.label_dailyrequestedAmount.AutoSize = true;
            this.label_dailyrequestedAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dailyrequestedAmount.ForeColor = System.Drawing.Color.Black;
            this.label_dailyrequestedAmount.Location = new System.Drawing.Point(101, 96);
            this.label_dailyrequestedAmount.Name = "label_dailyrequestedAmount";
            this.label_dailyrequestedAmount.Size = new System.Drawing.Size(62, 19);
            this.label_dailyrequestedAmount.TabIndex = 8;
            this.label_dailyrequestedAmount.Text = "Amount";
            this.label_dailyrequestedAmount.Click += new System.EventHandler(this.label_dailyrequestedAmount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Requested\r\nAmount\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_dailystatus
            // 
            this.label_dailystatus.AutoSize = true;
            this.label_dailystatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dailystatus.ForeColor = System.Drawing.Color.Black;
            this.label_dailystatus.Location = new System.Drawing.Point(101, 55);
            this.label_dailystatus.Name = "label_dailystatus";
            this.label_dailystatus.Size = new System.Drawing.Size(47, 19);
            this.label_dailystatus.TabIndex = 6;
            this.label_dailystatus.Text = "status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(43, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nepaliCalender
            // 
            this.nepaliCalender.BackColor = System.Drawing.Color.White;
            this.nepaliCalender.Datestamp = 20760803;
            this.nepaliCalender.DateTime = new System.DateTime(2019, 11, 19, 0, 0, 0, 0);
            this.nepaliCalender.Location = new System.Drawing.Point(12, 8);
            this.nepaliCalender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nepaliCalender.Name = "nepaliCalender";
            this.nepaliCalender.Size = new System.Drawing.Size(219, 31);
            this.nepaliCalender.TabIndex = 0;
            this.nepaliCalender.dateChange += new CustomControls.NepaliCalender.dateChangeHandler(this.nepaliCalender_dateChange);
            // 
            // Viwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Viwer";
            this.Size = new System.Drawing.Size(240, 473);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label label_counter;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private CustomControls.MaterialButton materialButton_Edit;
        private System.Windows.Forms.Label label_dailyclosingamount;
        private System.Windows.Forms.Label label_dailystockamount;
        private System.Windows.Forms.Label label_dailyopeningamount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_dailystatus;
        private System.Windows.Forms.Label label6;
        private CustomControls.NepaliCalender nepaliCalender;
        private System.Windows.Forms.Label label_dailyrequestedAmount;
        private System.Windows.Forms.Label label4;
    }
}
