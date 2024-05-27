using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoAmigoAPI.Domain.Entities
{
    public class Usuario
    {
        public Usuario(string nomeUsuario, string email, string senha, string? foto)
        {
            NomeUsuario = nomeUsuario;
            Email = email;
            Senha = senha;
            Foto = foto;
        }

        public Usuario(int usuarioId, string nomeUsuario, string email, string senha, string? foto)
        {
            UsuarioId = usuarioId;
            NomeUsuario = nomeUsuario;
            Email = email;
            Senha = senha;
            Foto = foto;
        }

        public int UsuarioId { get; private set; }
        public string NomeUsuario { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string? Foto { get; private set; }
    }
}
