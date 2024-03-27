using Backend.Models.Enums;
using Backend.Models.Request;
using Backend.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FreteController : ControllerBase
    {
        [HttpGet]
        [Route("obter")]


        public IActionResult ObterFrete([FromQuery] FreteRequest request)
        {
           

            var distancia = request.Quilometro;
            var peso = request.Peso;
            var largura = request.Largura;
            var altura = request.Altura;
            var comprimento = request.Comprimento;
            
            var custoFrete = (distancia * AdicionalFrete.ValorFixoKm) + (peso * AdicionalFrete.AdicionalKg) + 
                (largura * altura * comprimento * AdicionalFrete.AdicionalMetro);

            var response = new FreteResponse();
            response.Quilometro = request.Quilometro;
            response.Peso = request.Peso;
            response.Largura = request.Largura;
            response.Altura = request.Altura;
            response.Comprimento = request.Comprimento;

            response.CustoFrete = custoFrete;

            return Ok(response);

        }
       
    }
}
