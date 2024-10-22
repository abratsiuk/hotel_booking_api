using hotel_booking_api.Models;
using Microsoft.EntityFrameworkCore;

namespace hotel_booking_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        // Другие DbSet...
    }
}
