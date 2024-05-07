namespace Manager_asm
{
    partial class FrmManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManager));
            this.lblgogoat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmanager = new System.Windows.Forms.Label();
            this.picboxlogo = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnreservation = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnprofile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblgogoat
            // 
            this.lblgogoat.AutoSize = true;
            this.lblgogoat.Font = new System.Drawing.Font("Alone In Space", 9.98844F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgogoat.ForeColor = System.Drawing.Color.Snow;
            this.lblgogoat.Location = new System.Drawing.Point(650, 36);
            this.lblgogoat.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblgogoat.Name = "lblgogoat";
            this.lblgogoat.Size = new System.Drawing.Size(181, 24);
            this.lblgogoat.TabIndex = 0;
            this.lblgogoat.Text = "GO-GOAT";
            this.lblgogoat.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.lblmanager);
            this.panel1.Controls.Add(this.lblgogoat);
            this.panel1.Controls.Add(this.picboxlogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1481, 86);
            this.panel1.TabIndex = 6;
            // 
            // lblmanager
            // 
            this.lblmanager.AutoSize = true;
            this.lblmanager.Font = new System.Drawing.Font("Montserrat SemiBold", 7.907515F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanager.ForeColor = System.Drawing.Color.White;
            this.lblmanager.Location = new System.Drawing.Point(1334, 34);
            this.lblmanager.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblmanager.Name = "lblmanager";
            this.lblmanager.Size = new System.Drawing.Size(103, 28);
            this.lblmanager.TabIndex = 8;
            this.lblmanager.Text = "Manager";
            // 
            // picboxlogo
            // 
            this.picboxlogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxlogo.Image")));
            this.picboxlogo.Location = new System.Drawing.Point(43, 13);
            this.picboxlogo.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.picboxlogo.Name = "picboxlogo";
            this.picboxlogo.Size = new System.Drawing.Size(146, 68);
            this.picboxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxlogo.TabIndex = 2;
            this.picboxlogo.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Chocolate;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(249, 86);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnreservation
            // 
            this.btnreservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreservation.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreservation.ForeColor = System.Drawing.Color.Chocolate;
            this.btnreservation.Location = new System.Drawing.Point(252, 0);
            this.btnreservation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnreservation.Name = "btnreservation";
            this.btnreservation.Size = new System.Drawing.Size(249, 86);
            this.btnreservation.TabIndex = 1;
            this.btnreservation.Text = "Reservation";
            this.btnreservation.UseVisualStyleBackColor = true;
            this.btnreservation.Click += new System.EventHandler(this.btnreservation_Click);
            // 
            // btnreport
            // 
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.Chocolate;
            this.btnreport.Location = new System.Drawing.Point(505, 0);
            this.btnreport.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(249, 86);
            this.btnreport.TabIndex = 2;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnprofile);
            this.panel2.Controls.Add(this.btnreport);
            this.panel2.Controls.Add(this.btnreservation);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1481, 68);
            this.panel2.TabIndex = 7;
            // 
            // btnprofile
            // 
            this.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprofile.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofile.ForeColor = System.Drawing.Color.Chocolate;
            this.btnprofile.Location = new System.Drawing.Point(757, 0);
            this.btnprofile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(249, 86);
            this.btnprofile.TabIndex = 3;
            this.btnprofile.Text = "Profile";
            this.btnprofile.UseVisualStyleBackColor = true;
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manager_asm.Properties.Resources.camera;
            this.pictureBox1.Location = new System.Drawing.Point(-1272, 121);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 726);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 154);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1481, 754);
            this.panelContainer.TabIndex = 8;
            // 
            // FrmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(173F, 173F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1481, 908);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Montserrat", 7.907515F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "FrmManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go-goat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblgogoat;
        private System.Windows.Forms.PictureBox picboxlogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnreservation;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnprofile;
        private System.Windows.Forms.Label lblmanager;
        private System.Windows.Forms.Panel panelContainer;
    }
}

