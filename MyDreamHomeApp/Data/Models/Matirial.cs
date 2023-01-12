﻿namespace MyDreamHomeApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Data.DataConstants.Matirial;
    public class Matirial
    {
        public int Id { get; set; }

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

        [Range(MinPrice, MaxPrice)]
        public decimal Price { get; set; }
        public IEnumerable<RoomMaterials> RoomMaterials { get; set; } = new HashSet<RoomMaterials>();
    }
}