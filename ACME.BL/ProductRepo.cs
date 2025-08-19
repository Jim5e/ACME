using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class ProductRepo
    {
        public Product RetrieveProduct(int productID) //Code that retrieves one product
        {
            //Assuming we are data accessing already
            var product = new Product(1);
            if (productID == 1)
            {
                product.ProductName = "Chippy's";
                product.ProductDescription = "Its Chips.";
                product.CurrentPrice = 15.99;
            }

            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }

        public bool Save(Product product)
        {
            var Success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // If prod is new, then we insert
                    }
                    else
                    {
                        // If it isnt, we update.
                    }

                }
                else
                {
                    Success = false;
                }
            }

            return Success;
        }
    }
}
