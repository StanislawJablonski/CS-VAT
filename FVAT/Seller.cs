using System;

namespace FVAT
{
    public class Seller:Person
    { 
        public string BankAcc { get; set; }

        public Seller(string companyName, string country, string city, string street, string streetNumber,
            string postalCode, string nip, string bankAcc)
        {
            CompanyName = companyName;
            Address.Country = country;
            Address.City = city;
            Address.Street = street;
            Address.StreetNumber = streetNumber;
            Address.PostalCode = postalCode;
            Nip = nip;
            BankAcc = bankAcc;
        }

        public override string ToString()
        {
            var result = "Company name: " + CompanyName + "\n" + Address + "\n" + "NIP: " + Nip + "\n" +
                         "Bank account number: " + BankAcc;
            if (result == null) throw new ArgumentNullException(nameof(result));
            return result;
        }
    }
}