using Microsoft.EntityFrameworkCore;
using MVCAssig02.Entities;
using System.Reflection;

namespace MVCAssig02.Contexts
{
    public class GymDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-3QRHU6G\\SQLEXPRESS;Database=GymDb;Trusted_Connection=True;TrustServerCertificate=true;");
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; }

    }
}
