using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using MyApi.Service;
using MyApi.Service.Contansts;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("consumos-apis")]
    public class MyApiController : ControllerBase
    {
        private readonly ILogger<MyApiController> _logger;
        private readonly CepService _cepService;
        private readonly CpfCnpjService _cpfCnpjService;

        public MyApiController()
        {
            
        }
        public MyApiController(
            CepService cepService,
            CpfCnpjService cpfCnpjService,
            ILogger<MyApiController> logger)
        {
            _logger = logger;
            _cepService = cepService;
            _cpfCnpjService = cpfCnpjService;
        }

        [HttpGet(Name = "Consulta-Cep")]
        public async Task<CepModel> ConsultaCep(string cep)
        {
            return await _cepService.Handle(cep: cep);
        }

        //[HttpGet(Name = "Consulta-CpfCnpj/{cpfCnpj}")]
        //public async Task<CpfCnpjModel> ConsultaCpfCnpj(string cpfCnpj, CpfCnpjType cpfCnpjType)
        //{
        //    return await _cpfCnpjService.Handle(cpfCnpj: cpfCnpj, type: cpfCnpjType);
        //}
    }
}