namespace Manager_asm.Pages
{
    partial class Page_PI_Profile_Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06936F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(359, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 29);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(359, 235);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(170, 29);
            this.txtPhoneNum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Number:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(359, 304);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(170, 29);
            this.txtAddress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(294, 405);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(195, 49);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // Page_PI_Profile_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(823, 486);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Page_PI_Profile_Edit";
            this.Text = "Edit Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Page_PI_Profile_Edit_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}