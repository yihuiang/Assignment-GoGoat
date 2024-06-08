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
            this.picboxItemimg1.Location = new System.Drawing.Point(40, 36);
            this.picboxItemimg1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picboxItemimg1.Name = "picboxItemimg1";
            this.picboxItemimg1.Size = new System.Drawing.Size(234, 247);
            this.picboxItemimg1.TabIndex = 0;
            this.picboxItemimg1.TabStop = false;
            this.picboxItemimg1.Click += new System.EventHandler(this.btnitem_Click);
            // 
            // lblItemPrice1
            // 
            this.lblItemPrice1.AutoSize = true;
            this.lblItemPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice1.Location = new System.Drawing.Point(43, 367);
            this.lblItemPrice1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemPrice1.Name = "lblItemPrice1";
            this.lblItemPrice1.Size = new System.Drawing.Size(61, 25);
            this.lblItemPrice1.TabIndex = 3;
            this.lblItemPrice1.Text = "00.00";
            this.lblItemPrice1.Click += new System.EventHandler(this.btnitem_Click);
            // 
            // lblItemName1
            // 
            this.lblItemName1.AutoSize = true;
            this.lblItemName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName1.Location = new System.Drawing.Point(43, 300);
            this.lblItemName1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName1.Name = "lblItemName1";
            this.lblItemName1.Size = new System.Drawing.Size(106, 25);
            this.lblItemName1.TabIndex = 1;
            this.lblItemName1.Text = "Item Name";
            this.lblItemName1.Click += new System.EventHandler(this.btnitem_Click);
            // 
            // btnitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblItemPrice1);
            this.Controls.Add(this.lblItemName1);
            this.Controls.Add(this.picboxItemimg1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "btnitem";
            this.Size = new System.Drawing.Size(317, 412);
            this.Load += new System.EventHandler(this.btnitem_Load);
            this.Click += new System.EventHandler(this.btnitem_Click);
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
