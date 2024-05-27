using ChochoAmigoAPI.Service.ViewModel.Grupo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChocoAmigoAPI.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GrupoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("/grupo/{id}")]
        public IActionResult GetId(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] NovoGrupoViewModel novoGrupo)
        {
            return Created();
        }

        [HttpPut("/{id}")]
        public IActionResult Put(int id)
        {
            return Accepted();
        }

        [HttpDelete("/{id}")]
        public IActionResult Delete(int id)
        {
            return Accepted();
        }
    }
}
