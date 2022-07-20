using FVAT;
using NUnit.Framework;

namespace FVATTest
{
    public class AddressTests
    {
        private Address _example;

        [SetUp]
        public void Setup()
        {
            _example = new Address("Poland", "Gdansk", "Derdowskiego", "1", "80-300");
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
        public void CheckIfStreetIsCorrect()
        {
            Assert.That(_example.Street, Is.EqualTo("Derdowskiego"));
        }

        [Test]
        public void CheckIfStreetNumberIsCorrect()
        {
            Assert.That(_example.StreetNumber, Is.EqualTo("1"));
        }

        [Test]
        public void CheckIfCityIsCorrect()
        {
            Assert.That(_example.City, Is.EqualTo("Gdansk"));
        }

        [Test]
        public void CheckIfPostalCodeIsCorrect()
        {
            Assert.That(_example.PostalCode, Is.EqualTo("80-300"));
        }

        [Test]
        public void CheckIfStreetCanBeChanged()
        {
            _example.Street = "Tetmajera";
            Assert.That(_example.Street, Is.EqualTo("Tetmajera"));
        }

        [Test]
        public void CheckIfStreetNumberCanBeChanged()
        {
            _example.StreetNumber = "2";
            Assert.That(_example.StreetNumber, Is.EqualTo("2"));
        }

        [Test]
        public void CheckIfCityCanBeChanged()
        {
            _example.City = "Gdynia";
            Assert.That(_example.City, Is.EqualTo("Gdynia"));
        }

        [Test]
        public void CheckIfPostalCodeCanBeChanged()
        {
            _example.PostalCode = "80-299";
            Assert.That(_example.PostalCode, Is.EqualTo("80-299"));
        }

        [Test]
        public void CheckIfToStringWorks()
        {
            Assert.That(_example.ToString(), Is.EqualTo("Country: " + _example.Country + "  " + "City: " +
                                                        _example.City + "  " + "Street: " + _example.Street + " " +
                                                        _example.StreetNumber + " Postal code: " + _example.PostalCode));
        }
    }
}