using MyApi.Models;
using MyApi.Repositories.Interfaces;
using System.Net.Http.Headers;

namespace MyApi.Repositories
{
    public class CepRepository : ICepRepository
    {
        static readonly HttpClient _client = new();
        public CepRepository()
        {            
        }

        public async Task<CepModel> ConsultaPorCep(string cep) 
        {
            CepModel model = null;
            HttpResponseMessage response = await _client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");

            if (response.IsSuccessStatusCode)
                model = await response.Content.ReadAsAsync<CepModel>();

            return model;
        }        
    }
}
