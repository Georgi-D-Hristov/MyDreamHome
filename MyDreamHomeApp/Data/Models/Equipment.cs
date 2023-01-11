namespace MyDreamHomeApp.Data.Models
{
    public class Equipment
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }

        public decimal Price { get; set; }

        public string Brand { get; set; }

        public string Picture { get; set; }

        public int RoomId { get; init; }

        public Room Room { get; init; }
    }
}
