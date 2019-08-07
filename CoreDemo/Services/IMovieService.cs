using System.Collections.Generic;
using System.Threading.Tasks;
using CoreDemo.Models;

namespace CoreDemo.Services
{
    public interface IMovieService
    {
        Task AddAsync(Movie movie);
        Task<IEnumerable<Movie>> GetByCinemaAsync(int cinemaId);
    }
}