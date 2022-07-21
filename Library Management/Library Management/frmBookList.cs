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
    public partial class frmBookList : Form
    {
        public frmBookList()
        {
            InitializeComponent();
        }
        private void LDGV()
        {
            BookManager bookManager = new BookManager();
            dataGridView1.DataSource = bookManager.GetBookList();
        }
        private void LoadEmpty()
        {
            //Load for combobox
            LibraryDbContext context = new LibraryDbContext();
            tbID.Text = "";
            tbTitle.Text = "";
            tbAuthor.Text = "";
            dtpEntryDate.MaxDate = DateTime.Now.Date;
            dtpEntryDate.Value = DateTime.Now.Date;
            cbCategory.DataSource = context.Categories.Select(x => x.CateName).ToList();
            cbSearchCate.DataSource = context.Categories.Select(x => x.CateName).ToList();
            cbSearchCate.SelectedIndex = 0;
            LDGV();
        }
        private void frmBookList_Load(object sender, EventArgs e)
        {
            //Load Data for Book
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
            LoadEmpty();          
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbID.Text = row.Cells[0].Value.ToString();
                tbTitle.Text = row.Cells[1].Value.ToString();
                cbCategory.SelectedIndex = Convert.ToInt32(row.Cells[2].Value);
                tbAuthor.Text = row.Cells[3].Value.ToString();
                nudNumber.Value = Convert.ToInt32(row.Cells[4].Value.ToString());
                dtpEntryDate.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
                nudPrice.Value = Convert.ToInt32(row.Cells[6].Value.ToString());
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(tbTitle.Text.ToString() == "" || tbAuthor.Text.ToString() == "" || nudNumber.Value == 0)
            {
                MessageBox.Show("You must input data to add!","Error", 
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                ;
            } else 
            {
                Book a = new Book();
                BookManager bookManager = new BookManager();
                a.Name = tbTitle.Text.Trim();
                a.CategoryId = cbCategory.SelectedIndex+1;
                a.Author = tbAuthor.Text.Trim();
                a.Number = Convert.ToInt32(nudNumber.Value);
                a.Price = Convert.ToInt32(nudPrice.Value);
                a.EntryDate = Convert.ToDateTime(dtpEntryDate.Value);
                bookManager.AddBook(a);
                LDGV();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("You must click a cell!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ;
            }
            else
            {
                Book a = new Book();
                BookManager bookManager = new BookManager();
                a.Id = Convert.ToInt32(tbID.Text);
                a.Name = tbTitle.Text.Trim();
                a.CategoryId = cbCategory.SelectedIndex + 1;
                a.Author = tbAuthor.Text.Trim();
                a.Number = Convert.ToInt32(nudNumber.Value);
                a.Price = Convert.ToInt32(nudPrice.Value);
                a.EntryDate = Convert.ToDateTime(dtpEntryDate.Value);
                DialogResult dialogResult = MessageBox.Show("Are You Sure To Update ?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bookManager.UpdateBook(a);
                    LoadEmpty();
                }          
             }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("You must click a cell!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ;
            }
            else
            {
                Book a = new Book();
                BookManager bookManager = new BookManager();
                a.Id = Convert.ToInt32(tbID.Text);
                a.Name = tbTitle.Text.Trim();
                a.CategoryId = cbCategory.SelectedIndex + 1;
                a.Author = tbAuthor.Text.Trim();
                a.Number = Convert.ToInt32(nudNumber.Value);
                a.Price = Convert.ToInt32(nudPrice.Value);
                a.EntryDate = Convert.ToDateTime(dtpEntryDate.Value);
                DialogResult dialogResult = MessageBox.Show("Are You Sure To Delete ?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bookManager.DeleteBook(a);
                    LoadEmpty();
                }              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            frmCategory.ShowDialog();
            LibraryDbContext context = new LibraryDbContext();
            cbCategory.DataSource = context.Categories.Select(x => x.CateName).ToList();
        }
    }
}
