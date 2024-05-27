namespace Manager_asm.Pages
{
    partial class Page_Report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblreservation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.reservationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.reservationDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.popularTimeSlotLabel = new System.Windows.Forms.Label();
            this.cancellationCountLabel = new System.Windows.Forms.Label();
            this.printReportButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.lblreservation);
            this.panel1.Location = new System.Drawing.Point(596, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 108);
            this.panel1.TabIndex = 9;
            // 
            // lblreservation
            // 
            this.lblreservation.AutoSize = true;
            this.lblreservation.Font = new System.Drawing.Font("Montserrat SemiBold", 14.15029F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreservation.ForeColor = System.Drawing.Color.Black;
            this.lblreservation.Location = new System.Drawing.Point(26, 28);
            this.lblreservation.Name = "lblreservation";
            this.lblreservation.Size = new System.Drawing.Size(429, 47);
            this.lblreservation.TabIndex = 2;
            this.lblreservation.Text = "RESERVATION REPORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(814, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Month: ";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(900, 239);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(233, 32);
            this.monthComboBox.TabIndex = 11;
            // 
            // reservationTypeComboBox
            // 
            this.reservationTypeComboBox.FormattingEnabled = true;
            this.reservationTypeComboBox.Location = new System.Drawing.Point(1495, 240);
            this.reservationTypeComboBox.Name = "reservationTypeComboBox";
            this.reservationTypeComboBox.Size = new System.Drawing.Size(233, 32);
            this.reservationTypeComboBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1281, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Reservation Type:";
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(900, 308);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(233, 32);
            this.customerComboBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(771, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Customer:";
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(1536, 308);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(192, 48);
            this.generateReportButton.TabIndex = 16;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // reservationDataGridView
            // 
            this.reservationDataGridView.BackgroundColor = System.Drawing.Color.SeaShell;
            this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGridView.Location = new System.Drawing.Point(596, 399);
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.RowHeadersWidth = 74;
            this.reservationDataGridView.RowTemplate.Height = 31;
            this.reservationDataGridView.Size = new System.Drawing.Size(1324, 625);
            this.reservationDataGridView.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(780, 1089);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Most Popular Time Slot:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(780, 1147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Number of Cancellation:";
            // 
            // popularTimeSlotLabel
            // 
            this.popularTimeSlotLabel.AutoSize = true;
            this.popularTimeSlotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popularTimeSlotLabel.Location = new System.Drawing.Point(1084, 1091);
            this.popularTimeSlotLabel.Name = "popularTimeSlotLabel";
            this.popularTimeSlotLabel.Size = new System.Drawing.Size(0, 29);
            this.popularTimeSlotLabel.TabIndex = 20;
            // 
            // cancellationCountLabel
            // 
            this.cancellationCountLabel.AutoSize = true;
            this.cancellationCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancellationCountLabel.Location = new System.Drawing.Point(1084, 1149);
            this.cancellationCountLabel.Name = "cancellationCountLabel";
            this.cancellationCountLabel.Size = new System.Drawing.Size(0, 29);
            this.cancellationCountLabel.TabIndex = 21;
            // 
            // printReportButton
            // 
            this.printReportButton.Location = new System.Drawing.Point(1782, 1080);
            this.printReportButton.Name = "printReportButton";
            this.printReportButton.Size = new System.Drawing.Size(122, 50);
            this.printReportButton.TabIndex = 22;
            this.printReportButton.Text = "Print";
            this.printReportButton.UseVisualStyleBackColor = true;
            this.printReportButton.Click += new System.EventHandler(this.printReportButton_Click);
            // 
            // Page_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.printReportButton);
            this.Controls.Add(this.cancellationCountLabel);
            this.Controls.Add(this.popularTimeSlotLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reservationDataGridView);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reservationTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Page_Report";
            this.Size = new System.Drawing.Size(2500, 1246);
            this.Load += new System.EventHandler(this.Page_Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblreservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox reservationTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.DataGridView reservationDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label popularTimeSlotLabel;
        private System.Windows.Forms.Label cancellationCountLabel;
        private System.Windows.Forms.Button printReportButton;
    }
}
