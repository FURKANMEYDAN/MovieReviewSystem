using MediatR;
using MoviReviewSystem.Models;

namespace FilmReviewSystem.Application.Queries

{
    public class GetAllMoviesQuery : IRequest<List<Movie>>
    {

    }   
    public class GetAllMoviesQueryHandler : IRequestHandler<GetAllMoviesQuery, List<Movie>>)
     {
        private readonly IMovieRepository _movieRepository;
        public GetAllMoviesQueryHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public async Task<List<Movie>> Handle(GetAllMoviesQuery request ,CancellationToken cancellationToken)
        {

            return await _movieRepository.GetAllMoviesAsync();
        }

     }


}