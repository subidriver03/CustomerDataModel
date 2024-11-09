using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDataModel
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
        public List<CustomerAddress> Addresses { get; set; } = new List<CustomerAddress>();
        public string Email { get; set; }
        public List<CustomerLike> Likes { get; set; } = new List<CustomerLike>();
    }
}