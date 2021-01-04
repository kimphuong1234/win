﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class EditRole : Form
    {

        public EditRole()
        {
            InitializeComponent();
        }

        DataClasses1DataContext data = new DataClasses1DataContext();
        String idUser; //lấy đâu ra idUser

        public EditRole(string id, string email, string lastName, string office, string firstName, string roleID) :this()
        {
            txtEmail.Text = email;
            txtFirstname.Text = firstName;
            txtLastname.Text = lastName;
            cbbOffice.Text = office;
            if (roleID.Equals("2"))
            {
                rdbtnUser.Checked = true;
            } else rdbtnAdministrator.Checked = true;
            idUser = id;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrator frm = new Administrator();
            frm.Show();
            this.Close();
        }

        private void EditRole_Load(object sender, EventArgs e)
        {
            
        }

        private void Apply_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(idUser);

            var query = data.Users.SingleOrDefault(u => u.ID.Equals(id));
            if (query.RoleID.Equals(1))
            {
                query.RoleID = 2;
                data.SubmitChanges();
            }
            else
            {
                query.RoleID = 1;
                data.SubmitChanges();
            }
           
            Administrator frm = new Administrator();
            frm.Show();
            this.Close();
        }

     
    }
}