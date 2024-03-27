using System.ComponentModel.DataAnnotations;

namespace Frontend.Models.Response
{
    public class FreteResponse
    {
        public decimal Quilometro { get; set; }
        public decimal Peso { get; set; } 
        public decimal Largura { get; set; }
        public decimal Altura { get; set; }
        public decimal Comprimento { get; set; }
        public decimal CustoFrete { get; set; }

    }
}
