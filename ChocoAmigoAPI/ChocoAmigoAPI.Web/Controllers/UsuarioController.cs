using ChochoAmigoAPI.Service.Interfaces;
using ChochoAmigoAPI.Service.ViewModel.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChocoAmigoAPI.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] NovoUsuarioViewModel novoUsuario)
        {
            return Created();
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Accepted();
        }
       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Accepted();
        }

    };
}
