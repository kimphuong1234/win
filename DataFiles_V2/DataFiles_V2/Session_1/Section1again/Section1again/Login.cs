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
using System.Xml;

namespace Section1again
{
    public partial class Login : Form
    {

        public static DateTime timeLogin;

        public Login()
        {
            InitializeComponent();
        }
        static DataClasses1DataContext data = new DataClasses1DataContext();
        static int dem = 0;
        private int counter = 10;
        private System.Windows.Forms.Timer Timer;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User userdn = data.Users.SingleOrDefault(us => us.Email == txtUsername.Text && us.Password == txtPassword.Text);
            
            bool check = true;
            if(userdn != null)
            {
                check = userdn.Active.Value;
            }

            if(userdn != null)
            {
                if (!check)
                {
                    MessageBox.Show("User not active", "Notification");
                }
                else if(userdn.RoleID==1)
                {
                    Administrator ad = new Administrator();
                    timeLogin = DateTime.Now;
                    ad.Show();
                    this.Hide();
                }
                else
                {
                    AutomationSystem automation = new AutomationSystem();
                    automation.Tag = userdn;
                    timeLogin = DateTime.Now;
                    automation.Show();
                    this.Hide();
                }
            }
            else
            {
                dem++;
                MessageBox.Show("Incorrect username or password.", "Notification");

                this.txtUsername.Focus();
                if (dem % 3 == 0)
                {
                    MessageBox.Show("Please wait 10 seconds", "Notification");
                    btnLogin.Enabled = false;
                    Timer = new System.Windows.Forms.Timer(); //Khởi tạo đối tượng Timer mới

                    Timer.Tick += new EventHandler(timer1_Tick_1); //Tạo sự kiện aTimer_Tick

                    Timer.Interval = 1000; // thời gian ngắt quãng của Timer là 1 giây

                    Timer.Start(); //Bắt đầu khởi động Timer

                    label1.Text = counter.ToString(); //Hiển thị biến counter ra Label1
                }
            }
        }

        



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)//nếu bằng 0 thì dừng timer
            {
                Timer.Stop();
                label1.Text = counter.ToString();
                btnLogin.Enabled = true;
                //Counter = 10;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
