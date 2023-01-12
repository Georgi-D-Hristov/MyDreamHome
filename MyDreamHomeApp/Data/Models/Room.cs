namespace MyDreamHomeApp.Data.Models
{
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Data.DataConstants.Room;

    public class Room
    {
        public int Id { get; init; }

        [Required]
        [StringLength(
             TypeMinLength,
             ErrorMessage = "Type should be between {0} and {1} characters."),
             MaxLength(TypeMaxLength)]
        public string? Type { get; set; }
        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(MinArea, MaxArea)]
        public decimal Area { get; set; }

        public string? FloоrType { get; set; }

        public IEnumerable<RoomMaterials> RoomMaterials { get; set; } = new HashSet<RoomMaterials>();

        public IEnumerable<Equipment> Equipments { get; set; } = new HashSet<Equipment>();

        public IEnumerable<Furniture> Furniture { get; set; } = new HashSet<Furniture>();

        public IEnumerable<Idea> Ideas { get; set; } = new HashSet<Idea>();

        public int HomeId { get; init; }
        public Home? Home { get; init; }
    }

}
