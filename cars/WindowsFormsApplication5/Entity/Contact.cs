using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5.Entity
{
    public  class Contact
    {
        public int ContNo { get; set; }
        public DateTime Date { get; set; }
        public string duration { get; set; }
        public decimal priceorday { get; set; }
        public decimal total { get; set; }
        public int CarNo { get; set; }
        public int CustomerNo { get; set; }
        public Car car { get; set; }
        public Customer customer { get; set; }
    }
}
