using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5.Entity
{
    public class Car
    {
        public int CarNo { get; set; }
        public string Model { get; set; }
        public string Kind { get; set; }
        public string Color { get; set; }
        public ICollection<Contact> contects { get; set; }
    }
}