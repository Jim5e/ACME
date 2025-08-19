using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class OrderItem
    {
        //ctor
        public OrderItem() { }
        public OrderItem(int orderItem)
        {
            OrderItemId = orderItem;
        }

        //fields
        public int OrderItemId { get; private set; }
        public string? Product { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        //methods
        public void Validate()
        {

        }

        public void Retrieve()
        {

        }

    }
}
