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
            this.lblItemPrice1 = new System.Windows.Forms.Label();
            this.lblItemName1 = new System.Windows.Forms.Label();
            this.picboxItemimg1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxItemimg1)).BeginInit();
            this.SuspendLayout();
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
            // 
            // picboxItemimg1
            // 
            this.picboxItemimg1.Location = new System.Drawing.Point(40, 36);
            this.picboxItemimg1.Margin = new System.Windows.Forms.Padding(2);
            this.picboxItemimg1.Name = "picboxItemimg1";
            this.picboxItemimg1.Size = new System.Drawing.Size(234, 247);
            this.picboxItemimg1.TabIndex = 0;
            this.picboxItemimg1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Manager_asm.Properties.Resources.addbutton;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(196, 350);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 42);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Manager_asm.Properties.Resources.deletebutton;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(238, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 42);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblItemPrice1);
            this.Controls.Add(this.lblItemName1);
            this.Controls.Add(this.picboxItemimg1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "btnitem";
            this.Size = new System.Drawing.Size(317, 412);
            this.Load += new System.EventHandler(this.btnitem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxItemimg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picboxItemimg1;
        public System.Windows.Forms.Label lblItemPrice1;
        public System.Windows.Forms.Label lblItemName1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}
