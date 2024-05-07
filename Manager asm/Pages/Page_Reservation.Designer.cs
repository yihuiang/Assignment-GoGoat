namespace Manager_asm.Pages
{
    partial class Page_Reservation
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
            this.lblreser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblreser
            // 
            this.lblreser.AutoSize = true;
            this.lblreser.Location = new System.Drawing.Point(562, 295);
            this.lblreser.Name = "lblreser";
            this.lblreser.Size = new System.Drawing.Size(109, 24);
            this.lblreser.TabIndex = 0;
            this.lblreser.Text = "Reservation";
            // 
            // Page_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblreser);
            this.Name = "Page_Reservation";
            this.Size = new System.Drawing.Size(1328, 623);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblreser;
    }
}
