namespace CourseWork_ASP_NET_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class CinemaContext : DbContext
    {
        public CinemaContext()
            : base("name=CinemaContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // movie config
            modelBuilder.Configurations.Add(new MovieConfig());

            // seance config
            modelBuilder.Configurations.Add(new SeanceConfig());

            // actor config
            modelBuilder.Entity<Actor>()
                .Property(a => a.Name)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Actor>()
                .Property(a => a.Surname)
                .HasMaxLength(50)
                .IsRequired();

            // status config
            modelBuilder.Entity<ShowStatus>()
                .Property(a => a.Name)
                .HasMaxLength(50)
                .IsRequired();

            // genre config
            modelBuilder.Entity<Genre>()
                .Property(a => a.Name)
                .HasMaxLength(50)
                .IsRequired();

            // country config
            modelBuilder.Entity<Country>()
                .Property(a => a.Name)
                .HasMaxLength(50)
                .IsRequired();

            // cinema hall config
            modelBuilder.Entity<CinemaHall>()
                .Property(a => a.Name)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<CinemaHall>()
                .Property(a => a.Schema)                
                .IsRequired();
        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<ShowStatus> ShowStatuses { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CinemaHall> CinemaHalls { get; set; }
        public virtual DbSet<Seance> Seances { get; set; }
    }

    public class Movie
    {
        public Movie()
        {
            Actors = new HashSet<Actor>();
            Genres = new HashSet<Genre>();
            Seances = new HashSet<Seance>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public string DirectorName { get; set; }
        public byte[] Cover { get; set; }
        public TimeSpan Duration { get; set; }

        public DateTime ReleaseDate { get; set; }
        public DateTime EndShowDate { get; set; }

        public int ShowStatusId { get; set; }
        public virtual ShowStatus ShowStatus { get; set; }

        // collection of actors
        public virtual ICollection<Actor> Actors { get; set; }
        // collection of genres
        public virtual ICollection<Genre> Genres { get; set; }
        // collection of seances
        public virtual ICollection<Seance> Seances { get; set; }
    }

    public class Actor
    {
        public Actor()
        {
            Movies = new HashSet<Movie>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        // collection of movies
        public virtual ICollection<Movie> Movies { get; set; }
    }

    public class ShowStatus
    {
        public ShowStatus()
        {
            Movies = new HashSet<Movie>();
            Seances = new HashSet<Seance>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        // collection of movies
        public virtual ICollection<Movie> Movies { get; set; }
        // collection of seances
        public virtual ICollection<Seance> Seances { get; set; }
    }

    public class Genre
    {
        public Genre()
        {
            Movies = new HashSet<Movie>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        // collection of movies
        public virtual ICollection<Movie> Movies { get; set; }
    }

    public class Country
    {
        public Country()
        {
            Movies = new HashSet<Movie>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        // collection of movies
        public virtual ICollection<Movie> Movies { get; set; }
    }

    //------------------------

    public class CinemaHall
    {
        public CinemaHall()
        {
            Seances = new HashSet<Seance>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Schema { get; set; }

        // collection of seances
        public virtual ICollection<Seance> Seances { get; set; }
    }

    public class Seance
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        public int CinemaHallId { get; set; }
        public virtual CinemaHall CinemaHall { get; set; }

        public int ShowStatusId { get; set; }
        public virtual ShowStatus ShowStatus { get; set; }
    }
}