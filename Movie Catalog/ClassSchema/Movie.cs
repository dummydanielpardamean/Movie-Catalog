using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Catalog.Interfaces
{
    class Movie
    {
        public string ID;
        public string Title;
        public string Description;
        public string ReleaseYear;
        public string PosterPath;
        public string MoviePath;

        public double CurrentPosition;
        public double MovieDuration;
        public string LastWatchedDate;

        public Movie(string iD, string title, string description, string releaseYear, string posterPath, string moviePath, double currentPosition = 0, double movieDuration = 0, string lastWatchedDate=null)
        {
            ID = iD;
            Title = title;
            Description = description;
            ReleaseYear = releaseYear;
            PosterPath = posterPath;
            MoviePath = moviePath;
            CurrentPosition = currentPosition;
            MovieDuration = movieDuration;
            LastWatchedDate = lastWatchedDate;
        }
    }
}
