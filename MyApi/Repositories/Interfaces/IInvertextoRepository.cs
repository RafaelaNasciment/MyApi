using MyApi.Models;
using MyApi.Service.Contansts;

namespace MyApi.Repositories.Interfaces
{
    public interface IInvertextoRepository
    {
        Task<CpfCnpjModel> ValidaCpfCnpjModel(string cpfCnpj, CpfCnpjType type); 
    }
}
