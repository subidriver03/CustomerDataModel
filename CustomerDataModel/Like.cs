using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDataModel
{
    public class Like
    {
        public int LikeId { get; set; }
        public string Description { get; set; }
        public List<CustomerLike> Customers { get; set; } = new List<CustomerLike>();
    }

}
