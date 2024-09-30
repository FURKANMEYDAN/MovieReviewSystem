using MoviReviewSystem;


namespace MoviReviewSystem.Infrastructure.Repositories
{

    public class MovieRepository : IMovieRepository
    {
        private readonly List<Movie> _movies = new List<Movie>
        {
             new Movie { Id = 1, Title = "The Godfather", Director = "Francis Ford Coppola", Year = 1972 },
             new Movie { Id = 2, Title = "Inception", Director = "Christopher Nolan", Year = 2010 }
        };

        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            return await Task.FromResult(_movies);
        }
    }
}