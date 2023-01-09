namespace MyDreamHomeApp.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class Home
    {
        public int Id { get; init; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Drawing { get; set; }

        public IEnumerable<Room> Rooms { get; set; }

        public IEnumerable<IdentityUser> Owners { get; set; }
    }
}
