using FilmReviewSystem.Models;

namespace MoviReviewSystem.Models
{
    public class Movie{
        public int Id { get; set;}
        public string Title { get; set;}
        
        public string  Director { get; set; }

        public int Year { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();


    }
}