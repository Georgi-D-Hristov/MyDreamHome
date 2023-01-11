namespace MyDreamHomeApp.Data.Models
{
    public class Matirial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<RoomMaterials> RoomMaterials { get; set; } = new HashSet<RoomMaterials>();
    }
}
