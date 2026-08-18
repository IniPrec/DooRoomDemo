namespace DooRoomDemo.Models
{
    public class Room
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public List<string>? Type { get; set; } 

        public bool IsUnlocked { get; set; }
    }
}
