using Microsoft.EntityFrameworkCore;
using SoftwareQuizAPI.Models;

namespace SoftwareQuizAPI.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Question> Questions { get; set; }

    }
}
