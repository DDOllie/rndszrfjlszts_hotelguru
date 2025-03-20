namespace HotelGuru.DataContext.Entities
{
    public class Rooms
    {
        public int AvailableRoomCount { get; set; }
        public int BookedRoomCount { get; set; }
        public List<Room> RoomList { get; set; }

    }
}
