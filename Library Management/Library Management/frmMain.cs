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
        List<Panel> listPanel = new List<Panel>();
        int index;
        public frmMain()
        {
            InitializeComponent();
        }
        private void LDGV()
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
            dataGridView3.DataSource = orderManager.GetOrderList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LibraryDbContext db = new LibraryDbContext();
            //Data for comboBox Category
            cbCategory.DataSource = db.Categories.Select(x => x.CateName).ToList();
            //Data for DataGridViewBook
            LDGV();
            //Panel 
            pnBook.BringToFront();
            pnBook.Show();

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
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        IExcelDataReader reader;
                        if (ofd.FilterIndex == 2)
                        {
                            reader = ExcelReaderFactory.CreateBinaryReader(stream);
                        }
                        else
                        {
                            reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                        }

                        dataGridView1.DataSource = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });
                        reader.Close();

                    }
                }
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btBookList_Click(object sender, EventArgs e)
        {
            pnCustomer.Visible = false;
            pnOrder.Visible = false;
            pnBook.BringToFront();
            pnBook.Show();
        }
        private void btCustomerList_Click(object sender, EventArgs e)
        {
            pnBook.Visible = false;
            pnOrder.Visible = false;
            pnCustomer.BringToFront();
            pnCustomer.Show();
        }
        private void btOrderList_Click(object sender, EventArgs e)
        {   pnBook.Visible = false;
            pnOrder.Visible = true;
            pnOrder.BringToFront();
            pnOrder.Show();
        }

        private void btAddNewCus_Click(object sender, EventArgs e)
        {
            frmCustomerDetail frmCustomerDetail = new frmCustomerDetail();
            frmCustomerDetail.ShowDialog();
        }
    }
}
