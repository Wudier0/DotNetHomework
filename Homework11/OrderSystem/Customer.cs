using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Customer
    {
        public string Name { get; set; }

        public Customer( string name) {
            Name = name;
        }

        public Customer() { }

        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            return customer != null && Name == customer.Name;
        }

        public override string ToString()
        {
            return $"customerName:{Name}";
        }
    }
}
