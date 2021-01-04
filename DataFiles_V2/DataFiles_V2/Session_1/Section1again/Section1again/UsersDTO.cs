using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section1again
{
    class UsersDTO
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int OfficeID { get; set; }
        public DateTime Birthdate { get; set; }
        public bool Active { get; set; }
        public UsersDTO() { }
        public UsersDTO(int ID, int RoleID, string Email, string Password, string Firstname, string Lastname, int OfficeID, DateTime Birthdate, bool Active)
        {
            this.ID = ID;
            this.RoleID = RoleID;
            this.Email = Email;
            this.Password = Password;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.OfficeID = OfficeID;
            this.Birthdate = Birthdate;
            this.Active = Active;
        }

    }
}
