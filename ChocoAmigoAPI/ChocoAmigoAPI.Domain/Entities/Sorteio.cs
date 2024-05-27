using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoAmigoAPI.Domain.Entities
{
    public class Sorteio
    {
        public Sorteio(int grupoId, int usuarioId, int usuarioSorteado)
        {
            GrupoId = grupoId;
            UsuarioId = usuarioId;
            UsuarioSorteado = usuarioSorteado;
        }

        public Sorteio( int sorteioId, int grupoId, int usuarioId, int usuarioSorteado)
        {
            SorteioId = sorteioId;
            GrupoId = grupoId;
            UsuarioId = usuarioId;
            UsuarioSorteado = usuarioSorteado;
        }

        public int SorteioId { get; private set; }
        public int GrupoId { get; private set; }
        public int UsuarioId { get; private set; }
        public int UsuarioSorteado { get; private set; }

        public Grupo Grupo { get; private set; }
        public Usuario Usuario { get; private set; }
    };
}
