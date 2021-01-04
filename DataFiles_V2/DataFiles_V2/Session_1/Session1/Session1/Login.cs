using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        static int dem = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            session1Entities db = new session1Entities();
            
            var querryLogIn = from User in db.Users
                              where User.Email == txtUsername.Text && User.Password == txtPassword.Text 
                              select User;
            
            if (querryLogIn.Count() == 0 )
            {
                dem++;
                textBox1.Text = dem.ToString();
                MessageBox.Show("Please re-enter", "Notification");
                btnLogin.Enabled = true;
                this.txtUsername.Focus();
                if (dem % 3 == 0)
                {
                    
                    MessageBox.Show("Please wait 10 seconds", "Notification");
                    timer1 = new System.Windows.Forms.Timer();
                    timer1.Tick += new EventHandler(timer1_Tick_1);
                    timer1.Interval = 1000; // 1 second
                    timer1.Start();
                    label1.Text = counter.ToString();
                    //Thread.Sleep(10000);
                    
                    //
                    
                }
            }
            else if(querryLogIn.Count() == 1)
            {
                User user = (User) querryLogIn.Single();
                if (user.Active == false)
                {
                    MessageBox.Show("Not active", "Notification");
                }
                else
                {
                    Administrator ad = new Administrator();
                    this.Hide();
                    ad.Show();
                }
                
            }
            //btnLogin.Enabled = true;
        }
        private int counter = 10;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)

                timer1.Stop();
            label1.Text = counter.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = (MessageBox.Show("Do you want to exit?", "Notification",MessageBoxButtons.YesNo,MessageBoxIcon.Warning));
            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        
    }
}
