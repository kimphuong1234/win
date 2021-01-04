using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Section1again
{
    class RolesDTO
    {
        public int ID { get; set; }
        public string Administrator { get; set; }
        public RolesDTO() { }
        public RolesDTO(int ID, string Administrator)
        {
            this.ID = ID;
            this.Administrator = Administrator;
        }
    }
}
