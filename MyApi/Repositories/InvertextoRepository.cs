using MyApi.Models;
using MyApi.Repositories.Interfaces;

namespace MyApi.Repositories
{
    public class InvertextoRepository : IInvertextoRepository
    {
        static readonly HttpClient _client = new();
        private readonly string _token = "4578|s0XP5hSwD5YQrLOCnWYWHwvnpYsVQH4K";

        public InvertextoRepository()
        {            
        }
        public async Task<CpfCnpjModel> ValidaCpfCnpjModel(string cpfCnpj, string type)
        {
            CpfCnpjModel model = null;
            string url = $"https://api.invertexto.com/v1/validator?token={_token}&value={cpfCnpj}&type={type}";
            HttpResponseMessage response = await _client.GetAsync(url);

            if (response.IsSuccessStatusCode)
                model = await response.Content.ReadAsAsync<CpfCnpjModel>();

            return model;
        }
    }
}
