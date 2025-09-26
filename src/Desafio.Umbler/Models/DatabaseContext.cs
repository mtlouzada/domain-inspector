using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Umbler.Models
{
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

        [Required]
        public string WhoIs { get; set; } = string.Empty;

        [Required]
        public int Ttl { get; set; } = 60;

        public string HostedAt { get; set; } = "Desconhecido";
    }
}