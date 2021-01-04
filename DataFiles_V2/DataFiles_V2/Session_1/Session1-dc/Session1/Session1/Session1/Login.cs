using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            txtUsername.Focus();
        }
        static int dem = 0;
        //public static void Sleep(int millisecondsTimeout);
        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            DataClasses1DataContext db = new DataClasses1DataContext();
            
            var querryLogIn = from User in db.Users
                              where User.Email == txtUsername.Text && User.Password == txtPassword.Text
                              select User;

            bool check =true;
            if (querryLogIn.FirstOrDefault() != null)
            {
                 check = querryLogIn.FirstOrDefault().Active.Value;
            }

            if (querryLogIn.Count() == 0)
            {
                Dem++;
                textBox1.Text = Dem.ToString();
                MessageBox.Show("Incorrect username or password.", "Notification");
                
                this.txtUsername.Focus();
                if (Dem % 3 == 0) {

                    MessageBox.Show("Please wait 10 seconds", "Notification");
                    btnLogin.Enabled = false;
                    //btnExit.Enabled = false;
                    
                    timer1 = new System.Windows.Forms.Timer();
                        timer1.Tick += new EventHandler(timer1_Tick_1);
                        timer1.Interval = 1000; // 1 second
                        timer1.Start();
                        label1.Text = Counter.ToString();                    
                    //btnExit.Enabled = true;
                }
                //Thread.Sleep(10);
                label1.Text = " ";
                
            }

            else if (!check)
            {
                MessageBox.Show("User not active, please try again!!!", "Notification");
            } else {
                Administrator ad = new Administrator();
                this.Hide();
                ad.Show();
            }
        }
        private int counter = 10;

        public static int Dem { get => Dem1; set => Dem1 = value; }
        public int Counter { get => Counter1; set => Counter1 = value; }
        public static int Dem1 { get => dem; set => dem = value; }
        public int Counter1 { get => counter; set => counter = value; }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Counter--;
            if (Counter == 0)
            {
                timer1.Stop();
                label1.Text = Counter.ToString();
                btnLogin.Enabled = true;
                Counter = 10;
            }
               

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
