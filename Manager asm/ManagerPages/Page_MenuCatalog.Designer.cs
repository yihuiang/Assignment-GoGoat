namespace Manager_asm.Pages
{
    partial class Page_MenuCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_MenuCatalog));
            this.lblMenucat = new System.Windows.Forms.Label();
            this.picboxAdd = new System.Windows.Forms.PictureBox();
            this.dataGridViewMenucat = new System.Windows.Forms.DataGridView();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenucat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenucat
            // 
            this.lblMenucat.AutoSize = true;
            this.lblMenucat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.15029F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenucat.Location = new System.Drawing.Point(422, 60);
            this.lblMenucat.Name = "lblMenucat";
            this.lblMenucat.Size = new System.Drawing.Size(302, 39);
            this.lblMenucat.TabIndex = 0;
            this.lblMenucat.Text = "MENU CATALOG";
            // 
            // picboxAdd
            // 
            this.picboxAdd.Image = ((System.Drawing.Image)(resources.GetObject("picboxAdd.Image")));
            this.picboxAdd.Location = new System.Drawing.Point(429, 124);
            this.picboxAdd.Name = "picboxAdd";
            this.picboxAdd.Size = new System.Drawing.Size(66, 66);
            this.picboxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxAdd.TabIndex = 6;
            this.picboxAdd.TabStop = false;
            this.picboxAdd.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridViewMenucat
            // 
            this.dataGridViewMenucat.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridViewMenucat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenucat.Location = new System.Drawing.Point(429, 225);
            this.dataGridViewMenucat.Name = "dataGridViewMenucat";
            this.dataGridViewMenucat.RowHeadersWidth = 74;
            this.dataGridViewMenucat.RowTemplate.Height = 31;
            this.dataGridViewMenucat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMenucat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenucat.Size = new System.Drawing.Size(1645, 1055);
            this.dataGridViewMenucat.TabIndex = 7;
            this.dataGridViewMenucat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridViewMenucat.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(29, 29);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(333, 29);
            this.txtboxSearch.TabIndex = 8;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Chocolate;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(382, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 37);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtboxSearch);
            this.panel1.Location = new System.Drawing.Point(1555, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 82);
            this.panel1.TabIndex = 10;
            // 
            // Page_MenuCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewMenucat);
            this.Controls.Add(this.picboxAdd);
            this.Controls.Add(this.lblMenucat);
            this.Name = "Page_MenuCatalog";
            this.Size = new System.Drawing.Size(2500, 1363);
            this.Load += new System.EventHandler(this.Page_MenuCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenucat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenucat;
        private System.Windows.Forms.PictureBox picboxAdd;
        private System.Windows.Forms.DataGridView dataGridViewMenucat;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
    }
}
