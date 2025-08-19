using ACME.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class Order : EntityBase, ILoggable
    {
        //ctor
        public Order() { }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        //properties
        public int OrderId { get; private set; }
        public DateOnly OrderDate { get;  set; }
        public string? ShippingAddress { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
        

        //methods
        public void ValidateProps()
        {

        }

        public override string ToString()
        {
            return $"{OrderDate} : ({OrderId})";
        }

        public override bool Validate()
        {
            bool isValid = true;


            if (OrderId != -1) { isValid = false; }

            return isValid;
        }

        public string Log() => $"{OrderId}: Date: {OrderDate} Status: {EntityState.ToString()}";

    }
}
