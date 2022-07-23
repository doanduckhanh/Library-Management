namespace Library_Management
{
    partial class frmPendingList
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.rbDone = new System.Windows.Forms.RadioButton();
            this.rbInProgress = new System.Windows.Forms.RadioButton();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPendingDays = new System.Windows.Forms.TextBox();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btUpdateOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(123, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(726, 731);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1370, 256);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 29);
            this.button6.TabIndex = 34;
            this.button6.Text = "Search Book";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1370, 155);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 29);
            this.button5.TabIndex = 33;
            this.button5.Text = "Search Customer";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(1163, 458);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(273, 27);
            this.dtpEnd.TabIndex = 32;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(1163, 358);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(273, 27);
            this.dtpStart.TabIndex = 31;
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(1163, 258);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(180, 27);
            this.tbBookID.TabIndex = 30;
            // 
            // rbDone
            // 
            this.rbDone.AutoSize = true;
            this.rbDone.Location = new System.Drawing.Point(1298, 538);
            this.rbDone.Name = "rbDone";
            this.rbDone.Size = new System.Drawing.Size(66, 24);
            this.rbDone.TabIndex = 29;
            this.rbDone.TabStop = true;
            this.rbDone.Text = "Done";
            this.rbDone.UseVisualStyleBackColor = true;
            // 
            // rbInProgress
            // 
            this.rbInProgress.AutoSize = true;
            this.rbInProgress.Location = new System.Drawing.Point(1093, 538);
            this.rbInProgress.Name = "rbInProgress";
            this.rbInProgress.Size = new System.Drawing.Size(102, 24);
            this.rbInProgress.TabIndex = 28;
            this.rbInProgress.TabStop = true;
            this.rbInProgress.Text = "In Progress";
            this.rbInProgress.UseVisualStyleBackColor = true;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(1163, 156);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(180, 27);
            this.tbCustomerID.TabIndex = 27;
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(1163, 47);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.ReadOnly = true;
            this.tbOrderID.Size = new System.Drawing.Size(158, 27);
            this.tbOrderID.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1033, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1033, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1033, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1033, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1033, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Order ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1033, 615);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Pending Days";
            // 
            // tbPendingDays
            // 
            this.tbPendingDays.Location = new System.Drawing.Point(1163, 612);
            this.tbPendingDays.Name = "tbPendingDays";
            this.tbPendingDays.ReadOnly = true;
            this.tbPendingDays.Size = new System.Drawing.Size(125, 27);
            this.tbPendingDays.TabIndex = 36;
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(1163, 686);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.ReadOnly = true;
            this.tbMoney.Size = new System.Drawing.Size(125, 27);
            this.tbMoney.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1033, 689);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Forfeit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1303, 686);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "VND";
            // 
            // btUpdateOrder
            // 
            this.btUpdateOrder.Location = new System.Drawing.Point(1163, 760);
            this.btUpdateOrder.Name = "btUpdateOrder";
            this.btUpdateOrder.Size = new System.Drawing.Size(94, 29);
            this.btUpdateOrder.TabIndex = 40;
            this.btUpdateOrder.Text = "Update";
            this.btUpdateOrder.UseVisualStyleBackColor = true;
            this.btUpdateOrder.Click += new System.EventHandler(this.btUpdateOrder_Click);
            // 
            // frmPendingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1582, 819);
            this.Controls.Add(this.btUpdateOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.tbPendingDays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
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
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPendingList";
            this.Text = "frmPendingList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPendingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.RadioButton rbDone;
        private System.Windows.Forms.RadioButton rbInProgress;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPendingDays;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btUpdateOrder;
    }
}