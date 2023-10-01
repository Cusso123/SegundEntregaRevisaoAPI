using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Application.ViewModels.Request;

namespace Revisao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MegaSenaController : ControllerBase
    {
        private readonly IMegaSenaServices _megaSenaService;

        public MegaSenaController(IMegaSenaServices megaSenaService)
        {
            _megaSenaService = megaSenaService;
        }

        [HttpGet(Name = "ObterTodosOsJogos")]
        public IActionResult ObterTodosOsJogos()
        {
            try
            {
                return Ok(_megaSenaService.ObterTodosOsJogos());
            }
            catch
            {
                return BadRequest("Nenhum jogo salvo"); 
            }

        }

        [HttpPost(Name = "RegistrarJogo")]
        public IActionResult RegistrarJogo(NovoRegistroMegaSenaViewModel megasena)
        {
            if (megasena.primeiroNumero != megasena.segundoNumero
              && megasena.segundoNumero != megasena.terceiroNumero
              && megasena.terceiroNumero != megasena.quartoNumero
              && megasena.quartoNumero != megasena.quintoNumero
              && megasena.quintoNumero != megasena.sextoNumero)
            {
                _megaSenaService.RegistrarJogo(megasena);
                return Ok("Jogo Registrado com sucesso!");
            }
            else
            {
                return BadRequest("Dados incorretos, existem números repetidos no jogo");
            }
        }
    }
}
