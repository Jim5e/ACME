using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class OrderRepo
    {
        public Order RetrieveOrder(int orderId) 
        {
            //Since we are only dealing with OOP and not data accessing, we are hardcoding for now.
            //Create instance of customer w/ requested Id
            var Order = new Order(orderId);

            //--Code here for data accessing

            //--assuming we get something back
            var dateOnly = DateOnly.FromDateTime(DateTime.Now);
            if (orderId == 1)
            {
                Order.OrderDate = dateOnly;
                Order.ShippingAddress = "LAPU LAPU";
                Order.OrderItems = null;
            }

            return Order;
        }
  
    }
}
