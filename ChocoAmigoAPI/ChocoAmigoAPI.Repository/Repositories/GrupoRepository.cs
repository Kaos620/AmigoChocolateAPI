using ChocoAmigo.Repository.EntityFramework;
using ChocoAmigoAPI.Domain.Entities;
using ChocoAmigoAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoAmigoAPI.Repository.Repositories
{
    public class GrupoRepository : IGrupoRepository
    {
        #region - Atributos/Construtores

        private readonly Contexto _contexto;

        public GrupoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion

        public Task Atualizar(Grupo grupo)
        {
            throw new NotImplementedException();
        }

        public Task<int> BuscarId()
        {
            throw new NotImplementedException();
        }

        public async Task<Grupo> BuscarPorId(int id)
        {
            try
            {
                var grupo = await _contexto.Grupo.Where(c => c.GrupoId == id).FirstOrDefaultAsync();

                return grupo;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar o Grupo: {ex.Message}");
            }

        }

        public async Task Excluir(Grupo grupo)
        {
            try
            {
                _contexto.Grupo.Remove(grupo);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Excluir grupo: {ex.Message}");
            }
        }

        public async Task Inserir(Grupo grupo)
        {
            try
            {
                await _contexto.Grupo.AddAsync(grupo);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Criar grupo: {ex.Message}");
            }
        }





    }
}
