using System;

namespace FVAT
{
    public class Product
    {
        public string ProductName { get; set; }
        public float Price { get; set; }
        public float Tax { get; set; }

        public Product(string productName, float price, float tax)
        {
            ProductName = productName;
            Price = price;
            Tax = tax;
        }

        public override string ToString()
        {
            var result = "Product: " + ProductName + "  Netto price: " + Price + "  Tax: " + Tax + "  Brutto price: "
                         + (Price + Tax);
            if (result == null) throw new ArgumentNullException(nameof(result));
            return result;
        }
    }
}