namespace Library_Management
{
    partial class frmOrderList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.rbInProgress = new System.Windows.Forms.RadioButton();
            this.rbDone = new System.Windows.Forms.RadioButton();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btUpdateOrder = new System.Windows.Forms.Button();
            this.btAddOrder = new System.Windows.Forms.Button();
            this.btDeleteOrder = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(902, 692);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 27);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(273, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1067, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1067, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1067, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1067, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1067, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "End Date";
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(1197, 133);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.ReadOnly = true;
            this.tbOrderID.Size = new System.Drawing.Size(158, 27);
            this.tbOrderID.TabIndex = 9;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(1197, 242);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(180, 27);
            this.tbCustomerID.TabIndex = 10;
            // 
            // rbInProgress
            // 
            this.rbInProgress.AutoSize = true;
            this.rbInProgress.Location = new System.Drawing.Point(1127, 624);
            this.rbInProgress.Name = "rbInProgress";
            this.rbInProgress.Size = new System.Drawing.Size(102, 24);
            this.rbInProgress.TabIndex = 11;
            this.rbInProgress.TabStop = true;
            this.rbInProgress.Text = "In Progress";
            this.rbInProgress.UseVisualStyleBackColor = true;
            // 
            // rbDone
            // 
            this.rbDone.AutoSize = true;
            this.rbDone.Location = new System.Drawing.Point(1332, 624);
            this.rbDone.Name = "rbDone";
            this.rbDone.Size = new System.Drawing.Size(66, 24);
            this.rbDone.TabIndex = 12;
            this.rbDone.TabStop = true;
            this.rbDone.Text = "Done";
            this.rbDone.UseVisualStyleBackColor = true;
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(1197, 344);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(180, 27);
            this.tbBookID.TabIndex = 13;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(1197, 444);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(273, 27);
            this.dtpStart.TabIndex = 14;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(1197, 544);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(273, 27);
            this.dtpEnd.TabIndex = 15;
            // 
            // btUpdateOrder
            // 
            this.btUpdateOrder.Location = new System.Drawing.Point(1217, 709);
            this.btUpdateOrder.Name = "btUpdateOrder";
            this.btUpdateOrder.Size = new System.Drawing.Size(94, 29);
            this.btUpdateOrder.TabIndex = 16;
            this.btUpdateOrder.Text = "Update";
            this.btUpdateOrder.UseVisualStyleBackColor = true;
            this.btUpdateOrder.Click += new System.EventHandler(this.btUpdateOrder_Click);
            // 
            // btAddOrder
            // 
            this.btAddOrder.Location = new System.Drawing.Point(1067, 709);
            this.btAddOrder.Name = "btAddOrder";
            this.btAddOrder.Size = new System.Drawing.Size(94, 29);
            this.btAddOrder.TabIndex = 17;
            this.btAddOrder.Text = "Add New";
            this.btAddOrder.UseVisualStyleBackColor = true;
            this.btAddOrder.Click += new System.EventHandler(this.btAddOrder_Click);
            // 
            // btDeleteOrder
            // 
            this.btDeleteOrder.Location = new System.Drawing.Point(1376, 709);
            this.btDeleteOrder.Name = "btDeleteOrder";
            this.btDeleteOrder.Size = new System.Drawing.Size(94, 29);
            this.btDeleteOrder.TabIndex = 18;
            this.btDeleteOrder.Text = "Delete";
            this.btDeleteOrder.UseVisualStyleBackColor = true;
            this.btDeleteOrder.Click += new System.EventHandler(this.btDeleteOrder_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1404, 241);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 29);
            this.button5.TabIndex = 19;
            this.button5.Text = "Search Customer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1404, 342);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 29);
            this.button6.TabIndex = 20;
            this.button6.Text = "Search Book";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1582, 819);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btDeleteOrder);
            this.Controls.Add(this.btAddOrder);
            this.Controls.Add(this.btUpdateOrder);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.tbBookID);
            this.Controls.Add(this.rbDone);
            this.Controls.Add(this.rbInProgress);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderList";
            this.Text = "frmOrderList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.RadioButton rbInProgress;
        private System.Windows.Forms.RadioButton rbDone;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btUpdateOrder;
        private System.Windows.Forms.Button btAddOrder;
        private System.Windows.Forms.Button btDeleteOrder;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}