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
    }
}
