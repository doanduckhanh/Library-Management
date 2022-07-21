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
    public partial class frmBookList : Form
    {
        public frmBookList()
        {
            InitializeComponent();
        }

        private void frmBookList_Load(object sender, EventArgs e)
        {
            //Load Data for Book
            BookManager bookManager = new BookManager();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("idcol", "Id");
            dataGridView1.Columns["idcol"].DataPropertyName = "ID";
            dataGridView1.Columns.Add("namecol", "Name");
            dataGridView1.Columns["namecol"].DataPropertyName = "Name";
            dataGridView1.Columns.Add("catecol", "Category");
            dataGridView1.Columns["catecol"].DataPropertyName = "CategoryID";
            dataGridView1.Columns.Add("authorcol", "Author");
            dataGridView1.Columns["authorcol"].DataPropertyName = "Author";
            dataGridView1.Columns.Add("numcol", "Number");
            dataGridView1.Columns["numcol"].DataPropertyName = "Number";
            dataGridView1.Columns.Add("datecol", "EntryDate");
            dataGridView1.Columns["datecol"].DataPropertyName = "EntryDate";
            dataGridView1.Columns.Add("pricecol", "Price");
            dataGridView1.Columns["pricecol"].DataPropertyName = "Price";
            dataGridView1.DataSource = bookManager.GetBookList();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
