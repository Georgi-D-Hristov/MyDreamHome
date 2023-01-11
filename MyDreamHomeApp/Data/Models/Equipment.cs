namespace MyDreamHomeApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Equipment
    {
        public int Id { get; init; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Url { get; set; }

        public decimal Price { get; set; }

        [Required]
        public string Brand { get; set; }

        public string Picture { get; set; }

        public int RoomId { get; init; }

        public Room Room { get; init; }
    }
}
