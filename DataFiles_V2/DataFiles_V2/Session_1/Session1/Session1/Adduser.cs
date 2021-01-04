using System;
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
    public partial class Adduser : Form
    {
        session1Entities db = new session1Entities();
        public Adduser()
        {
            InitializeComponent();
        }

        private void Adduser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'session1DataSet1.Offices' table. You can move, or remove it, as needed.
            this.officesTableAdapter.Fill(this.session1DataSet1.Offices);
            // TODO: This line of code loads data into the 'session1DataSet2.Offices' table. You can move, or remove it, as needed.

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Administrator ad = new Administrator();
            ad.Show();
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
                     
            User user = new User();
            user.FirstName = txtFirstname.Text;
            user.LastName = txtLastname.Text;
            user.Email = txtEmail.Text;
            user.Birthdate = dateTimePicker1.Value;
            user.Password = txtPassword.Text;
            user.OfficeID = Convert.ToInt32(cbOffice.SelectedValue.ToString());
            user.RoleID = 2;
            db.Users.Add(user);
            db.SaveChanges();

            MessageBox.Show("Saved", "Notification");


            Administrator ad = new Administrator();
            ad.Show();
            this.Dispose();

        }
    }
}
