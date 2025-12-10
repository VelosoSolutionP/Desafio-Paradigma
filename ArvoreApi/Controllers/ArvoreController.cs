using ArvoreApi.Models;
using ArvoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArvoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArvoreController : ControllerBase
    {
        private readonly ArvoreService _service;

        public ArvoreController()
        {
            _service = new ArvoreService();
        }

        [HttpPost("construir")]
        public ActionResult<Node> Construir([FromBody] int[] numeros)
        {
            try
            {
                var arvore = _service.ConstruirArvore(numeros);
                return Ok(arvore);
            }
            catch (Exception ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
        }
    }
}