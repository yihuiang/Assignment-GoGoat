namespace Manager_asm.CustomerPages
{
    partial class Page_Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Orders));
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaShell;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2045, 138);
            this.panel5.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(934, 33);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.BackgroundColor = System.Drawing.Color.SeaShell;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Location = new System.Drawing.Point(497, 258);
            this.orderDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 74;
            this.orderDataGridView.RowTemplate.Height = 31;
            this.orderDataGridView.Size = new System.Drawing.Size(1083, 521);
            this.orderDataGridView.TabIndex = 18;
            // 
            // Page_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.panel5);
            this.Name = "Page_Orders";
            this.Size = new System.Drawing.Size(2045, 844);
            this.Load += new System.EventHandler(this.Page_Orders_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView orderDataGridView;
    }
}
