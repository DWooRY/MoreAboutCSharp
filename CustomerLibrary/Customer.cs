namespace CustomerLibrary
{
    public class Customer
    {
        public Guid Id { get; set; }
        public int CPhone { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }


        public Customer()
        {
            
        }

        public Customer(Guid id, int cphone)
        {
            this.Id = id;
            this.CPhone = cphone;
        }
        public Customer(Guid id, int cphone, string name, string surname)
        {
            this.Id = id;
            this.CPhone = cphone;
            this.Name = name;
            this.Surname = surname;
        }
        public void ShowCustomer()
        {
            Console.WriteLine($"Id: {Id} - CPhone: {CPhone} - Name: {Name} - Surname: {Surname} - Email: {Email}");
        }

        public void CPhoneUpdate(int newcphone)
        {
            this.CPhone = newcphone;
        }
    }
}
