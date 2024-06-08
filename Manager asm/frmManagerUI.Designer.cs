namespace Manager_asm
{
    partial class FrmManagerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagerUI));
            this.lblgogoat = new System.Windows.Forms.Label();
            this.panelHeader1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.lblmanager = new System.Windows.Forms.Label();
            this.picboxlogo = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnreservation = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.panelHeader2 = new System.Windows.Forms.Panel();
            this.btnmenucat = new System.Windows.Forms.Button();
            this.btnprofile = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).BeginInit();
            this.panelHeader2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.lblgogoat.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelHeader1
            // 
            this.panelHeader1.BackColor = System.Drawing.Color.Chocolate;
            this.panelHeader1.Controls.Add(this.btnlogout);
            this.panelHeader1.Controls.Add(this.lblmanager);
            this.panelHeader1.Controls.Add(this.lblgogoat);
            this.panelHeader1.Controls.Add(this.picboxlogo);
            this.panelHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader1.ForeColor = System.Drawing.Color.Silver;
            this.panelHeader1.Location = new System.Drawing.Point(0, 0);
            this.panelHeader1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelHeader1.Name = "panelHeader1";
            this.panelHeader1.Size = new System.Drawing.Size(1481, 48);
            this.panelHeader1.TabIndex = 6;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Chocolate;
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(1481, 11);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(74, 28);
            this.btnlogout.TabIndex = 9;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblmanager
            // 
            this.lblmanager.AutoSize = true;
            this.lblmanager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.907515F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanager.ForeColor = System.Drawing.Color.White;
            this.lblmanager.Location = new System.Drawing.Point(1391, 18);
            this.lblmanager.Name = "lblmanager";
            this.lblmanager.Size = new System.Drawing.Size(56, 13);
            this.lblmanager.TabIndex = 8;
            this.lblmanager.Text = "Manager";
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
            // btnMenu
            // 
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Chocolate;
            this.btnMenu.Location = new System.Drawing.Point(428, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(138, 48);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click);
            this.btnMenu.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            // 
            // btnreservation
            // 
            this.btnreservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreservation.ForeColor = System.Drawing.Color.Chocolate;
            this.btnreservation.Location = new System.Drawing.Point(711, 0);
            this.btnreservation.Name = "btnreservation";
            this.btnreservation.Size = new System.Drawing.Size(138, 48);
            this.btnreservation.TabIndex = 1;
            this.btnreservation.Text = "Reservation";
            this.btnreservation.UseVisualStyleBackColor = true;
            this.btnreservation.Click += new System.EventHandler(this.btnreservation_Click);
            this.btnreservation.MouseEnter += new System.EventHandler(this.btnreservation_MouseEnter);
            this.btnreservation.MouseLeave += new System.EventHandler(this.btnreservation_MouseLeave);
            // 
            // btnreport
            // 
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.Chocolate;
            this.btnreport.Location = new System.Drawing.Point(851, 0);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(138, 48);
            this.btnreport.TabIndex = 2;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // panelHeader2
            // 
            this.panelHeader2.Controls.Add(this.btnmenucat);
            this.panelHeader2.Controls.Add(this.btnprofile);
            this.panelHeader2.Controls.Add(this.btnreport);
            this.panelHeader2.Controls.Add(this.btnreservation);
            this.panelHeader2.Controls.Add(this.btnMenu);
            this.panelHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader2.Location = new System.Drawing.Point(0, 48);
            this.panelHeader2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(1481, 38);
            this.panelHeader2.TabIndex = 7;
            // 
            // btnmenucat
            // 
            this.btnmenucat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenucat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenucat.ForeColor = System.Drawing.Color.Chocolate;
            this.btnmenucat.Location = new System.Drawing.Point(567, 0);
            this.btnmenucat.Name = "btnmenucat";
            this.btnmenucat.Size = new System.Drawing.Size(138, 48);
            this.btnmenucat.TabIndex = 4;
            this.btnmenucat.Text = "Menu Catalog";
            this.btnmenucat.UseVisualStyleBackColor = true;
            this.btnmenucat.Click += new System.EventHandler(this.btneditproduct_Click);
            // 
            // btnprofile
            // 
            this.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofile.ForeColor = System.Drawing.Color.Chocolate;
            this.btnprofile.Location = new System.Drawing.Point(991, 0);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(138, 48);
            this.btnprofile.TabIndex = 3;
            this.btnprofile.Text = "Profile";
            this.btnprofile.UseVisualStyleBackColor = true;
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 86);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1481, 646);
            this.panelContainer.TabIndex = 8;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 28);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FrmManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1481, 732);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelHeader2);
            this.Controls.Add(this.panelHeader1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.907515F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmManagerUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go-goat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmManager_Load);
            this.panelHeader1.ResumeLayout(false);
            this.panelHeader1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).EndInit();
            this.panelHeader2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblgogoat;
        private System.Windows.Forms.PictureBox picboxlogo;
        private System.Windows.Forms.Panel panelHeader1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnreservation;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Panel panelHeader2;
        private System.Windows.Forms.Button btnprofile;
        private System.Windows.Forms.Label lblmanager;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnmenucat;
        private System.Windows.Forms.Button btnlogout;
    }
}

