using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class CustomerRepo
    {
         //Collaborative
        public CustomerRepo()
        {
            AddressRepo = new AddressRepo();
        }

        private AddressRepo AddressRepo {  get; set; }


        //Method only
        public Customer RetrieveCustomer(int customerId)
        {
            //Since we are only dealing with OOP and not data accessing, we are hardcoding for now.
            //Create instance of customer w/ requested Id
            Customer customer = new Customer(customerId);

            //--Code here for data accessing

            //--assuming we get something back
            if (customerId == 1)
            {
                customer.EmailAddress = "jim@gmail.com";
                customer.FirstName = "jim";
                customer.LastName = "dawg";
                customer.AddressList = AddressRepo.RetrieveAddressbyCustomerId(customerId).ToList();
            }

            return customer;
        }



    }
}
