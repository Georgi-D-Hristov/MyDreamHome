namespace MyDreamHomeApp.Data.Models
{
    public class Home
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Drawing { get; set; }

        public string Type { get; set; }

        public string Address { get; set; }

        public IEnumerable<Room> Rooms { get; set; }

    }
}
