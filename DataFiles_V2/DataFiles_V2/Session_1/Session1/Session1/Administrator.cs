using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }
        
        static session1Entities data = new session1Entities();

        User user = new User();
        Role role = new Role();
        private void Administrator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'session1DataSet.Offices' table. You can move, or remove it, as needed.
            this.officesTableAdapter.Fill(this.session1DataSet.Offices);
            hienthi();
        }

        public void hienthi()
        {

            //User user = data.Users.Where(p => p.FirstName == "a").Select(p => p).Single();
            //data.Users.Remove(user);
            //data.SaveChanges();

            //var query = 
            //{
            //    office.ID,
            //    office.Title,
            //    office.Phone,
            //    office.Contact
            //}).ToList();
            //dgvUsers.DataSource = query;

            //var query = from u in data.Users
            //            select new
            //            {
            //                Name = u.FirstName,
            //                Lastname = u.LastName,
            //                //Age = (d.Year - Convert.ToInt32(age[2])),
            //                Age = u.Birthdate,
            //                UserRole = role.Title,
            //                Office = office.Title
            //            };
            //dgvUsers.DataSource = query;

            try
            {
                List<User> listuser = data.Users.Select(p => p).ToList();

                dgvUsers.Rows.Clear();
                dgvUsers.ColumnCount = 7;
                dgvUsers.Columns[6].Visible = false;
                int count = 0;
                foreach (var item in listuser)
                {
                    dgvUsers.Rows.Add();
                    dgvUsers.Rows[count].Cells[0].Value = item.FirstName;
                    dgvUsers.Rows[count].Cells[1].Value = item.LastName;
                    DateTime dt = (DateTime)item.Birthdate;
                    int ns = Convert.ToInt32(dt.ToString("yyyy"));
                    int age = 2021 - ns;
                    dgvUsers.Rows[count].Cells[2].Value = age;
                    dgvUsers.Rows[count].Cells[3].Value = item.Role.Title;
                    dgvUsers.Rows[count].Cells[4].Value = item.Email;
                    dgvUsers.Rows[count].Cells[5].Value = item.Office.Title;
                    dgvUsers.Rows[count].Cells[6].Value = item.Active;

                    if (item.Active.ToString() == "False")
                    {
                        for (int i = 0; i <= 6; i++)
                        {
                            dgvUsers.Rows[count].Cells[i].Style.BackColor = Color.Red;
                        }

                    }
                    count++;
                }


            }
            catch { }
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form op = Application.OpenForms["Adduser"];
            if (op != null)
            {
                op.Show();
            }
            else
            {
                Adduser addu = new Adduser();
                this.Hide();
                addu.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChangeRole_Click_1(object sender, EventArgs e)
        {
            EditRole edit = new EditRole();
            this.Hide();
            edit.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                List<User> listuser = data.Users.Where(p => p.Office.ID.ToString() == comboBox1.SelectedValue.ToString()).Select(p => p).ToList();

                dgvUsers.Rows.Clear();
                dgvUsers.ColumnCount = 7;
                dgvUsers.Columns[6].Visible = false;
                int count = 0;
                foreach (var item in listuser)
                {
                    dgvUsers.Rows.Add();
                    dgvUsers.Rows[count].Cells[0].Value = item.FirstName;
                    dgvUsers.Rows[count].Cells[1].Value = item.LastName;
                    DateTime dt =(DateTime) item.Birthdate;
                    int ns = Convert.ToInt32( dt.ToString("yyyy"));
                    int age = 2021 - ns; 
                    dgvUsers.Rows[count].Cells[2].Value = age;
                    dgvUsers.Rows[count].Cells[3].Value = item.Role.Title;
                    dgvUsers.Rows[count].Cells[4].Value = item.Email;
                    dgvUsers.Rows[count].Cells[5].Value = item.Office.Title;
                    dgvUsers.Rows[count].Cells[6].Value = item.Active;

                    if (item.Active.ToString() == "False")
                    {
                        for (int i = 0; i <= 6; i++)
                        {
                            dgvUsers.Rows[count].Cells[i].Style.BackColor = Color.Red;
                        }

                    }
                    count++;
                }
            

            }
            catch { }
        }

        
    }

}
