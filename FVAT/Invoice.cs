using System;
using System.Collections.Generic;

namespace FVAT
{
    public class Invoice
    {
        public Dictionary<Product, float> ProductList;
        public Client Client { get; }
        public Seller Seller { get; set; }
        public string GeneratedNumber;
        public DateTime DateOfInvoice;
        public DateTime PurchaseDate;
        public DateTime Deadline;

        public Invoice(Dictionary<Product, float> productList, Client client, Seller seller)
        {
            ProductList = productList;
            Client = client;
            Seller = seller;
            DateOfInvoice = DateTime.Today.Date;
            PurchaseDate = DateTime.Today.Date;
            Deadline = DateTime.Today.Date.AddDays(14);
            Random rnd = new Random();
            GeneratedNumber = rnd.Next(100000, 1000000).ToString();
        }

        public string Header()
        {
            string result = "Invoice number: " + GeneratedNumber + "\n" + "Date of invoice: " + DateOfInvoice + "\n" +
                            "Selling date: "
                            + PurchaseDate + "\n" + "Pay before: " + Deadline + "\n" + "Seller:\n" + Seller + "\n"
                            + "Client:\n" + Client + "\n";
            return result;
        }
        
        public string ListProducts()
        {
            string result = "";
            
            foreach (var key in ProductList.Keys)
                result = result + key + "\n" + "Number: " + ProductList[key] + "\n" +
                         "Netto price for this product: " + key.Price * ProductList[key] + "\n" +
                         "Tax for this product: " + key.Tax * ProductList[key]
                         + "\n" + "Brutto price for this product: " + (key.Price + key.Tax) * ProductList[key];
            
            return result;
        }
        
        public string Summary()
        {
            string result;
            
            float priceNetto = 0, tax = 0;
            foreach (var key in ProductList.Keys)
            {
                priceNetto += key.Price * ProductList[key];
                tax += key.Tax * ProductList[key];
            }

            result = "\n" + "Overall netto price: " + priceNetto + "\n" + "Overall tax: " + tax + "\n" +
                     "Overall brutto price: " + (priceNetto + tax);
            
            return result;
        }

        public override string ToString()
        {
            var result = Header() + ListProducts() + Summary();

            return result;
        }
    }
}