using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Movie
    {
        private int _minuteDuration;
        private int _releaseYear;
        private double _rating;

        public Movie()
        {

        }
        public Movie(string name, int minuteDuretion, int releaseYear, double rating, string genre)
        {
            MinuteDuration = minuteDuretion;
            ReleaseYear = releaseYear;
            Rating = rating;
            Genre = genre;
            Name = name;
        }
        public string Genre { get; set; }

        public string Name { get; set; }

        public int MinuteDuration
        {
            get
            {
                return _minuteDuration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                _minuteDuration = value;
            }
        }

        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                if(value < 1900 | value > 2022)
                {
                    throw new ArgumentException("");
                }
                _releaseYear = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0 | value > 10)
                {
                    throw new ArgumentException("");
                }
                _rating = value;
            }
        }
        
    }

}
