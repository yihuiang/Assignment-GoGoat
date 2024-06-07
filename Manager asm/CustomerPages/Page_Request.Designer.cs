namespace Manager_asm.CustomerPages
{
    partial class Page_Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Request));
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picRequest = new System.Windows.Forms.PictureBox();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.cmbPax = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvReserve = new System.Windows.Forms.ListView();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaShell;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2045, 138);
            this.panel5.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(934, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Indoor Dining",
            "Outdoor Dining"});
            this.cmbType.Location = new System.Drawing.Point(336, 403);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(156, 28);
            this.cmbType.TabIndex = 37;
            this.cmbType.Text = "Indoor Dine-in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 405);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 351);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Pax:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06936F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 58);
            this.label7.TabIndex = 32;
            this.label7.Text = "BOOK\r\nRESERVATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date:";
            // 
            // picRequest
            // 
            this.picRequest.Image = ((System.Drawing.Image)(resources.GetObject("picRequest.Image")));
            this.picRequest.Location = new System.Drawing.Point(518, 439);
            this.picRequest.Margin = new System.Windows.Forms.Padding(2);
            this.picRequest.Name = "picRequest";
            this.picRequest.Size = new System.Drawing.Size(91, 64);
            this.picRequest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRequest.TabIndex = 25;
            this.picRequest.TabStop = false;
            this.picRequest.Click += new System.EventHandler(this.pictureBoxAdd_Click);
            // 
            // datepicker
            // 
            this.datepicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker.Location = new System.Drawing.Point(332, 296);
            this.datepicker.MaxDate = new System.DateTime(2025, 6, 4, 0, 0, 0, 0);
            this.datepicker.MinDate = new System.DateTime(2024, 6, 4, 0, 0, 0, 0);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(226, 26);
            this.datepicker.TabIndex = 38;
            this.datepicker.Value = new System.DateTime(2024, 6, 4, 0, 0, 0, 0);
            // 
            // cmbPax
            // 
            this.cmbPax.FormattingEnabled = true;
            this.cmbPax.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbPax.Location = new System.Drawing.Point(336, 351);
            this.cmbPax.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPax.Name = "cmbPax";
            this.cmbPax.Size = new System.Drawing.Size(156, 28);
            this.cmbPax.TabIndex = 40;
            this.cmbPax.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06936F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(970, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 58);
            this.label1.TabIndex = 41;
            this.label1.Text = "VIEW\r\nRESERVATION";
            // 
            // lvReserve
            // 
            this.lvReserve.BackColor = System.Drawing.Color.SeaShell;
            this.lvReserve.HideSelection = false;
            this.lvReserve.Location = new System.Drawing.Point(975, 303);
            this.lvReserve.Name = "lvReserve";
            this.lvReserve.Size = new System.Drawing.Size(926, 475);
            this.lvReserve.TabIndex = 43;
            this.lvReserve.UseCompatibleStateImageBehavior = false;
            // 
            // Page_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lvReserve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPax);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picRequest);
            this.Controls.Add(this.panel5);
            this.Name = "Page_Request";
            this.Size = new System.Drawing.Size(2045, 844);
            this.Load += new System.EventHandler(this.Page_Request_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picRequest;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.ComboBox cmbPax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvReserve;
    }
}
