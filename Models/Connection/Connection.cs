using Microsoft.EntityFrameworkCore;
namespace AirLine
{
    public class Connect : DbContext
    {
        public DbSet<VM_Login> logins { get; set; }
        public DbSet<VM_AirLine> AirLines { get; set; }
        public DbSet<VM_BookFlight> Bookaflights { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder dba)
        {
            dba.UseSqlServer("Data Source =.;Initial Catalog = airport;Integrated Security = True");
        }
    }
}