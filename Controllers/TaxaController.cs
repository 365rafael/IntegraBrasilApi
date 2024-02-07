using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegraBrasilApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaController : ControllerBase
    {
        public readonly ITaxaService _taxaService;

        public TaxaController(ITaxaService taxaService)
        {
            _taxaService = taxaService;
        }

        [HttpGet("busca")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTaxas()
        {
            var response = await _taxaService.BuscarTaxas();

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        } 
        
        [HttpGet("busca/{sigla}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTaxaPorSigla([FromRoute] string sigla)
        {
            var response = await _taxaService.BuscarTaxaPorSigla(sigla);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}
