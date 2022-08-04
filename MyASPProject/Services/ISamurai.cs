using MyASPProject.Models;

namespace MyASPProject.Services
{
    public interface ISamurai
    {
        Task<IEnumerable<Samurai>> GetAll(); 
        Task<Samurai> GetById(int id);
    }
}
