using ACME.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class Product : EntityBase, ILoggable
    {
        public int ProductID { get; private set; }
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        public string? ProductDescription { get; set;}
        public double? CurrentPrice {  get; set; }

        public Product() : this(0) { }
        public Product(int productId) => ProductID = productId;

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log() => $"{ProductID}: {ProductName} Desc: {ProductDescription} Status: {EntityState.ToString()}";

    }
}
