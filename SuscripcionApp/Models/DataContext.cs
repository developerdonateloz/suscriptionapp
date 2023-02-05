using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SuscripcionApp.Models
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Suscripcion> Suscripciones { get; set; }
        public DbSet<Suscriptor> Suscriptores { get; set; }
    }
}
