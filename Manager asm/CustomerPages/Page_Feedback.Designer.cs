namespace Manager_asm.CustomerPages
{
    partial class Page_Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Feedback));
            this.panelPageHeader = new System.Windows.Forms.Panel();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.panelFeedback = new System.Windows.Forms.Panel();
            this.panelPageHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPageHeader
            // 
            this.panelPageHeader.BackColor = System.Drawing.Color.SeaShell;
            this.panelPageHeader.Controls.Add(this.picboxLogo);
            this.panelPageHeader.Location = new System.Drawing.Point(0, 0);
            this.panelPageHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelPageHeader.Name = "panelPageHeader";
            this.panelPageHeader.Size = new System.Drawing.Size(2045, 138);
            this.panelPageHeader.TabIndex = 16;
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
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(133, 308);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(221, 56);
            this.btnReservation.TabIndex = 19;
            this.btnReservation.Text = "Reservation Survey";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(133, 218);
            this.btnFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(221, 63);
            this.btnFood.TabIndex = 18;
            this.btnFood.Text = "Food Survey";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // panelFeedback
            // 
            this.panelFeedback.Location = new System.Drawing.Point(584, 218);
            this.panelFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.panelFeedback.Name = "panelFeedback";
            this.panelFeedback.Size = new System.Drawing.Size(939, 624);
            this.panelFeedback.TabIndex = 17;
            // 
            // Page_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelPageHeader);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.panelFeedback);
            this.Name = "Page_Feedback";
            this.Size = new System.Drawing.Size(2045, 844);
            this.panelPageHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPageHeader;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Panel panelFeedback;
    }
}
