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
            this.Feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Feedback
            // 
            this.Feedback.AutoSize = true;
            this.Feedback.Location = new System.Drawing.Point(497, 375);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(80, 20);
            this.Feedback.TabIndex = 0;
            this.Feedback.Text = "Feedback";
            // 
            // Page_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Feedback);
            this.Name = "Page_Feedback";
            this.Size = new System.Drawing.Size(1287, 907);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Feedback;
    }
}
