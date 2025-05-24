using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Movie
    {
        string title;
        string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }
        // getter and setter

        public string Rating
        {
            get { return rating; }
            set
            { 
                if (value == "PG" || value == "PG-13" || value == "PG-16")
                {
                    rating =  value;
                }else
                {
                    rating = "NR";
                }
             }
        }

    }
}