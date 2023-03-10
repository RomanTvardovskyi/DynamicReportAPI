using DAL.Configurations;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class DynamicReportContext : DbContext
    {
        public DynamicReportContext(DbContextOptions options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MasterInformation>()
                .HasKey(x => x.OrganizationId);

            modelBuilder.Entity<ReportingData>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<ReportingData>()
                .HasOne(r => r.MasterInformation)
                .WithMany(m => m.ReportingData)
                .HasForeignKey(r => r.OrganizationId);

            modelBuilder.ApplyConfiguration(new MasterInformationConfiguration());
            modelBuilder.ApplyConfiguration(new ReportingDataConfiguration());
        }

        public DbSet<MasterInformation> MasterInformation { get; set; }

        public DbSet<ReportingData> ReportingData { get; set; }
    }
}
