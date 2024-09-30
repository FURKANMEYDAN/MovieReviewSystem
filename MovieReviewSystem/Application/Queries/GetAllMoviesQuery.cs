using MediatR;
using FilmReviewSystem.Models;

namespace FilmReviewSystem.Application.Queries

{
    public class GetAllMoviesQuery : IRequest<List<Movie>>
    {

    }   
    public class GetAllMoviesQueryHandler : IRequestHandler<GetAllMoviesQuery, List<Movie>>
     {
        
        return await _movieRepository.GetAllMoviesAsync();

     }


}