namespace Manager_asm
{
    partial class Page_MenuCatalog_AddItem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnbrowseimg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxCat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbrowseimg
            // 
            this.btnbrowseimg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowseimg.Location = new System.Drawing.Point(119, 571);
            this.btnbrowseimg.Name = "btnbrowseimg";
            this.btnbrowseimg.Size = new System.Drawing.Size(284, 56);
            this.btnbrowseimg.TabIndex = 1;
            this.btnbrowseimg.Text = "Browse Image";
            this.btnbrowseimg.UseVisualStyleBackColor = true;
            this.btnbrowseimg.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Name:";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(489, 225);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(372, 29);
            this.txtboxName.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 92);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06936F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(394, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "ADD ITEM";
            // 
            // txtboxCat
            // 
            this.txtboxCat.Location = new System.Drawing.Point(489, 345);
            this.txtboxCat.Name = "txtboxCat";
            this.txtboxCat.Size = new System.Drawing.Size(372, 29);
            this.txtboxCat.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(86, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtboxprice
            // 
            this.txtboxprice.Location = new System.Drawing.Point(489, 469);
            this.txtboxprice.Name = "txtboxprice";
            this.txtboxprice.Size = new System.Drawing.Size(372, 29);
            this.txtboxprice.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(570, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Page_MenuCatalog_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 693);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtboxprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbrowseimg);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Page_MenuCatalog_AddItem";
            this.Text = "ADD ITEM";
            this.Load += new System.EventHandler(this.Page_MenuCatalog_AddItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnbrowseimg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}