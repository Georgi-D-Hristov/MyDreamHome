namespace MyDreamHomeApp.Data.Models
{
    public class Idea
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string  Picture { get; set; }

        public int RoomId { get; init; }

        public Room Room { get; init; }
    }
}
