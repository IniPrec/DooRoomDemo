namespace DooRoomDemo.Models
{
    public class TaskItem
    {
        public Guid TaskId { get; set; }

        public string? TaskName { get; set; }

        public string? TaskDescription { get; set; }

        public List<string>? Keywords { get; set; }

        public bool TaskStatus { get; set; }
    }
}
