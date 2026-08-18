namespace DooRoomDemo.Models
{
    public class House
    {
        public Guid Id { get; set; }

        public List<Room>? Rooms { get; set; }
    }
}
