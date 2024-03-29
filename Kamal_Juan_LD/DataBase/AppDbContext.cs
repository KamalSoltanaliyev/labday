using Kamal_Juan_LD.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace Kamal_Juan_LD.DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Slider>? Sliders { get; set; }
    }
}
