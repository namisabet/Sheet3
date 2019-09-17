using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Entity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNum { get; set; }
        public string HomeNum { get; set; }
        public string BusinessNum { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }


    }
}
