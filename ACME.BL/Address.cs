using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class Address
    {
        //ctor
        public Address(): this(0) { }

        public Address(int addressId)
        {
            AddressId = addressId;
        }
        //prop
        public int AddressId { get; private set; }
        public string? StreenLine1 { get; set; }
        public string? StreenLine2 { get; set; }
        public string? City { get; set; }
        public string? StateOrProvince { get; set; }
        public int PostalCode { get; set; }
            
        public string? Country { get; set; }
        public string? AddressType { get; set; }

        //methods
        public bool  Validate()
        {
            var isValid = true;

            if (PostalCode == -1){isValid = false;}

            return isValid;
        }

    }
}
