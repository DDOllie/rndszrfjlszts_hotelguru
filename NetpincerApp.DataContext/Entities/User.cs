namespace HotelGuru.DataContext.Entities
{
    abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int CreditCard { get; set; }
    }
}