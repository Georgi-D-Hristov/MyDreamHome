namespace MyDreamHomeApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.Home;

    public class Home
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public string Drawing { get; set; }

        
        [MaxLength(TypeMaxLength)]
        public string Type { get; set; }

        public string Address { get; set; }

        public IEnumerable<Room> Rooms { get; set; } = new HashSet<Room>();

    }
}
