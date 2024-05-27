using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoAmigoAPI.Domain.Entities
{
    public class Grupo
    {
        public Grupo(string nomeGrupo, int qtdMax, double valor, DateTime dataRevelação, string? descricao, string? icone, string senhaGrupo)
        {
            NomeGrupo = nomeGrupo;
            QtdMax = qtdMax;
            Valor = valor;
            DataRevelação = dataRevelação;
            Descricao = descricao;
            Icone = icone;
            SenhaGrupo = senhaGrupo;
        }

        public Grupo(int grupoId, string nomeGrupo, int qtdMax, double valor, DateTime dataRevelação, string? descricao, string? icone, string senhaGrupo)
        {
            GrupoId = grupoId;
            NomeGrupo = nomeGrupo;
            QtdMax = qtdMax;
            Valor = valor;
            DataRevelação = dataRevelação;
            Descricao = descricao;
            Icone = icone;
            SenhaGrupo = senhaGrupo;
        }

        public int GrupoId { get; private set; }
        public string NomeGrupo { get; private set; }
        public int QtdMax { get; private set; }
        public double Valor { get; private set; } //poderia colocar SQLMoney
        public DateTime DataRevelação { get; private set; }
        public string? Descricao { get; private set; }
        public string? Icone { get; private set; }
        public string SenhaGrupo { get; private set; }
    }
}
