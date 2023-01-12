namespace MyDreamHomeApp.Data.Models
{
    public class RoomMaterials
    {
        public int RoomId { get; set; }
        public Room? Room { get; set; }

        public int MatirialId { get; set; }
        public Matirial? Matirial { get; set; }
    }
}
