using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Catalog.ClassSchema
{
    class MoviePlus
    {
        public string ID;
        public string title;
        public string description;
        public string ReleaseYear;
        public string PosterPath;
        public string MoviePath;
        public double CurrentPosition;
        public double MovieDuration;
        public string LastWatchedDate;

        public MoviePlus(string iD, string title, string description, string releaseYear, string posterPath, string moviePath, double currentPosition, double movieDuration, string lastWatchedDate)
        {
            ID = iD;
            this.title = title;
            this.description = description;
            ReleaseYear = releaseYear;
            PosterPath = posterPath;
            MoviePath = moviePath;
            CurrentPosition = currentPosition;
            MovieDuration = movieDuration;
            LastWatchedDate = lastWatchedDate;
        }
    }
}
