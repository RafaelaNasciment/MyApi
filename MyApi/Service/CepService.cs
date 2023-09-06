using MyApi.Models;
using MyApi.Repositories.Interfaces;

namespace MyApi.Service
{
    public class CepService
    {
        private readonly ICepRepository _repository;
        public CepService(
            ICepRepository repository)
        {            
            _repository = repository;
        }

        public async Task<CepModel> Handle(string cep)
        {
            CepModel localizacao = await _repository.ConsultaPorCep(cep);

            return localizacao;
        }
    }
}
