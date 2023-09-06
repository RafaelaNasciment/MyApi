using MyApi.Models;

namespace MyApi.Repositories.Interfaces
{
    public interface ICepRepository
    {
        Task<CepModel> ConsultaPorCep(string cep);
    }
}
