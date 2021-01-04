using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    class OfficesDTO
    {
        public int ID { set; get; }
        public int CountryID { set; get; }
        public string Title { set; get; }
        public string Phone { set; get; }
        public string Contact { set; get; }

        public OfficesDTO(){}
        public OfficesDTO(int id, int countryid, string title, string phone, string contact)
        {
            this.ID = id;
            this.CountryID = countryid;
            this.Title = title;
            this.Phone = phone;
            this.Contact = contact;
        }
        
    }
}
