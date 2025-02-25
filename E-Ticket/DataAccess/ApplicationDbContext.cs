using Microsoft.EntityFrameworkCore;

namespace E_Ticket.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer("Data Source=MOUSSAN\\MSSQLSERVERS;Initial Catalog=E-Ticket;Integrated Security=True;TrustServerCertificate=True");
    }
}
