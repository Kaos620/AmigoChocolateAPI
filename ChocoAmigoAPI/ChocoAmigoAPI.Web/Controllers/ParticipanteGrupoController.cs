using ChochoAmigoAPI.Service.Interfaces;
using ChochoAmigoAPI.Service.Services;
using ChochoAmigoAPI.Service.ViewModel.ParticipanteGrupo;
using ChochoAmigoAPI.Service.ViewModel.Usuario;
using ChochoAmigoAPI.Service.ViewModel.Grupo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChocoAmigoAPI.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ParticipanteGrupoController : ControllerBase
    {
        private readonly IParticipanteGrupoService _participanteGrupoService;
        public ParticipanteGrupoController(IParticipanteGrupoService participanteGrupoService)
        {
            _participanteGrupoService = participanteGrupoService;
        }


        [HttpGet("{grupoId}")]
        public IActionResult Get(int grupoId)
        {
            var buscarUsuariosGrupo = _participanteGrupoService.ProcurarUsuariosGrupo(grupoId);

            return Ok(buscarUsuariosGrupo);

        }

        [HttpGet("{usuarioId}")]
        public IActionResult GetId(int usuarioId)
        {
            var buscarGruposUsuario = _participanteGrupoService.ProcurarGruposUsuario(usuarioId);

            return Ok(buscarGruposUsuario);
        }

        [HttpPost]
        public IActionResult Post(int usuarioId, int grupoId)
        {
            _participanteGrupoService.Inserir(usuarioId, grupoId);

            return Created();
        }



        [HttpDelete("{usuarioId}/{grupoId}")]
        public IActionResult Delete(int usuarioId, int grupoId)
        {

            _participanteGrupoService.Excluir(usuarioId, grupoId);

            return Accepted();
        }
    }
}
