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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void LDGV()
        {
            BookManager bookManager = new BookManager();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("namecol", "Id");
            dataGridView1.Columns["namecol"].DataPropertyName = "ID";
            dataGridView1.Columns.Add("malecol", "Name");
            dataGridView1.Columns["malecol"].DataPropertyName = "Name";
            dataGridView1.Columns.Add("malecol", "Category");

            dataGridView1.Columns.Add("malecol", "Author");
            dataGridView1.Columns["malecol"].DataPropertyName = "Author";
            dataGridView1.Columns.Add("malecol", "Number");
            dataGridView1.Columns["malecol"].DataPropertyName = "Number";
            dataGridView1.Columns.Add("malecol", "EntryDate");
            dataGridView1.Columns["malecol"].DataPropertyName = "EntryDate";
            dataGridView1.Columns.Add("malecol", "Price");
            dataGridView1.Columns["malecol"].DataPropertyName = "Price";
            dataGridView1.DataSource = bookManager.GetBookList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LibraryDbContext db = new LibraryDbContext();
            //Data for comboBox Category
            cbCategory.DataSource = db.Categories.Select(x => x.CateName).ToList();
            //Data for DataGridViewBook
            LDGV();

            //Panel 
            pnBook.Visible = true;
            pnCustomer.Visible = false;

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCustomerList_Click(object sender, EventArgs e)
        {
            LibraryDbContext db = new LibraryDbContext();
            pnBook.Visible = false;
            pnCustomer.Visible = true;
            dataGridView2.DataSource = db.Customers.ToList();
        }

        private void tbAddNew_Click(object sender, EventArgs e)
        {
            frmBookDetail bookDetail = new frmBookDetail();
            bookDetail.ShowDialog();
        }

        private void btBookList_Click(object sender, EventArgs e)
        {
            pnBook.Visible = true;
            pnCustomer.Visible = false;
        }
    }
}
