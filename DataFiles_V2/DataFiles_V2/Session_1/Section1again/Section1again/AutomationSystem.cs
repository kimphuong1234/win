using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Section1again
{
    public partial class AutomationSystem : Form
    { 
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        String tenfile = "login_log.xml";
        public AutomationSystem()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void AutomationSystem_Load(object sender, EventArgs e)
        {
            User userdn = (User)this.Tag;
            labelHello.Text = "Hi " + userdn.FirstName + ", Welcome to AMONIC Airlines.";
            hienthi(dataGridView1);
        }

        private void labelHello_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logLogin();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void logLogin()
        {
            User userdn = (User)this.Tag;
            if (!File.Exists(tenfile))
            {
                root = doc.CreateElement("log");
                doc.AppendChild(root);
                doc.Save(tenfile);
            }
            doc.Load(tenfile);
            root = doc.DocumentElement;
            XmlElement user = doc.CreateElement("user");

            root.AppendChild(user);

            XmlElement email = doc.CreateElement("email");
            email.InnerText = userdn.Email;
            user.AppendChild(email);

            XmlElement timelogin = doc.CreateElement("timeLogin");
            timelogin.InnerText = Login.timeLogin.ToString();
            user.AppendChild(timelogin);

            XmlElement timeout = doc.CreateElement("timeOut");
            timeout.InnerText = DateTime.Now.ToString();
            user.AppendChild(timeout);

            XmlElement timeonsystem = doc.CreateElement("timeOnSystem");
            timeonsystem.InnerText = (DateTime.Now - Login.timeLogin).ToString();
            user.AppendChild(timeonsystem);

            XmlElement reason = doc.CreateElement("reason");
            reason.InnerText = "";
            user.AppendChild(reason);

            XmlElement solution = doc.CreateElement("solution");
            solution.InnerText = "";
            user.AppendChild(solution);

            doc.Save(tenfile);


        }

        public void hienthi(DataGridView dg)
        {
            User userdn = (User)this.Tag;
            dg.Rows.Clear();
            doc.Load(tenfile);
            root = doc.DocumentElement;
            XmlNodeList list = root.SelectNodes("user");
            int i = 0;
            int timeHour = 0 ;
            int timeMinutes = 0;
            int timeSeconds = 0;
            int timeTranfer = 0;

            foreach (XmlNode item in list)
            {
                if(item.SelectSingleNode("email").InnerText == userdn.Email)
                {
                    dg.Rows.Add();
                    dg.Rows[i].Cells[0].Value = Convert.ToDateTime(item.SelectSingleNode("timeLogin").InnerText).ToString("dd/MM/yyyy");
                    dg.Rows[i].Cells[1].Value = Convert.ToDateTime(item.SelectSingleNode("timeLogin").InnerText).ToString("HH:mm:ss");
                    if(Convert.ToDateTime(item.SelectSingleNode("timeOut").InnerText).ToString("HH:mm:ss") == "HH:mm:ss")
                    {
                        dg.Rows[i].Cells[2].Value = Convert.ToDateTime(item.SelectSingleNode("timeOut").InnerText).ToString("HH:mm:ss");
                    }
                    else
                    {
                        monitoring_activities ma = new monitoring_activities();
                        ma.Show();
                        this.Hide();
                        break;
                        
                    }
                    dg.Rows[i].Cells[3].Value = Convert.ToDateTime(item.SelectSingleNode("timeOnSystem").InnerText).ToString("HH:mm:ss");
                    dg.Rows[i].Cells[4].Value = item.SelectSingleNode("reason").InnerText;
                    i++;
                    DateTime timeOnSystemValue = Convert.ToDateTime(item.SelectSingleNode("timeOnSystem").InnerText);
                    timeHour += timeOnSystemValue.Hour;
                    timeMinutes += timeOnSystemValue.Minute;
                    timeSeconds += timeOnSystemValue.Second;
                }               
            }
            timeTranfer = timeSeconds / 60;
            timeSeconds = timeSeconds % 60;
            timeMinutes += timeTranfer;
            timeTranfer = timeMinutes / 60;
            timeHour += timeTranfer;

            label3.Text = timeHour+":"+timeMinutes+":"+timeSeconds;
        }

        private void AutomationSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            logLoginerror();
        }

        private void logLoginerror()
        {
            User userdn = (User)this.Tag;
            if (!File.Exists(tenfile))
            {
                root = doc.CreateElement("log");
                doc.AppendChild(root);
                doc.Save(tenfile);
            }
            doc.Load(tenfile);
            root = doc.DocumentElement;
            XmlElement user = doc.CreateElement("user");

            root.AppendChild(user);

            XmlElement email = doc.CreateElement("email");
            email.InnerText = userdn.Email;
            user.AppendChild(email);

            XmlElement timelogin = doc.CreateElement("timeLogin");
            timelogin.InnerText = Login.timeLogin.ToString();
            user.AppendChild(timelogin);

            XmlElement timeout = doc.CreateElement("timeOut");
            timeout.InnerText = null;
            user.AppendChild(timeout);

            XmlElement timeonsystem = doc.CreateElement("timeOnSystem");
            timeonsystem.InnerText = null;
            user.AppendChild(timeonsystem);

            XmlElement reason = doc.CreateElement("reason");
            reason.InnerText = "";
            user.AppendChild(reason);

            XmlElement solution = doc.CreateElement("solution");
            solution.InnerText = "";
            user.AppendChild(solution);

            doc.Save(tenfile);


        }
    }
}
