namespace MyDreamHomeApp.Data.Models
{
    public class Room
    {
        public int Id { get; init; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Area { get; set; }
        public string FloоrType { get; set; }

        public IEnumerable<Matirial> Matirials { get; set; }

        public IEnumerable<Equipment> Equipments { get; set; }

        public IEnumerable<Furniture> Furniture { get; set; }

        public IEnumerable<Idea> Ideas { get; set; }
    }

}
