using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDataModel
{
    public class Address
    {
        public int AddressId { get; set; }
        public string FullAddress { get; set; }
        public List<CustomerAddress> Customers { get; set; } = new List<CustomerAddress>();
    }

    public class CustomerAddress
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }

}
