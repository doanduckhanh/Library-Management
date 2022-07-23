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
    public partial class frmBookDetail : Form
    {
        public frmBookDetail()
        {
            InitializeComponent();
        }
        
        public frmBookDetail(string id) : this()
        {
            string _id = id;
            tbID.Text = _id;
            tbID.ReadOnly = true;          
            BookManager bookManager = new BookManager();
            LibraryDbContext libraryDbContext = new LibraryDbContext();
            Book c = bookManager.GetBook(_id);
            tbTitle.Text = c.Name;
            cbCategory.DataSource = libraryDbContext.Categories.Select(x => x.CateName).ToList();
            cbCategory.SelectedIndex = c.CategoryId-1;
            tbAuthor.Text = c.Author;
            nudNumber.Value = Convert.ToDecimal(c.Number);
            dtpEntryDate.Value = c.EntryDate;
            nudPrice.Value = Convert.ToDecimal(c.Price);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text.ToString() == "" || tbAuthor.Text.ToString() == "" || nudNumber.Value == 0)
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
                    this.Close();
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text.ToString() == "" || tbAuthor.Text.ToString() == "" || nudNumber.Value == 0)
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
                    this.Close();
                }
            }
        }
    }
}
