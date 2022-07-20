using System;

namespace FVAT
{
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }

        public Address()
        {
        }

        public Address(string country, string city, string street, string streetNumber, string postalCode)
        {
            Country = country;
            City = city;
            Street = street;
            StreetNumber = streetNumber;
            PostalCode = postalCode;
        }

        public override string ToString()
        {
            var result = "Country: " + Country + "  " + "City: " + City + "  " + "Street: " + Street + " " +
                         StreetNumber + " Postal code: " + PostalCode;
            if (result == null) throw new ArgumentNullException(nameof(result));
            return result;
        }
    }
}