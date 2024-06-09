namespace Manager_asm.AdminPages
{
    partial class frmAdminUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminUI));
            this.panelHeader1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblgogoat = new System.Windows.Forms.Label();
            this.picboxlogo = new System.Windows.Forms.PictureBox();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.panelHeader2 = new System.Windows.Forms.Panel();
            this.panelHeader1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).BeginInit();
            this.panelHeader2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader1
            // 
            this.panelHeader1.BackColor = System.Drawing.Color.Chocolate;
            this.panelHeader1.Controls.Add(this.btnLogout);
            this.panelHeader1.Controls.Add(this.lblAdmin);
            this.panelHeader1.Controls.Add(this.lblgogoat);
            this.panelHeader1.Controls.Add(this.picboxlogo);
            this.panelHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader1.ForeColor = System.Drawing.Color.Silver;
            this.panelHeader1.Location = new System.Drawing.Point(0, 0);
            this.panelHeader1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelHeader1.Name = "panelHeader1";
            this.panelHeader1.Size = new System.Drawing.Size(1522, 48);
            this.panelHeader1.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Chocolate;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1481, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 28);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.907515F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(1391, 18);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(41, 13);
            this.lblAdmin.TabIndex = 8;
            this.lblAdmin.Text = "Admin";
            // 
            // lblgogoat
            // 
            this.lblgogoat.AutoSize = true;
            this.lblgogoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgogoat.ForeColor = System.Drawing.Color.Snow;
            this.lblgogoat.Location = new System.Drawing.Point(731, 18);
            this.lblgogoat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgogoat.Name = "lblgogoat";
            this.lblgogoat.Size = new System.Drawing.Size(82, 17);
            this.lblgogoat.TabIndex = 0;
            this.lblgogoat.Text = "GO-GOAT";
            // 
            // picboxlogo
            // 
            this.picboxlogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxlogo.Image")));
            this.picboxlogo.Location = new System.Drawing.Point(24, 7);
            this.picboxlogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picboxlogo.Name = "picboxlogo";
            this.picboxlogo.Size = new System.Drawing.Size(82, 38);
            this.picboxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxlogo.TabIndex = 2;
            this.picboxlogo.TabStop = false;
            // 
            // btnSales
            // 
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.Chocolate;
            this.btnSales.Location = new System.Drawing.Point(567, 0);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(138, 48);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "Sales Report";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Chocolate;
            this.btnProfile.Location = new System.Drawing.Point(851, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(138, 48);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnFeedback
            // 
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.Chocolate;
            this.btnFeedback.Location = new System.Drawing.Point(711, 0);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(138, 48);
            this.btnFeedback.TabIndex = 1;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            // 
            // btnManage
            // 
            this.btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.Chocolate;
            this.btnManage.Location = new System.Drawing.Point(428, 0);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(138, 48);
            this.btnManage.TabIndex = 0;
            this.btnManage.Text = "Manage Users";
            this.btnManage.UseVisualStyleBackColor = true;
            // 
            // panelHeader2
            // 
            this.panelHeader2.Controls.Add(this.btnSales);
            this.panelHeader2.Controls.Add(this.btnProfile);
            this.panelHeader2.Controls.Add(this.btnFeedback);
            this.panelHeader2.Controls.Add(this.btnManage);
            this.panelHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader2.Location = new System.Drawing.Point(0, 48);
            this.panelHeader2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(1522, 38);
            this.panelHeader2.TabIndex = 8;
            // 
            // frmAdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 520);
            this.Controls.Add(this.panelHeader2);
            this.Controls.Add(this.panelHeader1);
            this.Name = "frmAdminUI";
            this.Text = "AdminMenu";
            this.panelHeader1.ResumeLayout(false);
            this.panelHeader1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).EndInit();
            this.panelHeader2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblgogoat;
        private System.Windows.Forms.PictureBox picboxlogo;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Panel panelHeader2;
    }
}