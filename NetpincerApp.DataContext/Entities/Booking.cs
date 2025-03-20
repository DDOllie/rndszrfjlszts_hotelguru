namespace NetPincerApp.DataContext.Entities
{
    public class Booking
    {
        public int BookingID { get; set; }
        public DateTime BookingDate { get; set; }
        public int BookedRoomID { get; set; }
        public bool ValidCreditCard { get; set; }
    }
}
