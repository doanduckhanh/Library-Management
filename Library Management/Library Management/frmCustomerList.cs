using Library_Management.Logics;
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
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            //Load Data for Customer
            CustomerManager customerManager = new CustomerManager();
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Add("idcol", "Id");
            dataGridView2.Columns["idcol"].DataPropertyName = "CusID";
            dataGridView2.Columns.Add("namecol", "Name");
            dataGridView2.Columns["namecol"].DataPropertyName = "Name";
            dataGridView2.Columns.Add("addresscol", "Address");
            dataGridView2.Columns["addresscol"].DataPropertyName = "Address";
            dataGridView2.Columns.Add("statecol", "State");
            dataGridView2.Columns["statecol"].DataPropertyName = "State";
            dataGridView2.Columns.Add("citycol", "City");
            dataGridView2.Columns["citycol"].DataPropertyName = "City";
            dataGridView2.Columns.Add("malecol", "Male");
            dataGridView2.Columns["malecol"].DataPropertyName = "Gender";
            dataGridView2.Columns.Add("dobcol", "Dob");
            dataGridView2.Columns["dobcol"].DataPropertyName = "Birth";
            dataGridView2.Columns.Add("phonecol", "Phone");
            dataGridView2.Columns["phonecol"].DataPropertyName = "Phone";
            dataGridView2.Columns.Add("emailcol", "Email");
            dataGridView2.Columns["emailcol"].DataPropertyName = "Email";
            dataGridView2.DataSource = customerManager.GetCusList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCusDetail frmCusDetail = new frmCusDetail();
            frmCusDetail.ShowDialog();
            CustomerManager customerManager = new CustomerManager();
            dataGridView2.DataSource = customerManager.GetCusList();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                frmCusDetail Child = new frmCusDetail(row.Cells[0].Value.ToString());
                Child.ShowDialog();
            }
            CustomerManager customerManager = new CustomerManager();
            dataGridView2.DataSource = customerManager.GetCusList();
        }
        private class RowComparer : System.Collections.IComparer
        {
            private static int sortOrderModifier = 1;

            public RowComparer(SortOrder sortOrder)
            {
                if (sortOrder == SortOrder.Descending)
                {
                    sortOrderModifier = -1;
                }
                else if (sortOrder == SortOrder.Ascending)
                {
                    sortOrderModifier = 1;
                }
            }

            public int Compare(object x, object y)
            {
                DataGridViewRow DataGridViewRow1 = (DataGridViewRow)x;
                DataGridViewRow DataGridViewRow2 = (DataGridViewRow)y;

                // Try to sort based on the Last Name column.
                int CompareResult = System.String.Compare(
                    DataGridViewRow1.Cells[1].Value.ToString(),
                    DataGridViewRow2.Cells[1].Value.ToString());

                // If the Last Names are equal, sort based on the First Name.
                if (CompareResult == 0)
                {
                    CompareResult = System.String.Compare(
                        DataGridViewRow1.Cells[0].Value.ToString(),
                        DataGridViewRow2.Cells[0].Value.ToString());
                }
                return CompareResult * sortOrderModifier;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            CustomerManager customerManager = new CustomerManager();
            dataGridView2.DataSource = customerManager.SearchCustomer(cbSearch.Text, tbSearch.Text);
        }
    }
}
