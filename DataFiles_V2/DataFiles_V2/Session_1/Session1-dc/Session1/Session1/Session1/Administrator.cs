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
        
        static DataClasses1DataContext data = new DataClasses1DataContext();

        User user = new User();
        Role role = new Role();
        private void Administrator_Load(object sender, EventArgs e)
        {
            hienthi();
            dgvUsers.Columns["Active"].Visible = false;
            dgvUsers.Columns["iD"].Visible = false;
            dgvUsers.Columns["roleID"].Visible = false;
            checkActiveGridView(dgvUsers);
        }

        public void checkActiveGridView(DataGridView grd)
        {
            for (int i = 0; i < grd.Rows.Count; i++)
            {
                if (grd.Rows[i].Cells["Active"].Value.Equals(false))
                {
                    grd.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (grd.Rows[i].Cells["UserRole"].Value.Equals("Administrator"))
                {
                    grd.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }

            }
        }

        public void hienthi()
        {
            //var query = data.Users.Select(office => new
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

            var query_office = from office in data.Offices
                        select office;
            comboBox1.DataSource = query_office;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "Title";

            DateTime d = DateTime.Now;
            //string age = user.Birthdate.ToString();
            //string ag = age.Substring(0, 4);
            var query = from user in data.Users

                        select new
                        {
                            iD = user.ID,
                            Name = user.FirstName,
                            Lastname = user.LastName,
                            //Age = (d.Year - Convert.ToInt32(ag)),
                            Age = user.Birthdate,
                            roleID = user.Role.ID,
                            UserRole = user.Role.Title,
                            Email = user.Email,
                            Office = user.Office.Title,
                            Active = user.Active
                        };

            dgvUsers.DataSource = query;
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

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            EditRole edit = new EditRole();
            this.Hide();
            edit.Show();

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var query = from user in data.Users
                        where user.Office.Title == comboBox1.SelectedValue.ToString()
                        select new
                        {
                            iD = user.ID,
                            Name = user.FirstName,               
                            Lastname = user.LastName,
                            Age = user.Birthdate,
                            UserRole = user.Role.Title,
                            roleID = user.Role.ID,
                            Email = user.Email,
                            Office = user.Office.Title,
                            Active = user.Active
                        };

            dgvUsers.DataSource = query;
        }

        private void btnEnableDisable_Click(object sender, EventArgs e)
        {
            int index = dgvUsers.CurrentCell.RowIndex;
            
            int id = Convert.ToInt32(dgvUsers.Rows[index].Cells["iD"].Value);

            var query = data.Users.SingleOrDefault(u => u.ID.Equals(id));
            if (query.Active.Equals(false))
            {
                query.Active = true;
                data.SubmitChanges();
            } else
            {
                query.Active = false;
                data.SubmitChanges();
            }
            hienthi();
            checkActiveGridView(dgvUsers);

        }

        private void btnChangeRole_Click_1(object sender, EventArgs e)
        {
            try
            {
                int index = dgvUsers.CurrentCell.RowIndex;

                String id = (dgvUsers.Rows[index].Cells["iD"].Value).ToString();
                String email = (dgvUsers.Rows[index].Cells["Email"].Value).ToString();
                String lastName = (dgvUsers.Rows[index].Cells["Lastname"].Value).ToString();
                String firstName = (dgvUsers.Rows[index].Cells["Name"].Value).ToString();
                String office = (dgvUsers.Rows[index].Cells["Office"].Value).ToString();
                String roleID = dgvUsers.Rows[index].Cells["roleID"].Value.ToString();
                EditRole frm = new EditRole(id, email, lastName, office, firstName, roleID);
                frm.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose rows");

            }

        }
    }

}
