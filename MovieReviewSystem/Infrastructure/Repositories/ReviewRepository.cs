using MoviReviewSystem;


namespace MoviReviewSystem.Infrastructure.Repositories
{

    public class ReviewRepository : IReviewRepository
    {

        private readonly List<Review> _reviews = new List<Review>();

        public async Task AddReviewAsync(Review review)
        {
            _reviews.Add(review);
            await Task.CompletedTask;
        }
        
    }
}