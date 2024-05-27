namespace Manager_asm
{
    partial class frmCustomerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblgogoat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnprofile = new System.Windows.Forms.Button();
            this.btnreservation = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.picboxlogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Controls.Add(this.lblgogoat);
            this.panel1.Controls.Add(this.picboxlogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2320, 72);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(2221, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.907515F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(2086, 27);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(86, 20);
            this.lblCustomer.TabIndex = 8;
            this.lblCustomer.Text = "Customer";
            // 
            // lblgogoat
            // 
            this.lblgogoat.AutoSize = true;
            this.lblgogoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.98844F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgogoat.ForeColor = System.Drawing.Color.Snow;
            this.lblgogoat.Location = new System.Drawing.Point(1097, 27);
            this.lblgogoat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblgogoat.Name = "lblgogoat";
            this.lblgogoat.Size = new System.Drawing.Size(115, 25);
            this.lblgogoat.TabIndex = 0;
            this.lblgogoat.Text = "GO-GOAT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnFeedback);
            this.panel2.Controls.Add(this.btnprofile);
            this.panel2.Controls.Add(this.btnreservation);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2320, 57);
            this.panel2.TabIndex = 8;
            // 
            // btnFeedback
            // 
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.Chocolate;
            this.btnFeedback.Location = new System.Drawing.Point(855, 0);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(207, 72);
            this.btnFeedback.TabIndex = 4;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnprofile
            // 
            this.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofile.ForeColor = System.Drawing.Color.Chocolate;
            this.btnprofile.Location = new System.Drawing.Point(1267, 0);
            this.btnprofile.Margin = new System.Windows.Forms.Padding(4);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(207, 72);
            this.btnprofile.TabIndex = 3;
            this.btnprofile.Text = "Profile";
            this.btnprofile.UseVisualStyleBackColor = true;
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // btnreservation
            // 
            this.btnreservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreservation.ForeColor = System.Drawing.Color.Chocolate;
            this.btnreservation.Location = new System.Drawing.Point(1066, 0);
            this.btnreservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnreservation.Name = "btnreservation";
            this.btnreservation.Size = new System.Drawing.Size(207, 72);
            this.btnreservation.TabIndex = 1;
            this.btnreservation.Text = "Reservation";
            this.btnreservation.UseVisualStyleBackColor = true;
            this.btnreservation.Click += new System.EventHandler(this.btnreservation_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Chocolate;
            this.btnMenu.Location = new System.Drawing.Point(643, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(207, 72);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.White;
            this.panelCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomer.Location = new System.Drawing.Point(0, 129);
            this.panelCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(2320, 442);
            this.panelCustomer.TabIndex = 9;
            // 
            // picboxlogo
            // 
            this.picboxlogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxlogo.Image")));
            this.picboxlogo.Location = new System.Drawing.Point(36, 11);
            this.picboxlogo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.picboxlogo.Name = "picboxlogo";
            this.picboxlogo.Size = new System.Drawing.Size(122, 57);
            this.picboxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxlogo.TabIndex = 2;
            this.picboxlogo.TabStop = false;
            // 
            // frmCustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2320, 571);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCustomerUI";
            this.Text = "frmCustomerUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomerUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblgogoat;
        private System.Windows.Forms.PictureBox picboxlogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnprofile;
        private System.Windows.Forms.Button btnreservation;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelCustomer;
    }
}