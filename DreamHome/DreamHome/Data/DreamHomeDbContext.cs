namespace DreamHome.Data
{
    using DreamHomeApp.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class DreamHomeDbContext : IdentityDbContext
    {
        public DbSet<Equipment> Equipments { get; init; }
        public DbSet<Furniture> Furniture { get; init; }

        public DbSet<MyHome> MyHomes { get; init; }

        public DbSet<Idea> Ideas { get; init; }

        public DbSet<Matirial> Matirials { get; init; }

        public DbSet<Room> Rooms { get; init; }
        public DreamHomeDbContext(DbContextOptions<DreamHomeDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Equipment>()
                .HasOne(e => e.Room)
                .WithMany(r => r.Equipments)
                .HasForeignKey(e => e.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Furniture>()
                .HasOne(f => f.Room)
                .WithMany(r => r.Furniture)
                .HasForeignKey(f => f.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Room>()
                .HasOne(r => r.Home)
                .WithMany(h => h.Rooms)
                .HasForeignKey(r => r.HomeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Idea>()
                .HasOne(i => i.Room)
                .WithMany(r => r.Ideas)
                .HasForeignKey(r => r.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<RoomMaterials>()
                .HasKey(rm => new { rm.RoomId, rm.MatirialId });

            builder.Entity<RoomMaterials>()
                .HasOne(rm => rm.Room)
                .WithMany(r => r.RoomMaterials)
                .HasForeignKey(rm => rm.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<RoomMaterials>()
                .HasOne(rm => rm.Matirial)
                .WithMany(m => m.RoomMaterials)
                .HasForeignKey(rm => rm.MatirialId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}