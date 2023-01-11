namespace MyDreamHomeApp.Data.Models
{
    public class Furniture
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }

        public decimal Price { get; set; }
        public string Url { get; set; }

        public string Dimentions { get; set; }

        public string Type { get; set; }

        public int RoomId { get; init; }

        public Room Room { get; init; }
    }
}
