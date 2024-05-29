using ChocoAmigo.Repository.EntityFramework;
using ChocoAmigoAPI.Domain.Entities;
using ChocoAmigoAPI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoAmigoAPI.Repository.Repositories
{
    public class SorteioRepository : ISorteioRepository
    {
        #region - Atributos/Construtores

        private readonly Contexto _contexto;

        public SorteioRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion

        public Task Atualizar(Sorteio sorteio)
        {
            throw new NotImplementedException();
        }

        public Task<Sorteio> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(Sorteio sorteio)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(Sorteio sorteio)
        {
            throw new NotImplementedException();
        }
    }
}
