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
    public partial class frmOrderList : Form
    {
        public frmOrderList()
        {
            InitializeComponent();
        }
        private void LDGV()
        {
            rbInProgress.Checked = true;
            dtpStart.Value = DateTime.Now.Date;
            dtpEnd.Value = DateTime.Now.Date;
            OrderManager orderManager = new OrderManager();
            dataGridView1.DataSource = orderManager.GetOrderList();
        }
        private void frmOrderList_Load(object sender, EventArgs e)
        {
            //Load Data for Order
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
            dataGridView1.Columns.Add("statuscol", "Status");
            dataGridView1.Columns["statuscol"].DataPropertyName = "Status";
            LDGV();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbCustomerID.Text.ToString() == "")
            {
                MessageBox.Show("You must input the Customer ID to Search!");
            }
            else
            {
                CustomerManager customerManager = new CustomerManager();
                Customer c = new Customer();
                c = customerManager.GetCustomer(tbCustomerID.Text.ToString());
                if (c != null)
                {
                    frmCusDetail Child = new frmCusDetail(tbCustomerID.Text);
                    Child.ShowDialog();
                } else
                {
                    MessageBox.Show("The Customer Doesn't Exist!");
                }
            }
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
                if((Boolean)row.Cells[5].Value == true)
                {
                    rbDone.Checked = true;
                }
                else
                {
                    rbInProgress.Checked = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tbBookID.Text.ToString() == "")
            {
                MessageBox.Show("You must input the Book ID to Search!");
            }
            else
            {
                BookManager bookManager = new BookManager();
                Book b = new Book();
                b = bookManager.GetBook(tbBookID.Text.ToString());
                if (b != null)
                {
                    frmBookDetail Child = new frmBookDetail(tbBookID.Text);
                    Child.ShowDialog();
                }
                else
                {
                    MessageBox.Show("The Book Doesn't Exist!");
                }
            }
        }

        private void btAddOrder_Click(object sender, EventArgs e)
        {
            if (tbBookID.Text.ToString() == "" || tbCustomerID.Text.ToString() == "")
            {
                MessageBox.Show("You must input data to add!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ;
            }
            else
            {
                Order a = new Order();
                OrderManager orderManager = new OrderManager();
                a.CusId = tbCustomerID.Text.Trim();
                a.BookId = Convert.ToInt32(tbBookID.Text.Trim());
                a.StartDat = Convert.ToDateTime(dtpStart.Value);
                a.EndDate = Convert.ToDateTime(dtpEnd.Value);
                if(rbInProgress.Checked == true)
                {
                    a.Status = false;
                }
                else
                {
                    a.Status = true;
                }
                DialogResult dialogResult = MessageBox.Show("Are You Sure To Add This Order ?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    orderManager.AddOrder(a);
                    LDGV();
                }
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

        private void btDeleteOrder_Click(object sender, EventArgs e)
        {
            if (tbBookID.Text.ToString() == "" || tbCustomerID.Text.ToString() == "")
            {
                MessageBox.Show("You must click a cell to delete!", "Error",
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
                DialogResult dialogResult = MessageBox.Show("Are You Sure To Delete This Order ?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    orderManager.AddOrder(a);
                    LDGV();
                }
            }
        }
    }
}
