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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblGogoat = new System.Windows.Forms.Label();
            this.picboxlogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Chocolate;
            this.panelHeader.Controls.Add(this.btnLogOut);
            this.panelHeader.Controls.Add(this.lblCustomer);
            this.panelHeader.Controls.Add(this.lblGogoat);
            this.panelHeader.Controls.Add(this.picboxlogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.Color.Silver;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(2819, 72);
            this.panelHeader.TabIndex = 7;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Chocolate;
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(2221, 17);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(111, 42);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.button1_Click);
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
            // lblGogoat
            // 
            this.lblGogoat.AutoSize = true;
            this.lblGogoat.Font = new System.Drawing.Font("Alone In Space", 9.98844F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGogoat.ForeColor = System.Drawing.Color.Snow;
            this.lblGogoat.Location = new System.Drawing.Point(1097, 27);
            this.lblGogoat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGogoat.Name = "lblGogoat";
            this.lblGogoat.Size = new System.Drawing.Size(152, 19);
            this.lblGogoat.TabIndex = 0;
            this.lblGogoat.Text = "GO-GOAT";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnOrders);
            this.panel2.Controls.Add(this.btnFeedback);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.btnReservation);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2819, 57);
            this.panel2.TabIndex = 8;
            // 
            // btnOrders
            // 
            this.btnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.Chocolate;
            this.btnOrders.Location = new System.Drawing.Point(662, 0);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(207, 72);
            this.btnOrders.TabIndex = 5;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.Chocolate;
            this.btnFeedback.Location = new System.Drawing.Point(867, 0);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(207, 72);
            this.btnFeedback.TabIndex = 4;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Chocolate;
            this.btnProfile.Location = new System.Drawing.Point(1267, 0);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(207, 72);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.Chocolate;
            this.btnReservation.Location = new System.Drawing.Point(1066, 0);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(207, 72);
            this.btnReservation.TabIndex = 1;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnreservation_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Chocolate;
            this.btnMenu.Location = new System.Drawing.Point(460, 0);
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
            this.panelCustomer.Size = new System.Drawing.Size(2819, 442);
            this.panelCustomer.TabIndex = 9;
            // 
            // frmCustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2819, 571);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmCustomerUI";
            this.Text = "frmCustomerUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomerUI_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblGogoat;
        private System.Windows.Forms.PictureBox picboxlogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Button btnOrders;
    }
}