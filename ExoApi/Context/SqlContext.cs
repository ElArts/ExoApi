using ExoApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ExoApi.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }
        protected override void

        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-UOAN0LR\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }

        public DbSet<Projetos> Projetos { get; set; }
    }

}
