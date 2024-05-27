using ChochoAmigoAPI.Service.ViewModel.ParticipanteGrupo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChocoAmigoAPI.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ParticipanteGrupoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("/participantegrupo/{id}")]
        public IActionResult GetId(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] NovoParticipanteGrupoViewModel novoParticipanteGrupo)
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
