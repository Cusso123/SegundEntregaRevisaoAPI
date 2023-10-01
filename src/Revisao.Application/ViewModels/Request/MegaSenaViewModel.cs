using Revisao.Application.ViewModels.Validation;
using System.ComponentModel.DataAnnotations;

namespace Revisao.Application.ViewModels.Request
{
    public class MegaSenaViewModel
    {
        [MinLength(3, ErrorMessage = "Mínimo 3 letras.")]
        [MaxLength(255, ErrorMessage = "Limite máximo 255 letras")]
        [Required(ErrorMessage = "O nome é obrigatorio!")]
        public string Nome { get; set; }

        [CPFValidation]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O primeiro numero é obrigatorio!")]
        [Range(1, 60)]
        public int primeiroNumero { get; set; }

        [Required(ErrorMessage = "O segundo numero é obrigatorio!")]
        [Range(1, 60)]
        public int segundoNumero { get; set; }

        [Required(ErrorMessage = "O terceiro numero é obrigatorio!")]
        [Range(1, 60)]
        public int terceiroNumero { get; set; }

        [Required(ErrorMessage = "O quarto numero é obrigatorio!")]
        [Range(1, 60)]
        public int quartoNumero { get; set; }

        [Required(ErrorMessage = "O quinto numero é obrigatorio!")]
        [Range(1, 60)]
        public int quintoNumero { get; set; }

        [Required(ErrorMessage = "O sexto numero é obrigatorio!")]
        [Range(1, 60)]
        public int sextoNumero { get; set; }

        public DateTime datajogo { get; set; }
    }
}
