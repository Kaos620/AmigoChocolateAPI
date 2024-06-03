using ChochoAmigoAPI.Service.Interfaces;
using ChochoAmigoAPI.Service.ViewModel.Grupo;
using ChochoAmigoAPI.Service.ViewModel.ParticipanteGrupo;
using ChochoAmigoAPI.Service.ViewModel.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChochoAmigoAPI.Service.Services
{
    public class ParticipanteGrupoService : IParticipanteGrupoService
    {
        public Task Atualizar(ParticipanteGrupoViewModel participanteGrupo)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(int usuarioId, int grupoId)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(int grupoId, int usuarioId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GrupoViewModel?> ProcurarGruposUsuario(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioViewModel?> ProcurarUsuariosGrupo(int grupoId)
        {
            throw new NotImplementedException();
        }
    }
}
