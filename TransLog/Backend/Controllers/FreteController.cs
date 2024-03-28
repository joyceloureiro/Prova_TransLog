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
            if (request.Quilometro < 0){ 
                return BadRequest($"O valor Quilometro {request.Quilometro}, parece estar errado");
            }
            if (request.Peso < 0) {
                return BadRequest($"O valor Peso {request.Peso}, parece estar errado");
            }
            if (request.Largura < 0){
                return BadRequest($"O valor Largura {request.Largura}, parece estar errado");
            }
            if (request.Altura < 0){
                return BadRequest($"O valor Altura {request.Altura}, parece estar errado");
            }
            if (request.Comprimento < 0){
                return BadRequest($"O valor Comprimento {request.Comprimento}, parece estar errado");
            }

            var distancia = request.Quilometro;
            var peso = request.Peso;
            var largura = request.Largura;
            var altura = request.Altura;
            var comprimento = request.Comprimento;
            
            //Constantes adicionais se encontram na pasta Enums
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
