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
          //TimeSpan s = new TimeSpan()
        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<ShowStatus> ShowStatuses { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
    }

    public class Movie
    {
        public Movie()
        {
            Artists = new HashSet<Artist>();
            Genres = new HashSet<Genre>();
            Sessions = new HashSet<Session>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public string ProducerName { get; set; }
        public byte[] Cover { get; set; }
        public TimeSpan Duration { get; set; }

        public DateTime BeginShow { get; set; }
        public DateTime EndShow { get; set; }

        public int ShowStatusId { get; set; }
        public virtual ShowStatus ShowStatus { get; set; }

        // collection of artists
        public virtual ICollection<Artist> Artists { get; set; }
        // collection of genres
        public virtual ICollection<Genre> Genres { get; set; }
        // collection of sessions
        public virtual ICollection<Session> Sessions { get; set; }
    }

    public class Artist
    {
        public Artist()
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
        }
        public int Id { get; set; }
        public string Name { get; set; }

        // collection of movies
        public virtual ICollection<Movie> Movies { get; set; }
        // collection of sessoins
        public virtual ICollection<Session> Sessions { get; set; }
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
            Sessions = new HashSet<Session>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Schema { get; set; }

        // collection of sessions
        public virtual ICollection<Session> Sessions { get; set; }
    }

    public class Session
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