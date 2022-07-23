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
            

            /*
            */
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

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerList f = new frmCustomerList();
            AddForm(f);
        }

        private void orderBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderList f = new frmOrderList();
            AddForm(f);
        }

        private void pendingOrderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPendingList f =new frmPendingList();
            AddForm(f);
        }
    }
}
