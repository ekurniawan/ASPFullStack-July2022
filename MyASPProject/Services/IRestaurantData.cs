using MyASPProject.Models;

namespace MyASPProject.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant GetById(int id);
    }
}
