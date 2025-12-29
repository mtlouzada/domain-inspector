using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Domain.Inspector.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Domain> Domains { get; set; }
    }

    public class Domain
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Ip { get; set; } = "0.0.0.0";

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string WhoIs { get; set; } = string.Empty;

        [Required]
        public int Ttl { get; set; } = 60;

        public string HostedAt { get; set; } = "Desconhecido";
    }
}
