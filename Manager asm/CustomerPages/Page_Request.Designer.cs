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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPax = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.picRequest = new System.Windows.Forms.PictureBox();
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.cmbPax = new System.Windows.Forms.ComboBox();
            this.lblView = new System.Windows.Forms.Label();
            this.dataReserve = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReserve)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SeaShell;
            this.panelHeader.Controls.Add(this.picboxLogo);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(2045, 138);
            this.panelHeader.TabIndex = 20;
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxLogo.Image")));
            this.picboxLogo.Location = new System.Drawing.Point(934, 33);
            this.picboxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(146, 76);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 0;
            this.picboxLogo.TabStop = false;
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
            // lblPax
            // 
            this.lblPax.AutoSize = true;
            this.lblPax.Location = new System.Drawing.Point(270, 351);
            this.lblPax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPax.Name = "lblPax";
            this.lblPax.Size = new System.Drawing.Size(39, 20);
            this.lblPax.TabIndex = 33;
            this.lblPax.Text = "Pax:";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06936F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(269, 206);
            this.lblBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(203, 58);
            this.lblBook.TabIndex = 32;
            this.lblBook.Text = "BOOK\r\nRESERVATION";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(266, 303);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date:";
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
            // datetimepicker
            // 
            this.datetimepicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepicker.Location = new System.Drawing.Point(332, 296);
            this.datetimepicker.MaxDate = new System.DateTime(2025, 6, 4, 0, 0, 0, 0);
            this.datetimepicker.MinDate = new System.DateTime(2024, 6, 4, 0, 0, 0, 0);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(226, 26);
            this.datetimepicker.TabIndex = 38;
            this.datetimepicker.Value = new System.DateTime(2024, 6, 4, 0, 0, 0, 0);
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
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06936F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(970, 206);
            this.lblView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(203, 58);
            this.lblView.TabIndex = 41;
            this.lblView.Text = "VIEW\r\nRESERVATION";
            // 
            // dataReserve
            // 
            this.dataReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReserve.Location = new System.Drawing.Point(975, 296);
            this.dataReserve.Name = "dataReserve";
            this.dataReserve.RowHeadersWidth = 62;
            this.dataReserve.RowTemplate.Height = 28;
            this.dataReserve.Size = new System.Drawing.Size(710, 497);
            this.dataReserve.TabIndex = 42;
            // 
            // Page_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataReserve);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.cmbPax);
            this.Controls.Add(this.datetimepicker);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPax);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.picRequest);
            this.Controls.Add(this.panelHeader);
            this.Name = "Page_Request";
            this.Size = new System.Drawing.Size(2045, 844);
            this.Load += new System.EventHandler(this.Page_Request_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReserve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPax;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox picRequest;
        private System.Windows.Forms.DateTimePicker datetimepicker;
        private System.Windows.Forms.ComboBox cmbPax;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.DataGridView dataReserve;
    }
}
