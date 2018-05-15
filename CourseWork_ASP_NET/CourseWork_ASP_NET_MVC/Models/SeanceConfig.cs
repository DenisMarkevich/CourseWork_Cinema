using System.Data.Entity.ModelConfiguration;

namespace CourseWork_ASP_NET_MVC.Models
{
    internal class SeanceConfig : EntityTypeConfiguration<Seance>
    {
        public SeanceConfig()
        {
            // required cinema hall with many seances
            HasRequired(s => s.CinemaHall)
                .WithMany(c => c.Seances)
                .HasForeignKey(a => a.CinemaHallId)
                .WillCascadeOnDelete(false);

            // required status with many seances
            HasRequired(s => s.ShowStatus)
                .WithMany(c => c.Seances)
                .HasForeignKey(a => a.ShowStatusId)
                .WillCascadeOnDelete(false);
        }
    }
}