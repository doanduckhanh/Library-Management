using ExcelDataReader;
using Library_Management.Logics;
using Library_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void LDGV()
        {
            

            /*//Load Data for Customer
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
            //Load Data for Order
            OrderManager orderManager = new OrderManager();
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.Columns.Add("idcol", "Id");
            dataGridView3.Columns["idcol"].DataPropertyName = "OrID";
            dataGridView3.Columns.Add("cusidcol", "CustomerID");
            dataGridView3.Columns["cusidcol"].DataPropertyName = "CusID";
            dataGridView3.Columns.Add("bookidcol", "BookID");
            dataGridView3.Columns["bookidcol"].DataPropertyName = "BookID";
            dataGridView3.Columns.Add("startcol", "StartDate");
            dataGridView3.Columns["startcol"].DataPropertyName = "StartDat";
            dataGridView3.Columns.Add("endcol", "EndDate");
            dataGridView3.Columns["endcol"].DataPropertyName = "EndDate";
            dataGridView3.Columns.Add("statuscol", "Status");
            dataGridView3.Columns["statuscol"].DataPropertyName = "Status";
            dataGridView3.DataSource = orderManager.GetOrderList();*/
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void AddForm(Form f)
        {
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pnBook.Controls.Add(f);
            f.Show();
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void tbAddNew_Click(object sender, EventArgs e)
        {
            frmBookDetail bookDetail = new frmBookDetail();
            bookDetail.ShowDialog();
        }



        private void btImportCus_Click(object sender, EventArgs e)
        {
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
       


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookList f = new frmBookList();
            AddForm(f);
        }
    }
}
