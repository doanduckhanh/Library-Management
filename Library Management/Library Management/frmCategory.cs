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
using Library_Management.Models;
namespace Library_Management
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            CategoryManager categoryManager = new CategoryManager();
            string categoryName = tbCateName.Text.Trim();
            if (categoryManager.FindCate(categoryName) != null)
            {
                MessageBox.Show("The category was already exist!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ;
            } else
            {
                Category c = new Category();
                c.CateName = categoryName;
                categoryManager.AddCate(c);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
