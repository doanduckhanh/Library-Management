using Library_Management.Logics;
using Library_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class frmPendingList : Form
    {
        public frmPendingList()
        {
            InitializeComponent();
        }
        private void LDGV()
        {
            rbInProgress.Checked = true;
            dtpStart.Value = DateTime.Now.Date;
            dtpEnd.Value = DateTime.Now.Date;
            OrderManager orderManager = new OrderManager();
            dataGridView1.DataSource = orderManager.GetOrderPending();
        }
        private void frmPendingList_Load(object sender, EventArgs e)
        {
            OrderManager orderManager = new OrderManager();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("idcol", "Id");
            dataGridView1.Columns["idcol"].DataPropertyName = "OrID";
            dataGridView1.Columns.Add("cusidcol", "CustomerID");
            dataGridView1.Columns["cusidcol"].DataPropertyName = "CusID";
            dataGridView1.Columns.Add("bookidcol", "BookID");
            dataGridView1.Columns["bookidcol"].DataPropertyName = "BookID";
            dataGridView1.Columns.Add("startcol", "StartDate");
            dataGridView1.Columns["startcol"].DataPropertyName = "StartDat";
            dataGridView1.Columns.Add("endcol", "EndDate");
            dataGridView1.Columns["endcol"].DataPropertyName = "EndDate";
            LDGV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbOrderID.Text = row.Cells[0].Value.ToString();
                tbCustomerID.Text = row.Cells[1].Value.ToString();
                tbBookID.Text = row.Cells[2].Value.ToString();
                dtpStart.Value = Convert.ToDateTime(row.Cells[3].Value);
                dtpEnd.Value = Convert.ToDateTime(row.Cells[4].Value);
                if ((Boolean)row.Cells[5].Value == true)
                {
                    rbDone.Checked = true;
                }
                else
                {
                    rbInProgress.Checked = true;
                }
                TimeSpan time = dtpEnd.Value - dtpStart.Value;
                tbPendingDays.Text = time.Days.ToString();
                tbMoney.Text = (time.Days * 10000).ToString();
            }
        }

        private void btUpdateOrder_Click(object sender, EventArgs e)
        {
            if (tbBookID.Text.ToString() == "" || tbCustomerID.Text.ToString() == "")
            {
                MessageBox.Show("You must click a cell!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ;
            }
            else
            {
                Order a = new Order();
                OrderManager orderManager = new OrderManager();
                a.OrId = Convert.ToInt32(tbOrderID.Text.Trim());
                a.CusId = tbCustomerID.Text.Trim();
                a.BookId = Convert.ToInt32(tbBookID.Text.Trim());
                a.StartDat = Convert.ToDateTime(dtpStart.Value);
                a.EndDate = Convert.ToDateTime(dtpEnd.Value);
                if (rbInProgress.Checked == true)
                {
                    a.Status = true;
                }
                else
                {
                    a.Status = false;
                }
                DialogResult dialogResult = MessageBox.Show("Are You Sure To Update This Order ?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    orderManager.UpdateOrder(a);
                    LDGV();
                }
            }
        }
    }
}
