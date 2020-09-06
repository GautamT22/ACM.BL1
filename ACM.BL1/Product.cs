using Acme1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL1
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {
               
        }

        public Product(int productId)
        {
            ProductId = productId;

        }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get;private set; }
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

        //string InsertSpaces(string source)
        //{
        //    var source = ProductName;
        //}

        public string Log() =>
          $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";
        public override string ToString() => ProductName;
        

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;

        }
    }
}
