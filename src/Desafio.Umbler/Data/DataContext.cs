using Desafio.Umbler.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Umbler.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {

        }

        public DbSet<Domain> Domains { get; set; }
    }
}
