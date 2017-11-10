using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Catalog.ClassSchema
{
    class LastWatched
    {
        public string movie_id;
        public double current_position;
        public double movie_duration;

        public LastWatched(string movie_id, double current_position, double movie_duration)
        {
            this.movie_id = movie_id;
            this.current_position = current_position;
            this.movie_duration = movie_duration;
        }
    }
}
