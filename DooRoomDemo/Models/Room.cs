namespace DooRoomDemo.Models
{
    public class Room
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Type { get; set; } // string for now {maybe}

        public bool IsUnlocked { get; set; }
    }
}
