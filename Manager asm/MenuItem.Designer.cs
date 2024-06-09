namespace Manager_asm
{
    partial class btnitem
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
            this.picboxItemimg1 = new System.Windows.Forms.PictureBox();
            this.lblItemPrice1 = new System.Windows.Forms.Label();
            this.lblItemName1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxItemimg1)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxItemimg1
            // 
            this.picboxItemimg1.Location = new System.Drawing.Point(49, 43);
            this.picboxItemimg1.Name = "picboxItemimg1";
            this.picboxItemimg1.Size = new System.Drawing.Size(286, 296);
            this.picboxItemimg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxItemimg1.TabIndex = 0;
            this.picboxItemimg1.TabStop = false;
            // 
            // lblItemPrice1
            // 
            this.lblItemPrice1.AutoSize = true;
            this.lblItemPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice1.Location = new System.Drawing.Point(53, 440);
            this.lblItemPrice1.Name = "lblItemPrice1";
            this.lblItemPrice1.Size = new System.Drawing.Size(71, 29);
            this.lblItemPrice1.TabIndex = 3;
            this.lblItemPrice1.Text = "00.00";
            // 
            // lblItemName1
            // 
            this.lblItemName1.AutoSize = true;
            this.lblItemName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName1.Location = new System.Drawing.Point(53, 360);
            this.lblItemName1.Name = "lblItemName1";
            this.lblItemName1.Size = new System.Drawing.Size(130, 29);
            this.lblItemName1.TabIndex = 1;
            this.lblItemName1.Text = "Item Name";
            // 
            // btnitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblItemPrice1);
            this.Controls.Add(this.lblItemName1);
            this.Controls.Add(this.picboxItemimg1);
            this.Name = "btnitem";
            this.Size = new System.Drawing.Size(386, 492);
            this.Load += new System.EventHandler(this.btnitem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxItemimg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picboxItemimg1;
        public System.Windows.Forms.Label lblItemPrice1;
        public System.Windows.Forms.Label lblItemName1;
    }
}
