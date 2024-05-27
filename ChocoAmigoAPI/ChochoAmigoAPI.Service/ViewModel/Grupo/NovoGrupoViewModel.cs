using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChochoAmigoAPI.Service.ViewModel.Grupo
{
    public class NovoGrupoViewModel
    {
        public string NomeGrupo { get; set; }
        public int QtdMax { get; set; }
        public double Valor { get; set; } //poderia colocar SQLMoney
        public DateTime DataRevelação { get; set; }
        public string? Descricao { get; set; }
        public string? Icone { get; set; }
        public string SenhaGrupo { get; set; }
    }
}
