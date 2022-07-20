using System;
using System.Collections.Generic;
using FVAT;
using NUnit.Framework;

namespace FVATTest
{
    public class InvoiceTests
    {
        private Invoice _example;
        private Product _exampleProduct1;
        private Product _exampleProduct2;
        private Dictionary<Product, float> _exampleDictionary;


        [SetUp]
        public void Setup()
        {
            var exampleClient = new Client("Jan Kowalski Apartamenty", "Poland", "Gdansk", "Derdowskiego",
                "1", "80-300", "1234567890");
            var exampleSeller = new Seller("Stanislaw Jablonski Entertainment", "Poland", "Gdansk", "Slowackiego",
                "3", "80-999", "1122334455", "12340987000044442222");
            _exampleProduct1 = new Product("Chleb razowy", 1.99f, 0.20f);
            _exampleProduct2 = new Product("Bezcenne rozwiazania zadan na caly semestr", 999.99f, 229.98f);
            _exampleDictionary = new Dictionary<Product, float>();
            _exampleDictionary.Add(_exampleProduct1, 10);
            _exampleDictionary.Add(_exampleProduct2, 1);
            _example = new Invoice(_exampleDictionary, exampleClient, exampleSeller);
        }

        [Test]
        public void CheckIfTestWorks()
        {
            Assert.Pass();
        }

        [Test]
        public void CheckIfCanCreateInvoice()
        {
            Assert.That(_example, Is.Not.Null);
        }

        [Test]
        public void CheckIfInvoiceNumberIsAssigned()
        {
            var test = (Int32.Parse(_example.GeneratedNumber) >= 100000 && Int32.Parse(_example.GeneratedNumber) < 1000000);
            Assert.IsTrue(test);
        }

        [Test]
        public void CheckIfInvoiceDateIsAssigned()
        {
            Assert.That(_example.PurchaseDate, Is.EqualTo(DateTime.Today));
        }

        [Test]
        public void CheckIfPurchaseDateIsAssigned()
        {
            Assert.That(_example.PurchaseDate, Is.EqualTo(DateTime.Today));
        }

        [Test]
        public void CheckIfDeadlineDateIsAssigned()
        {
            Assert.That(_example.Deadline, Is.EqualTo(DateTime.Today.AddDays(14)));
        }

        [Test]
        public void CheckIfProductNumberIsCorrect()
        {
            Assert.That(_example.ProductList[_exampleProduct1], Is.EqualTo(10));
        }

        [Test]
        public void CheckIfHeaderWorks()
        {
            var result = "Invoice number: " + _example.GeneratedNumber + "\n" + "Date of invoice: " +
                         _example.DateOfInvoice + "\n" + "Selling date: "
                         + _example.PurchaseDate + "\n" + "Pay before: " + _example.Deadline + "\n" + "Seller:\n" +
                         _example.Seller + "\n"
                         + "Client:\n" + _example.Client + "\n";
            Assert.That(_example.Header(), Is.EqualTo(result));
        }

        [Test]
        public void CheckIfListProductsWorks()
        {
            var result = _exampleProduct1 + "\n" + "Number: " + 10 + "\n" +
                         "Netto price for this product: " + _exampleProduct1.Price * 10 + "\n" +
                         "Tax for this product: " + _exampleProduct1.Tax * 10
                         + "\n" + "Brutto price for this product: " +
                         (_exampleProduct1.Price + _exampleProduct1.Tax) * 10
                         + _exampleProduct2 + "\n" + "Number: " + 1 + "\n" +
                         "Netto price for this product: " + _exampleProduct2.Price * 1 + "\n" +
                         "Tax for this product: " + _exampleProduct2.Tax * 1
                         + "\n" + "Brutto price for this product: " +
                         (_exampleProduct2.Price + _exampleProduct2.Tax) * 1;
            
            Assert.That(_example.ListProducts(), Is.EqualTo(result));
        }

        [Test]
        public void CheckIfSummaryWorks()
        {
            var result = "\n" + "Overall netto price: "
                              + (_exampleProduct1.Price * 10 + _exampleProduct2.Price * 1) + "\n" + "Overall tax: " +
                              (_exampleProduct1.Tax * 10 + _exampleProduct2.Tax * 1) + "\n" +
                              "Overall brutto price: " + (_exampleProduct1.Price * 10 + _exampleProduct2.Price * 1 +
                                                          (_exampleProduct1.Tax * 10 + _exampleProduct2.Tax * 1));
            
            Assert.That(_example.Summary(), Is.EqualTo(result));
        }

        [Test]
        public void CheckIfToStringIsGeneratedCorrectly()
        {
            var result = "Invoice number: " + _example.GeneratedNumber + "\n" + "Date of invoice: " +
                         _example.DateOfInvoice + "\n" + "Selling date: "
                         + _example.PurchaseDate + "\n" + "Pay before: " + _example.Deadline + "\n" + "Seller:\n" +
                         _example.Seller + "\n"
                         + "Client:\n" + _example.Client + "\n"
                         + _exampleProduct1 + "\n" + "Number: " + 10 + "\n" +
                         "Netto price for this product: " + _exampleProduct1.Price * 10 + "\n" +
                         "Tax for this product: " + _exampleProduct1.Tax * 10
                         + "\n" + "Brutto price for this product: " +
                         (_exampleProduct1.Price + _exampleProduct1.Tax) * 10
                         + _exampleProduct2 + "\n" + "Number: " + 1 + "\n" +
                         "Netto price for this product: " + _exampleProduct2.Price * 1 + "\n" +
                         "Tax for this product: " + _exampleProduct2.Tax * 1
                         + "\n" + "Brutto price for this product: " +
                         (_exampleProduct2.Price + _exampleProduct2.Tax) * 1 + "\n" + "Overall netto price: "
                         + (_exampleProduct1.Price * 10 + _exampleProduct2.Price * 1) + "\n" + "Overall tax: " +
                         (_exampleProduct1.Tax * 10 + _exampleProduct2.Tax * 1) + "\n" +
                         "Overall brutto price: " + (_exampleProduct1.Price * 10 + _exampleProduct2.Price * 1 +
                                                     (_exampleProduct1.Tax * 10 + _exampleProduct2.Tax * 1));
            
            Assert.That(_example.ToString(), Is.EqualTo(result));
        }

        [Test]
        public void CheckIfToStringIsEqualSumOfItsSubmethods()
        {
            Assert.That(_example.ToString(), Is.EqualTo(_example.Header() + _example.ListProducts() + _example.Summary()));
        }
    }
}