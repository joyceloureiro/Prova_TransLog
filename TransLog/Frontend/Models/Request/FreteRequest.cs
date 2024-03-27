using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Frontend.Models.Request
{
    public class FreteRequest
    {

        [Required(ErrorMessage = "Quilometro é obrigatório")]
      
      
        public decimal Quilometro { get; set; }

        [Required(ErrorMessage = "Peso é obrigatório")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "Largura é obrigatório")]
        public decimal Largura { get; set; }

        [Required(ErrorMessage = "Altura é obrigatório")]
        public decimal Altura { get; set; }

        [Required(ErrorMessage = "Comprimento é obrigatório")]
        public decimal Comprimento { get; set; }


    }
}
