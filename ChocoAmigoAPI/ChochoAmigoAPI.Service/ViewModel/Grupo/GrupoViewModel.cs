using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChochoAmigoAPI.Service.ViewModel.Grupo
{
    public class GrupoViewModel
    {
        public int GrupoId { get; set; }
        public string NomeGrupo { get; set; }
        public int QtdMax { get; set; }
        public double Valor { get; set; }
        public DateTime DataRevelacao { get; set; }
        public string? Descricao { get; set; }
        public string? Icone { get; set; }
        public string SenhaGrupo { get; set; }
    }
}
