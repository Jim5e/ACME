using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class AddressRepo
    {
        public Address RetrieveAddress(int addressID)
        {
            //Assuming we are data accessing already
            var address = new Address(addressID);
            if (addressID == 1)
            {
                address.City = "Cebu";
                address.PostalCode = 1;
                address.Country = "Philippines";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveAddressbyCustomerId(int customerId)
        {
            var listOfAddresses = new List<Address>();

            var address1 = new Address(1)
            {
                City = "Cebu",
                PostalCode = 1,
                Country = "Philippines"
            };
            var address2 = new Address(1)
            {
                City = "LLC",
                PostalCode = 6015,
                Country = "Philippines"
            };
            var address3 = new Address(1)
            {
                City = "Manila",
                PostalCode = 2103,
                Country = "Philippines"
            };

            listOfAddresses.Add(address1);
            listOfAddresses.Add(address2);
            listOfAddresses.Add(address3);

            return listOfAddresses;
        }
    }
}
