using ChochoAmigoAPI.Service.Interfaces;
using ChochoAmigoAPI.Service.ViewModel.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChochoAmigoAPI.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        public Task Atualizar(UsuarioViewModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioViewModel?> Autenticar(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(NovoUsuarioViewModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task RecuperarSenha(string email)
        {
            throw new NotImplementedException();
        }
    }
}
