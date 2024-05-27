using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChochoAmigoAPI.Service.ViewModel.Sorteio
{
    public class NovoSorteioViewModel
    {
        public int GrupoId { get; set; }
        public int UsuarioId { get; set; }
        public int UsuarioSorteado { get; set; }
    }
}
