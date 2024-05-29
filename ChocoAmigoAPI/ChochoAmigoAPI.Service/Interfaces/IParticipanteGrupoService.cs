using ChochoAmigoAPI.Service.ViewModel.Grupo;
using ChochoAmigoAPI.Service.ViewModel.ParticipanteGrupo;
using ChochoAmigoAPI.Service.ViewModel.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChochoAmigoAPI.Service.Interfaces
{
    public interface IParticipanteGrupoService
    {
        IEnumerable<GrupoViewModel?> ProcurarGruposUsuario(int usuarioId);
        IEnumerable<UsuarioViewModel?> ProcurarUsuariosGrupo(int grupoId);
        Task Inserir( int grupoId, int usuarioId);
        Task Atualizar(ParticipanteGrupoViewModel participanteGrupo);
        Task Excluir(int usuarioId, int grupoId);

    }
}
