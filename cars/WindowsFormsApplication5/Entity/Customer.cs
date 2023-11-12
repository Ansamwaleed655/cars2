using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5.Entity
{
   public class Customer
    { 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phones { get; set; }
        public string Balance { get; set; }
        public ICollection<Contact> contacts{ get; set; }
       
    }
}
