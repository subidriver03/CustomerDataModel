using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDataModel
{
    public class CustomerLike
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int LikeId { get; set; }
        public Like Like { get; set; }
    }
}
