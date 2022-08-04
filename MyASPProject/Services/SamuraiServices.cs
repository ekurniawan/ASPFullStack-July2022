using MyASPProject.Models;
using Newtonsoft.Json;

namespace MyASPProject.Services
{
    public class SamuraiServices : ISamurai
    {
        public async Task<IEnumerable<Samurai>> GetAll()
        {
            List<Samurai> samurais = new List<Samurai>();
            using(var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5001/api/Samurais"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    samurais = JsonConvert.DeserializeObject<List<Samurai>>(apiResponse);
                }
            }
            return samurais;
        }

        public async Task<Samurai> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
