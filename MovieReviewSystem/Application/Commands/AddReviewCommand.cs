using System.Windows.Input;
using FilmReviewSystem.Models;
using MediatR;
using MoviReviewSystem.Models;  

namespace MoviReviewSystem.Application.Commands

{
    public class AddReviewCommand : IRequest
    {

        public int MovieId { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
    }

    public class AddReviewCommandHandler : IRequestHandler<AddReviewCommand>
    {
        private readonly IReviewRepository _reviewRepository;
        public AddReviewCommandHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;

        }
        public async Task<Unit> Handle(AddReviewCommand request, CancellationToken cancellationToken)
        {
            var review  = new Review
            {
                MovieId = request.MovieId,
                UserId = request.UserId,
                Content = request.Content,  
                Rating = request.Rating,   

            };
            await _reviewRepository.AddReviewAsync(review);
            return Unit.Value;
            
        }
    }
}