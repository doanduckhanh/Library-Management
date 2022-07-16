namespace Library_Management
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOrderList = new System.Windows.Forms.Button();
            this.btCustomerList = new System.Windows.Forms.Button();
            this.btBookList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbImport = new System.Windows.Forms.Button();
            this.tbAddNew = new System.Windows.Forms.Button();
            this.pnBook = new System.Windows.Forms.Panel();
            this.pnCustomer = new System.Windows.Forms.Panel();
            this.btAddNewCus = new System.Windows.Forms.Button();
            this.btImportCus = new System.Windows.Forms.Button();
            this.btSearchCus = new System.Windows.Forms.Button();
            this.tbSearchCustomer = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnBook.SuspendLayout();
            this.pnCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btOrderList);
            this.panel1.Controls.Add(this.btCustomerList);
            this.panel1.Controls.Add(this.btBookList);
            this.panel1.Location = new System.Drawing.Point(12, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 395);
            this.panel1.TabIndex = 0;
            // 
            // btOrderList
            // 
            this.btOrderList.Location = new System.Drawing.Point(0, 256);
            this.btOrderList.Name = "btOrderList";
            this.btOrderList.Size = new System.Drawing.Size(343, 134);
            this.btOrderList.TabIndex = 2;
            this.btOrderList.Text = "Order List";
            this.btOrderList.UseVisualStyleBackColor = true;
            // 
            // btCustomerList
            // 
            this.btCustomerList.Location = new System.Drawing.Point(0, 128);
            this.btCustomerList.Name = "btCustomerList";
            this.btCustomerList.Size = new System.Drawing.Size(343, 122);
            this.btCustomerList.TabIndex = 1;
            this.btCustomerList.Text = "Customer List";
            this.btCustomerList.UseVisualStyleBackColor = true;
            this.btCustomerList.Click += new System.EventHandler(this.btCustomerList_Click);
            // 
            // btBookList
            // 
            this.btBookList.Location = new System.Drawing.Point(0, 3);
            this.btBookList.Name = "btBookList";
            this.btBookList.Size = new System.Drawing.Size(343, 119);
            this.btBookList.TabIndex = 0;
            this.btBookList.Text = "Book List";
            this.btBookList.UseVisualStyleBackColor = true;
            this.btBookList.Click += new System.EventHandler(this.btBookList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 672);
            this.dataGridView1.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(118, 36);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(151, 28);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 27);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(677, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(603, 37);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(68, 28);
            this.cbSearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category";
            // 
            // tbImport
            // 
            this.tbImport.Location = new System.Drawing.Point(1070, 107);
            this.tbImport.Name = "tbImport";
            this.tbImport.Size = new System.Drawing.Size(94, 29);
            this.tbImport.TabIndex = 7;
            this.tbImport.Text = "Import";
            this.tbImport.UseVisualStyleBackColor = true;
            // 
            // tbAddNew
            // 
            this.tbAddNew.Location = new System.Drawing.Point(1070, 180);
            this.tbAddNew.Name = "tbAddNew";
            this.tbAddNew.Size = new System.Drawing.Size(94, 29);
            this.tbAddNew.TabIndex = 8;
            this.tbAddNew.Text = "Add New";
            this.tbAddNew.UseVisualStyleBackColor = true;
            this.tbAddNew.Click += new System.EventHandler(this.tbAddNew_Click);
            // 
            // pnBook
            // 
            this.pnBook.Controls.Add(this.cbCategory);
            this.pnBook.Controls.Add(this.textBox1);
            this.pnBook.Controls.Add(this.cbSearch);
            this.pnBook.Controls.Add(this.tbAddNew);
            this.pnBook.Controls.Add(this.button1);
            this.pnBook.Controls.Add(this.label1);
            this.pnBook.Controls.Add(this.tbImport);
            this.pnBook.Controls.Add(this.dataGridView1);
            this.pnBook.Location = new System.Drawing.Point(384, 26);
            this.pnBook.Name = "pnBook";
            this.pnBook.Size = new System.Drawing.Size(1186, 800);
            this.pnBook.TabIndex = 9;
            // 
            // pnCustomer
            // 
            this.pnCustomer.Controls.Add(this.btAddNewCus);
            this.pnCustomer.Controls.Add(this.btImportCus);
            this.pnCustomer.Controls.Add(this.btSearchCus);
            this.pnCustomer.Controls.Add(this.tbSearchCustomer);
            this.pnCustomer.Controls.Add(this.dataGridView2);
            this.pnCustomer.Location = new System.Drawing.Point(384, 26);
            this.pnCustomer.Name = "pnCustomer";
            this.pnCustomer.Size = new System.Drawing.Size(1186, 797);
            this.pnCustomer.TabIndex = 10;
            // 
            // btAddNewCus
            // 
            this.btAddNewCus.Location = new System.Drawing.Point(1070, 200);
            this.btAddNewCus.Name = "btAddNewCus";
            this.btAddNewCus.Size = new System.Drawing.Size(94, 29);
            this.btAddNewCus.TabIndex = 4;
            this.btAddNewCus.Text = "Add New";
            this.btAddNewCus.UseVisualStyleBackColor = true;
            // 
            // btImportCus
            // 
            this.btImportCus.Location = new System.Drawing.Point(1070, 107);
            this.btImportCus.Name = "btImportCus";
            this.btImportCus.Size = new System.Drawing.Size(94, 29);
            this.btImportCus.TabIndex = 3;
            this.btImportCus.Text = "Import";
            this.btImportCus.UseVisualStyleBackColor = true;
            // 
            // btSearchCus
            // 
            this.btSearchCus.Location = new System.Drawing.Point(481, 31);
            this.btSearchCus.Name = "btSearchCus";
            this.btSearchCus.Size = new System.Drawing.Size(94, 29);
            this.btSearchCus.TabIndex = 2;
            this.btSearchCus.Text = "Search";
            this.btSearchCus.UseVisualStyleBackColor = true;
            // 
            // tbSearchCustomer
            // 
            this.tbSearchCustomer.Location = new System.Drawing.Point(313, 31);
            this.tbSearchCustomer.Name = "tbSearchCustomer";
            this.tbSearchCustomer.Size = new System.Drawing.Size(162, 27);
            this.tbSearchCustomer.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(1032, 687);
            this.dataGridView2.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.pnCustomer);
            this.Controls.Add(this.pnBook);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Library Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnBook.ResumeLayout(false);
            this.pnBook.PerformLayout();
            this.pnCustomer.ResumeLayout(false);
            this.pnCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tbImport;
        private System.Windows.Forms.Button btOrderList;
        private System.Windows.Forms.Button btCustomerList;
        private System.Windows.Forms.Button btBookList;
        private System.Windows.Forms.Button tbAddNew;
        private System.Windows.Forms.Panel pnBook;
        private System.Windows.Forms.Panel pnCustomer;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btAddNewCus;
        private System.Windows.Forms.Button btImportCus;
        private System.Windows.Forms.Button btSearchCus;
        private System.Windows.Forms.TextBox tbSearchCustomer;
    }
}
