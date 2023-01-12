namespace MyDreamHomeApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Data.DataConstants.Equipment;


    public class Equipment
    {
        public int Id { get; init; }

        [Required]
        [StringLength(
            NameMaxLength,
            ErrorMessage = "Name should be between {0} and {1} characters."),
            MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(
            TypeMinLength,
            ErrorMessage = "Type should be between {0} and {1} characters."),
            MaxLength(TypeMaxLength)]
        public string Type { get; set; }

        [Required]
        [Display(Name ="Image Url")]
        public string Url { get; set; }

        [Range(MinPrice,MaxPrice)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(
            BrandMinLength,
            ErrorMessage = "Brand should be between {0} and {1} characters."),
            MaxLength(BrandMaxLength)]
        public string Brand { get; set; }

       // public string Picture { get; set; }

        public int RoomId { get; init; }

        public Room Room { get; init; }
    }
}
