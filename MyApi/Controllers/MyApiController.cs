using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using MyApi.Service;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyApiController : ControllerBase
    {
        private readonly CepService _cepService;
        private readonly CpfCnpjService _cpfCnpjService;

        public MyApiController(
            CepService cepService,
            CpfCnpjService cpfCnpjService)
        {
            _cepService = cepService;
            _cpfCnpjService = cpfCnpjService;
        }

        [HttpGet("consulta-cep")]
        public async Task<CepModel> ConsultaCep(string cep)
        {
            return await _cepService.Handle(cep: cep);
        }

        [HttpGet("consulta-cpfCnpj/{cpfCnpj}/{cpfCnpjType}")]
        public async Task<CpfCnpjModel> ConsultaCpfCnpj(string cpfCnpj, string cpfCnpjType) //TODO: Validar por constante
        {
            return await _cpfCnpjService.Handle(cpfCnpj: cpfCnpj, type: cpfCnpjType);
        }
    }
}