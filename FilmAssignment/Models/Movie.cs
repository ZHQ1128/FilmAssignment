using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmAssignment.Models
{
    class Movie
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public int ReleaseDate { get; set; }
        public string LeadActor { get; set; }
        public string LeadActress { get; set; }
         

        public static List<Movie> GenerateListOfMovies()
        {
            var movies = new List<Movie>();
            movies.Add(new Movie { Category = "Horror", Title = "L", ReleaseDate = 2015, LeadActor = "Tom Kruse", LeadActress = "Nikola Kidman" });
            movies.Add(new Movie { Category = "Action", Title = "LL", ReleaseDate = 2014, LeadActor = "la", LeadActress = "laa" });
            movies.Add(new Movie { Category = "Comedy", Title = "LLL", ReleaseDate = 2016, LeadActor = "laa", LeadActress = "laaa" });
            movies.Add(new Movie { Category = "Drama", Title = "LLLL", ReleaseDate = 2013, LeadActor = "Tom K", LeadActress = "Nikola K" });
            movies.Add(new Movie { Category = "Documentary", Title = "LLLLL", ReleaseDate = 2017, LeadActor = "T Kruse", LeadActress = "N Kidman" });
            movies.Add(new Movie { Category = "Horror", Title = "A", ReleaseDate = 2009, LeadActor = "AY", LeadActress = "ayy" });
            movies.Add(new Movie { Category = "Action", Title = "AA", ReleaseDate = 2011, LeadActor = "Aay", LeadActress = "aayy" });
            return movies;
        }

    }
}
