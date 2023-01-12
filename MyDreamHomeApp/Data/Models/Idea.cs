namespace MyDreamHomeApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants.Idea;

    public class Idea
    {
        public int Id { get; init; }


        [Required]
        [StringLength(
                  NameMaxLength,
                  ErrorMessage = "Name should be between {0} and {1} characters."),
                  MaxLength(NameMaxLength)]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "Image Url")]
        public string? Url { get; set; }

        public int RoomId { get; init; }

        public Room? Room { get; init; }
    }
}
