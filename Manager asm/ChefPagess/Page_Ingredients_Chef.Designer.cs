namespace Manager_asm.ChefPagess
{
    partial class Page_Ingredients_Chef
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Ingredients_Chef));
            this.panelIngredients = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblIngredientstitle = new System.Windows.Forms.Label();
            this.datagridviewIng = new System.Windows.Forms.DataGridView();
            this.ingredientsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goDBDataSet = new Manager_asm.GoDBDataSet();
            this.btnalling = new System.Windows.Forms.Button();
            this.btnbevnadd = new System.Windows.Forms.Button();
            this.btnProteins = new System.Windows.Forms.Button();
            this.btnvegandfruits = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtbxsearch = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblunit = new System.Windows.Forms.Label();
            this.cmbbxcategory = new System.Windows.Forms.ComboBox();
            this.cmbbxunit = new System.Windows.Forms.ComboBox();
            this.lbltitleadd = new System.Windows.Forms.Label();
            this.ingredientsTableAdapter = new Manager_asm.GoDBDataSetTableAdapters.IngredientsTableAdapter();
            this.panelIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewIng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIngredients
            // 
            this.panelIngredients.BackColor = System.Drawing.Color.SeaShell;
            this.panelIngredients.Controls.Add(this.pictureBox2);
            this.panelIngredients.Location = new System.Drawing.Point(0, 0);
            this.panelIngredients.Margin = new System.Windows.Forms.Padding(2);
            this.panelIngredients.Name = "panelIngredients";
            this.panelIngredients.Size = new System.Drawing.Size(2045, 138);
            this.panelIngredients.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(934, 33);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblIngredientstitle
            // 
            this.lblIngredientstitle.AutoSize = true;
            this.lblIngredientstitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientstitle.Location = new System.Drawing.Point(31, 170);
            this.lblIngredientstitle.Name = "lblIngredientstitle";
            this.lblIngredientstitle.Size = new System.Drawing.Size(215, 32);
            this.lblIngredientstitle.TabIndex = 18;
            this.lblIngredientstitle.Text = "INGREDIENTS";
            // 
            // datagridviewIng
            // 
            this.datagridviewIng.AutoGenerateColumns = false;
            this.datagridviewIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewIng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientsIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.datagridviewIng.DataSource = this.ingredientsBindingSource;
            this.datagridviewIng.Location = new System.Drawing.Point(278, 244);
            this.datagridviewIng.Name = "datagridviewIng";
            this.datagridviewIng.RowHeadersWidth = 62;
            this.datagridviewIng.RowTemplate.Height = 28;
            this.datagridviewIng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewIng.Size = new System.Drawing.Size(1224, 580);
            this.datagridviewIng.TabIndex = 19;
            // 
            // ingredientsIDDataGridViewTextBoxColumn
            // 
            this.ingredientsIDDataGridViewTextBoxColumn.DataPropertyName = "IngredientsID";
            this.ingredientsIDDataGridViewTextBoxColumn.HeaderText = "IngredientsID";
            this.ingredientsIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ingredientsIDDataGridViewTextBoxColumn.Name = "ingredientsIDDataGridViewTextBoxColumn";
            this.ingredientsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ingredientsIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "Ingredients";
            this.ingredientsBindingSource.DataSource = this.goDBDataSet;
            // 
            // goDBDataSet
            // 
            this.goDBDataSet.DataSetName = "GoDBDataSet";
            this.goDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnalling
            // 
            this.btnalling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalling.Location = new System.Drawing.Point(59, 257);
            this.btnalling.Name = "btnalling";
            this.btnalling.Size = new System.Drawing.Size(154, 75);
            this.btnalling.TabIndex = 20;
            this.btnalling.Text = "All";
            this.btnalling.UseVisualStyleBackColor = true;
            // 
            // btnbevnadd
            // 
            this.btnbevnadd.Location = new System.Drawing.Point(59, 635);
            this.btnbevnadd.Name = "btnbevnadd";
            this.btnbevnadd.Size = new System.Drawing.Size(154, 75);
            this.btnbevnadd.TabIndex = 21;
            this.btnbevnadd.Text = "Beverages and Additives";
            this.btnbevnadd.UseVisualStyleBackColor = true;
            // 
            // btnProteins
            // 
            this.btnProteins.Location = new System.Drawing.Point(59, 350);
            this.btnProteins.Name = "btnProteins";
            this.btnProteins.Size = new System.Drawing.Size(154, 75);
            this.btnProteins.TabIndex = 22;
            this.btnProteins.Text = "Proteins";
            this.btnProteins.UseVisualStyleBackColor = true;
            // 
            // btnvegandfruits
            // 
            this.btnvegandfruits.Location = new System.Drawing.Point(59, 445);
            this.btnvegandfruits.Name = "btnvegandfruits";
            this.btnvegandfruits.Size = new System.Drawing.Size(154, 75);
            this.btnvegandfruits.TabIndex = 23;
            this.btnvegandfruits.Text = "Vegetables and Fruits";
            this.btnvegandfruits.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(59, 540);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 75);
            this.button5.TabIndex = 24;
            this.button5.Text = "Cooking basics";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(59, 734);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 75);
            this.button6.TabIndex = 25;
            this.button6.Text = "Prepared Food";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(1544, 471);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(99, 40);
            this.btnadd.TabIndex = 26;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtbxsearch
            // 
            this.txtbxsearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtbxsearch.Location = new System.Drawing.Point(325, 177);
            this.txtbxsearch.Name = "txtbxsearch";
            this.txtbxsearch.Size = new System.Drawing.Size(160, 26);
            this.txtbxsearch.TabIndex = 28;
            this.txtbxsearch.Text = "Search";
            this.txtbxsearch.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.txtbxsearch.TextChanged += new System.EventHandler(this.txtbxsearch_TextChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(1634, 257);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(160, 26);
            this.txtname.TabIndex = 29;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(1738, 471);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(99, 40);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(1540, 260);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(51, 20);
            this.lblname.TabIndex = 30;
            this.lblname.Text = "Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Location = new System.Drawing.Point(1540, 323);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(73, 20);
            this.lblcategory.TabIndex = 34;
            this.lblcategory.Text = "Category";
            // 
            // lblunit
            // 
            this.lblunit.AutoSize = true;
            this.lblunit.Location = new System.Drawing.Point(1540, 387);
            this.lblunit.Name = "lblunit";
            this.lblunit.Size = new System.Drawing.Size(38, 20);
            this.lblunit.TabIndex = 36;
            this.lblunit.Text = "Unit";
            // 
            // cmbbxcategory
            // 
            this.cmbbxcategory.FormattingEnabled = true;
            this.cmbbxcategory.Items.AddRange(new object[] {
            "Beverages and Additives",
            "Proteins",
            "Cooking Basics",
            "Vegetables and Fruits",
            "Prepared Foods"});
            this.cmbbxcategory.Location = new System.Drawing.Point(1634, 323);
            this.cmbbxcategory.Name = "cmbbxcategory";
            this.cmbbxcategory.Size = new System.Drawing.Size(160, 28);
            this.cmbbxcategory.TabIndex = 37;
            // 
            // cmbbxunit
            // 
            this.cmbbxunit.FormattingEnabled = true;
            this.cmbbxunit.Items.AddRange(new object[] {
            "Boxes",
            "Cartons",
            "Kilograms",
            "Grams",
            "Litres",
            "Mililitres",
            "Bags",
            "Bottles",
            "Packets",
            "Loaf"});
            this.cmbbxunit.Location = new System.Drawing.Point(1634, 384);
            this.cmbbxunit.Name = "cmbbxunit";
            this.cmbbxunit.Size = new System.Drawing.Size(160, 28);
            this.cmbbxunit.TabIndex = 38;
            // 
            // lbltitleadd
            // 
            this.lbltitleadd.AutoSize = true;
            this.lbltitleadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitleadd.Location = new System.Drawing.Point(1586, 204);
            this.lbltitleadd.Name = "lbltitleadd";
            this.lbltitleadd.Size = new System.Drawing.Size(149, 25);
            this.lbltitleadd.TabIndex = 39;
            this.lbltitleadd.Text = "Add Ingredients";
            // 
            // ingredientsTableAdapter
            // 
            this.ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // Page_Ingredients_Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbltitleadd);
            this.Controls.Add(this.cmbbxunit);
            this.Controls.Add(this.cmbbxcategory);
            this.Controls.Add(this.lblunit);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtbxsearch);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnvegandfruits);
            this.Controls.Add(this.btnProteins);
            this.Controls.Add(this.btnbevnadd);
            this.Controls.Add(this.btnalling);
            this.Controls.Add(this.datagridviewIng);
            this.Controls.Add(this.lblIngredientstitle);
            this.Controls.Add(this.panelIngredients);
            this.Name = "Page_Ingredients_Chef";
            this.Size = new System.Drawing.Size(2045, 844);
            this.panelIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewIng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIngredients;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblIngredientstitle;
        private System.Windows.Forms.DataGridView datagridviewIng;
        private System.Windows.Forms.Button btnalling;
        private System.Windows.Forms.Button btnbevnadd;
        private System.Windows.Forms.Button btnProteins;
        private System.Windows.Forms.Button btnvegandfruits;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtbxsearch;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblunit;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.ComboBox cmbbxunit;
        private System.Windows.Forms.ComboBox cmbbxcategory;
        private System.Windows.Forms.Label lbltitleadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private GoDBDataSet goDBDataSet;
        private GoDBDataSetTableAdapters.IngredientsTableAdapter ingredientsTableAdapter;
    }
}
