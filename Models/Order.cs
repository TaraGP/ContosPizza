using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosPizza.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaces { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId {get; set; }
        public Customer Customer { get; set; } = null!;
        public ICollection<OrderDetail> OrderDeatils { get; set; } = null!;

    }
}
