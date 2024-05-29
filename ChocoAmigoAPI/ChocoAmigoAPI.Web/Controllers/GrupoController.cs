using ChochoAmigoAPI.Service.Interfaces;
using ChochoAmigoAPI.Service.ViewModel.Grupo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChocoAmigoAPI.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GrupoController : ControllerBase
    {
        private readonly IGrupoService _grupoService;
        public GrupoController(IGrupoService grupoService)
        {
            _grupoService = grupoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var buscarGrupos = _grupoService.ProcurarTudo();

            return Ok(buscarGrupos);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            var buscarGrupo = _grupoService.ProcurarPorId(id);

            return Ok(buscarGrupo);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NovoGrupoRequest novoGrupo)
        {
            _grupoService.Inserir(novoGrupo.NovoGrupo, novoGrupo.Id);

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
    }
}
