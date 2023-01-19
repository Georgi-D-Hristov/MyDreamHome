namespace DreamHomeApp.Data.Models
{
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;
    using static Data.DataConstants.Furniture;

    public class Furniture
    {
        public int Id { get; init; }

        [Required]
        [StringLength(
                   NameMaxLength,
                   ErrorMessage = "Name should be between {0} and {1} characters."),
                   MaxLength(NameMaxLength)]
        public string? Name { get; init; }

        [Required]
        public string? Description { get; init; }

        [Range(MinPrice, MaxPrice)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Image Url")]
        public string? Url { get; set; }

        public string? Dimentions { get; set; }

        [Required]
        [StringLength(
            TypeMinLength,
            ErrorMessage = "Type should be between {0} and {1} characters."),
            MaxLength(TypeMaxLength)]
        public string? Type { get; set; }

        public int RoomId { get; init; }

        public Room? Room { get; init; }
    }
}
