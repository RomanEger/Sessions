using Microsoft.EntityFrameworkCore;

using Repository.Entities;

namespace Repository
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        
        public DbSet<Gender> Genders { get; set; }

        public DbSet<Diagnoze> Diagnozes { get; set; }

        public DbSet<MedicineCard> MedicineCards { get; set; }  

        public DbSet<MedicineHistory> MedicineHistories { get; set; }

        public DbSet<Polis> Polises { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<MedicineEvents> MedicineEvents { get; set; }   

        public DbSet<EventType> EventTypes { get; set; }

        public ApplicationDbContext() 
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SRV-SQL\\SRV_SQL;Initial Catalog=user19_15;User ID=user19;Password=tecuser19;TrustServerCertificate=True;Encrypt=False;");
        }
    }
}