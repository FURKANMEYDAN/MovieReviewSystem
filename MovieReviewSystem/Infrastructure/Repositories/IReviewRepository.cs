using FilmReviewSystem.Models;
using MoviReviewSystem;

namespace MoviReviewSystem.Infrastructure.Repositories
{
    public interface IReviewRepository
    {
        Task AddReviewAsync(Review review);
    }
}