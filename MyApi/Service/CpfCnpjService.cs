using MyApi.Models;
using MyApi.Repositories.Interfaces;
using MyApi.Service.Contansts;

namespace MyApi.Service
{
    public class CpfCnpjService
    {
        private readonly IInvertextoRepository _invertextoRepository;
        public CpfCnpjService(
            IInvertextoRepository invertextoRepository)
        {
            _invertextoRepository = invertextoRepository;
        }

        public async Task<CpfCnpjModel> Handle(string cpfCnpj, string type)
        {
            CpfCnpjModel validacao = await _invertextoRepository.ValidaCpfCnpjModel(
                cpfCnpj: cpfCnpj,
                type: type);

            return validacao;
        }
    }
}
