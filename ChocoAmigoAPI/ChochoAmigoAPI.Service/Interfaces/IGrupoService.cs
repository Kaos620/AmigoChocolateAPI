using ChochoAmigoAPI.Service.ViewModel.Grupo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChochoAmigoAPI.Service.Interfaces
{
    public interface IGrupoService
    {
        IEnumerable<GrupoViewModel> ProcurarTudo();
        Task <GrupoViewModel> ProcurarPorId(int id);
        Task Inserir(NovoGrupoViewModel grupo, int UsuarioId);
        Task Atualizar(GrupoViewModel grupo);
        Task Excluir(int grupoId);
    }
}
