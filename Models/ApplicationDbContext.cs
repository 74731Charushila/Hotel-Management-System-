using Microsoft.EntityFrameworkCore;

namespace Hotel_Management_System.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Menu> Menulist { get; set; }
        public DbSet<Room> Roomlist { get; set; }
    }
}
