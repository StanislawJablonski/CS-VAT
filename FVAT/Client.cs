namespace FVAT
{
    public class Client:Person
    {
        public Client(string companyName, string country, string city, string street, string streetNumber,
            string postalCode, string nip)
        {
            CompanyName = companyName;
            Address.Country = country;
            Address.City = city;
            Address.Street = street;
            Address.StreetNumber = streetNumber;
            Address.PostalCode = postalCode;
            Nip = nip;
        }

        public override string ToString()
        {
            var result = "Company name: " + CompanyName + "\n" + Address + "\n" + "NIP: " + Nip;
            return result;
        }
    }
}