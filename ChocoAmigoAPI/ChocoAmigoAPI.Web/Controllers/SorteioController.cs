using ChochoAmigoAPI.Service.ViewModel.Sorteio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChocoAmigoAPI.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SorteioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("/sorteio/{id}")]
        public IActionResult GetId(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] NovoSorteioViewModel novoSorteio)
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
