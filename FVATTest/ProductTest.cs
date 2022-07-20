using FVAT;
using NUnit.Framework;

namespace FVATTest
{
    public class ProductTests
    {
        private Product _example;

        [SetUp]
        public void Setup()
        {
            _example = new Product("Chleb razowy", 1.99f, 0.20f);
        }

        [Test]
        public void CheckIfTestWorks()
        {
            Assert.Pass();
        }

        [Test]
        public void CheckIfCanCreate()
        {
            Assert.That(_example, Is.Not.Null);
        }

        [Test]
        public void CheckIfNameIsCorrect()
        {
            Assert.That(_example.ProductName, Is.EqualTo("Chleb razowy"));
        }

        [Test]
        public void CheckIfPriceIsCorrect()
        {
            Assert.That(_example.Price, Is.EqualTo(1.99f));
        }

        [Test]
        public void CheckIfTaxIsCorrect()
        {
            Assert.That(_example.Tax, Is.EqualTo(0.20f));
        }

        [Test]
        public void CheckIfNameCanBeChanged()
        {
            _example.ProductName = "Chleb zwykly";
            Assert.That(_example.ProductName, Is.EqualTo("Chleb zwykly"));
        }

        [Test]
        public void CheckIfPriceCanBeChanged()
        {
            _example.Price = 2.50f;
            Assert.That(_example.Price, Is.EqualTo(2.50f));
        }

        [Test]
        public void CheckIfTaxCanBeChanged()
        {
            _example.Tax = 0.30f;
            Assert.That(_example.Tax, Is.EqualTo(0.30f));
        }

        [Test]
        public void TestIfToStringWorks()
        {
            Assert.That(_example.ToString(), Is.EqualTo("Product: " + _example.ProductName + "  Netto price: " +
                                                        _example.Price + "  Tax: " + _example.Tax + "  Brutto price: "
                                                        + (_example.Price + _example.Tax)));
        }
    }
}