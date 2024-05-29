using ChocoAmigoAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoAmigoAPI.Repository.Interface
{
    public interface IUsuarioRepository
    {
        Task<Usuario> Autenticar(string email, string senha);
        Task<Usuario> BuscarPorId(int id);
        Task Inserir(Usuario usuario);
        Task Atualizar(Usuario usuario);
        Task Excluir(Usuario usuario);
    }
}
