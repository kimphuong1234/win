using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1again
{
    class OfficesDTO
    {
        public int ID { get; set; }
        public int CountryID { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Contact { get; set; }
        public OfficesDTO() { }
        public OfficesDTO(int ID, int CountryID, string Title, string Phone, string Contact)
        {
            this.ID = ID;
            this.CountryID = CountryID;
            this.Title = Title;
            this.Phone = Phone;
            this.Contact = Contact;
        }
    }
}
