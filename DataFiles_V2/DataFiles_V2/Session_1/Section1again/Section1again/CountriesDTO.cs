using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1again
{
    class CountriesDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CountriesDTO() { }
        public CountriesDTO(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}
