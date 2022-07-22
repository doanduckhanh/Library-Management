﻿using Library_Management.Logics;
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
    public partial class frmCusDetail : Form
    {
        public frmCusDetail()
        {
            InitializeComponent();
        }

        private void BookDetail_Load(object sender, EventArgs e)
        {
            rbMale.Checked = true;
            dtpDob.MaxDate = DateTime.Now.Date;
            dtpDob.Value = DateTime.Now.Date;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(tbID.Text == "" || tbFullName.Text == "" || tbAddress.Text == "" || tbState.Text == ""
                || tbCity.Text == "" || tbPhone.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("You must input data to add!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ;
            } else
            {
                CustomerManager customerManager = new CustomerManager();
                Customer c =new Customer();
                c.CusId = tbID.Text;
                c.Name = tbFullName.Text;
                c.Address = tbAddress.Text;
                c.State = tbState.Text;
                c.City = tbCity.Text;
                if(rbMale.Checked == true)
                {
                    c.Gender = true;
                } else
                {
                    c.Gender = false;
                }
                c.Birth = dtpDob.Value;
                c.Phone = tbPhone.Text;
                c.Email = tbEmail.Text;
                DialogResult dialogResult = MessageBox.Show("Are You Sure To Add This Customer ?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    customerManager.AddCus(c);
                    this.Close();
                }
            }
            
        }
    }
}
