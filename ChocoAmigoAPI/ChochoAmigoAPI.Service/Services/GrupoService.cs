using ChochoAmigoAPI.Service.Interfaces;
using ChochoAmigoAPI.Service.ViewModel.Grupo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChochoAmigoAPI.Service.Services
{
    public class GrupoService : IGrupoService
    {
        public Task Atualizar(GrupoViewModel grupo)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(int grupoId)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(NovoGrupoViewModel grupo, int UsuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<GrupoViewModel> ProcurarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GrupoViewModel> ProcurarTudo()
        {
            throw new NotImplementedException();
        }
    }
}
