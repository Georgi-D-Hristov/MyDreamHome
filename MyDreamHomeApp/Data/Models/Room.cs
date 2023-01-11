namespace MyDreamHomeApp.Data.Models
{
    public class Room
    {
        public int Id { get; init; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Area { get; set; }
        public string FloоrType { get; set; }

        public IEnumerable<Matirial> Matirials { get; set; } = new HashSet<Matirial>();

        public IEnumerable<Equipment> Equipments { get; set; } = new HashSet<Equipment>();

        public IEnumerable<Furniture> Furniture { get; set; } = new HashSet<Furniture>();

        public IEnumerable<Idea> Ideas { get; set; } = new HashSet<Idea>();
    }

}
