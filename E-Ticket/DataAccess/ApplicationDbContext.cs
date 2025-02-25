using E_Ticket.DataAccess.Enum;
using E_Ticket.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Ticket.DataAccess
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Actor> Actors  { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer("Data Source=MOUSSAN\\MSSQLSERVERS;Initial Catalog=E-Ticket;Integrated Security=True;TrustServerCertificate=True");
    }
}
