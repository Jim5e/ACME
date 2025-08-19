using ACME.Common;

namespace ACME.BL
{
    public class Customer : EntityBase, ILoggable
    {
        //properties
        public string? FirstName { get; set; } = "Default";
        public string? LastName { get; set; } = "Dan";
        public string? EmailAddress { get; set; } = null;
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }

        public static int InstanceCount { get; set; } = 0;

        //ctor
        public Customer(): this(0) { } 

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public string FullName
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName))
                {
                    return LastName + ", " + FirstName;
                }
                else if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    return FirstName;
                }
                else if (!string.IsNullOrWhiteSpace(LastName))
                {
                    return LastName;
                }
                else
                {
                    return "Please Input Fields.";
                }

            }
        }


        //methods
        public override bool Validate()
        {
            bool isValid = true;


            if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(FirstName)) { isValid = false; }

            return isValid;
        }

        public override string ToString()
        {
            return FullName;
        }

        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

    }
}
     