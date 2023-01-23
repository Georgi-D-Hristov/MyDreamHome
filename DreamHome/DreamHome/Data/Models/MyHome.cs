namespace DreamHomeApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.Home;

    public class MyHome
    {
        public int Id { get; init; }

        [Required]
        [StringLength(
                  NameMinLength,
                  ErrorMessage = "Name should be between {0} and {1} characters."),
                  MaxLength(NameMaxLength)]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? Drawing { get; set; }


        [Required]
        [StringLength(
           TypeMinLength,
           ErrorMessage = "Type should be between {0} and {1} characters."),
           MaxLength(TypeMaxLength)]
        public string? Type { get; set; }

        public string? Address { get; set; }

        public IEnumerable<Room> Rooms { get; set; } = new HashSet<Room>();

    }
}
