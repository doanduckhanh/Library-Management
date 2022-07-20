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
            this.btAddNew = new System.Windows.Forms.Button();
            this.pnBook = new System.Windows.Forms.Panel();
            this.pnCustomer = new System.Windows.Forms.Panel();
            this.pnOrder = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btAddNewCus = new System.Windows.Forms.Button();
            this.btImportCus = new System.Windows.Forms.Button();
            this.btSearchCus = new System.Windows.Forms.Button();
            this.tbSearchCustomer = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnBook.SuspendLayout();
            this.pnCustomer.SuspendLayout();
            this.pnOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btOrderList.Click += new System.EventHandler(this.btOrderList_Click);
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
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(1070, 180);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(94, 29);
            this.btAddNew.TabIndex = 8;
            this.btAddNew.Text = "Add New";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.tbAddNew_Click);
            // 
            // pnBook
            // 
            this.pnBook.Controls.Add(this.cbCategory);
            this.pnBook.Controls.Add(this.textBox1);
            this.pnBook.Controls.Add(this.cbSearch);
            this.pnBook.Controls.Add(this.btAddNew);
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
            this.pnCustomer.Controls.Add(this.pnOrder);
            this.pnCustomer.Controls.Add(this.label2);
            this.pnCustomer.Controls.Add(this.comboBox1);
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
            // pnOrder
            // 
            this.pnOrder.Controls.Add(this.button7);
            this.pnOrder.Controls.Add(this.button6);
            this.pnOrder.Controls.Add(this.button5);
            this.pnOrder.Controls.Add(this.button4);
            this.pnOrder.Controls.Add(this.button3);
            this.pnOrder.Controls.Add(this.dateTimePicker2);
            this.pnOrder.Controls.Add(this.dateTimePicker1);
            this.pnOrder.Controls.Add(this.textBox5);
            this.pnOrder.Controls.Add(this.textBox4);
            this.pnOrder.Controls.Add(this.textBox3);
            this.pnOrder.Controls.Add(this.radioButton2);
            this.pnOrder.Controls.Add(this.radioButton1);
            this.pnOrder.Controls.Add(this.label7);
            this.pnOrder.Controls.Add(this.label6);
            this.pnOrder.Controls.Add(this.label5);
            this.pnOrder.Controls.Add(this.label4);
            this.pnOrder.Controls.Add(this.label3);
            this.pnOrder.Controls.Add(this.button2);
            this.pnOrder.Controls.Add(this.textBox2);
            this.pnOrder.Controls.Add(this.dataGridView3);
            this.pnOrder.Location = new System.Drawing.Point(3, 0);
            this.pnOrder.Name = "pnOrder";
            this.pnOrder.Size = new System.Drawing.Size(1180, 794);
            this.pnOrder.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(450, 740);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 29);
            this.button7.TabIndex = 19;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(321, 740);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 18;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(192, 740);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 17;
            this.button5.Text = "Add New";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(334, 687);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 29);
            this.button4.TabIndex = 16;
            this.button4.Text = "View Book Detail";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.tbAddNew_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 613);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 29);
            this.button3.TabIndex = 15;
            this.button3.Text = "View Customer Detail";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btAddNewCus_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(773, 612);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(773, 534);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(192, 688);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 27);
            this.textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(192, 614);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 27);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 536);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 27);
            this.textBox3.TabIndex = 10;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(861, 684);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 24);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(674, 684);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(674, 612);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "End Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 688);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 27);
            this.textBox2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(48, 104);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(975, 398);
            this.dataGridView3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(513, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sort By";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(588, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // btAddNewCus
            // 
            this.btAddNewCus.Location = new System.Drawing.Point(1070, 180);
            this.btAddNewCus.Name = "btAddNewCus";
            this.btAddNewCus.Size = new System.Drawing.Size(94, 29);
            this.btAddNewCus.TabIndex = 4;
            this.btAddNewCus.Text = "Add New";
            this.btAddNewCus.UseVisualStyleBackColor = true;
            this.btAddNewCus.Click += new System.EventHandler(this.btAddNewCus_Click);
            // 
            // btImportCus
            // 
            this.btImportCus.Location = new System.Drawing.Point(1070, 107);
            this.btImportCus.Name = "btImportCus";
            this.btImportCus.Size = new System.Drawing.Size(94, 29);
            this.btImportCus.TabIndex = 3;
            this.btImportCus.Text = "Import";
            this.btImportCus.UseVisualStyleBackColor = true;
            this.btImportCus.Click += new System.EventHandler(this.btImportCus_Click);
            // 
            // btSearchCus
            // 
            this.btSearchCus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSearchCus.Location = new System.Drawing.Point(307, 32);
            this.btSearchCus.Name = "btSearchCus";
            this.btSearchCus.Size = new System.Drawing.Size(94, 29);
            this.btSearchCus.TabIndex = 2;
            this.btSearchCus.Text = "Search";
            this.btSearchCus.UseVisualStyleBackColor = false;
            // 
            // tbSearchCustomer
            // 
            this.tbSearchCustomer.Location = new System.Drawing.Point(93, 32);
            this.tbSearchCustomer.Name = "tbSearchCustomer";
            this.tbSearchCustomer.Size = new System.Drawing.Size(208, 27);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 115);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.pictureBox1);
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
            this.pnOrder.ResumeLayout(false);
            this.pnOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Panel pnBook;
        private System.Windows.Forms.Panel pnCustomer;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btAddNewCus;
        private System.Windows.Forms.Button btImportCus;
        private System.Windows.Forms.Button btSearchCus;
        private System.Windows.Forms.TextBox tbSearchCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnOrder;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}
