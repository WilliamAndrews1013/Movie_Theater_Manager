using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Theater_Manager
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public List<Genre> Genre { get; set; }
        public int Year { get; set; }
        public string Length { get; set; }
        public double AudienceRating { get; set; }
        public string ImageFilePath { get; set; }

        public Movie()
        {
            ID = 0;
            Title = "";
            Genre = new List<Genre>();
            Year = 0;
            Length = "";
            AudienceRating = 0;
            ImageFilePath = "";
        }

        public Movie(int id, string title, int year, string length, double audienceRating, string imageFilePath)
        {
            ID = id;
            Title = title;
            Genre = new List<Genre>();
            Year = year;
            Length = length;
            AudienceRating = audienceRating;
            ImageFilePath = imageFilePath;
        }
    }
}
