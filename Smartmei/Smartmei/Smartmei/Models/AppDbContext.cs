using Microsoft.EntityFrameworkCore;
using SmartMei.Models;

namespace Smartmei.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Projeto> Projetos { get; set; }

        public DbSet<Cliente> Clientes{ get; set; }

        public DbSet<Evento> Eventos { get; set; }

        public DbSet<Custo> Custos { get; set; }

        public DbSet<Faturamento> Faturamentos { get; set; }

        public DbSet<Mei> Meis { get; set; }

    }
}