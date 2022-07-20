namespace FVAT
{
    public class Person
    {
        public string CompanyName { get; set; }
        public Address Address { get; set; } = new();
        public string Nip { get; set; }

        protected Person()
        {
        }
    }
}