using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Models;

namespace CoreDemo.Services
{
    public class CinemaMemoryService : ICinemaService
    {
        private readonly List<Cinema> _cinemas = new List<Cinema>();

        public CinemaMemoryService()
        {
            _cinemas.Add(new Cinema
            {
                Name = "City Cinema",
                Location = "Road ABC, No.123",
                Capacity = 100
            });
            _cinemas.Add(new Cinema
            {
                Name = "Fly Cinema",
                Location = "Road Hello, No.1024",
                Capacity = 500
            });
        }

        public Task<IEnumerable<Cinema>> GetllAllAsync()
        {
            return Task.Run(() => _cinemas.AsEnumerable());
        }

        public Task<Cinema> GetByIdAsync(int id)
        {
            return Task.Run(() => _cinemas.FirstOrDefault(x => x.Id == id));
        }


        public Task AddAsync(Cinema cinema)
        {
            var maxId = _cinemas.Max(x => x.Id);
            cinema.Id = maxId + 1;
            _cinemas.Add(cinema);
            return Task.CompletedTask;
        }
    }
}