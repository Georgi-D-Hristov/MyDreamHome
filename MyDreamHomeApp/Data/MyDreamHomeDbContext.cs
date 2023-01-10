namespace MyDreamHomeApp.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class MyDreamHomeDbContext : IdentityDbContext
    {
        public MyDreamHomeDbContext(DbContextOptions<MyDreamHomeDbContext> options)
            : base(options)
        {
        }
    }
}