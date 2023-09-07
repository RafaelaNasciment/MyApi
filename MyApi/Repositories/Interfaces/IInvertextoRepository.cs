using MyApi.Models;

namespace MyApi.Repositories.Interfaces
{
    public interface IInvertextoRepository
    {
        Task<CpfCnpjModel> ValidaCpfCnpjModel(string cpfCnpj, string type); 
    }
}
