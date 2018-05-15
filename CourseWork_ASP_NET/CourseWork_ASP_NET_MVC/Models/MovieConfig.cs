using System.Data.Entity.ModelConfiguration;

namespace CourseWork_ASP_NET_MVC.Models
{
    internal class MovieConfig : EntityTypeConfiguration<Movie>
    {
        public MovieConfig()
        {
            Property(m => m.Name)
                .HasMaxLength(50)
                .IsRequired();

            // required country with many movies
            HasRequired(m => m.Country)
                .WithMany(c => c.Movies)
                .HasForeignKey(a => a.CountryId)
                .WillCascadeOnDelete(false);

            // required status with many movies
            HasRequired(m => m.ShowStatus)
                .WithMany(s => s.Movies)
                .HasForeignKey(a => a.ShowStatusId)
                .WillCascadeOnDelete(false);

            // many actors with many movies
            HasMany(m => m.Actors)
                .WithMany(a => a.Movies);

            // many genres with many movies
            HasMany(m => m.Genres)
                .WithMany(g => g.Movies);

            // many seances with required movie
            HasMany(m => m.Seances)
                .WithRequired(s => s.Movie)
                .HasForeignKey(s => s.MovieId)
                .WillCascadeOnDelete(false);
        }
    }
}