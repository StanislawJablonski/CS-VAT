using FVAT;
using NUnit.Framework;

namespace FVATTest
{
    public class SellerTests
    {
        private Seller _example;

        [SetUp]
        public void Setup()
        {
            _example = new Seller("Jan Kowalski Apartamenty", "Poland", "Gdansk", "Derdowskiego",
                "1", "80-300", "1234567890", "12340000456789101234");
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
        public void CheckIfCanCreateAddress()
        {
            Assert.That(_example.Address, Is.Not.Null);
        }

        [Test]
        public void CheckIfNameIsCorrect()
        {
            Assert.That(_example.CompanyName, Is.EqualTo("Jan Kowalski Apartamenty"));
        }

        [Test]
        public void CheckIfTaxNumberIsCorrect()
        {
            Assert.That(_example.Nip, Is.EqualTo("1234567890"));
        }

        [Test]
        public void CheckIfAccountIsCorrect()
        {
            Assert.That(_example.BankAcc, Is.EqualTo("12340000456789101234"));
        }

        [Test]
        public void CheckIfStreetIsCorrect()
        {
            Assert.That(_example.Address.Street, Is.EqualTo("Derdowskiego"));
        }

        [Test]
        public void CheckIfStreetNumberIsCorrect()
        {
            Assert.That(_example.Address.StreetNumber, Is.EqualTo("1"));
        }

        [Test]
        public void CheckIfCityIsCorrect()
        {
            Assert.That(_example.Address.City, Is.EqualTo("Gdansk"));
        }

        [Test]
        public void CheckIfPostalCodeIsCorrect()
        {
            Assert.That(_example.Address.PostalCode, Is.EqualTo("80-300"));
        }

        [Test]
        public void CheckIfNameCanBeChanged()
        {
            _example.CompanyName = "John Kowalski Apartamens";
            Assert.That(_example.CompanyName, Is.EqualTo("John Kowalski Apartamens"));
        }

        [Test]
        public void CheckIfStreetCanBeChanged()
        {
            _example.Address.Street = "Tetmajera";
            Assert.That(_example.Address.Street, Is.EqualTo("Tetmajera"));
        }

        [Test]
        public void CheckIfStreetNumberCanBeChanged()
        {
            _example.Address.StreetNumber = "2";
            Assert.That(_example.Address.StreetNumber, Is.EqualTo("2"));
        }

        [Test]
        public void CheckIfCityCanBeChanged()
        {
            _example.Address.City = "Gdynia";
            Assert.That(_example.Address.City, Is.EqualTo("Gdynia"));
        }

        [Test]
        public void CheckIfPostalCodeCanBeChanged()
        {
            _example.Address.PostalCode = "80-299";
            Assert.That(_example.Address.PostalCode, Is.EqualTo("80-299"));
        }

        [Test]
        public void CheckIfTaxNumberCanBeChanged()
        {
            _example.Nip = "1234567890";
            Assert.That(_example.Nip, Is.EqualTo("1234567890"));
        }

        [Test]
        public void CheckIfAccountCanBeChanged()
        {
            _example.BankAcc = "12344567891012340000";
            Assert.That(_example.BankAcc, Is.EqualTo("12344567891012340000"));
        }

        [Test]
        public void CheckIfToStringWorks()
        {
            Assert.That(_example.ToString(),
                Is.EqualTo("Company name: " + _example.CompanyName + "\n" + _example.Address + "\n" + "NIP: " +
                           _example.Nip + "\n" + "Bank account number: " + _example.BankAcc));
        }
    }
}