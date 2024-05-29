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
    public class ParticipanteGrupoRepository : IParticipanteGrupoRepository
    {
        #region - Atributos/Construtores

        private readonly Contexto _contexto;

        public ParticipanteGrupoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion

        public Task Atualizar(ParticipanteGrupo participanteGrupo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ParticipanteGrupo> BuscarPorId(int id)
        {
            try
            {
                var participanteGrupo = _contexto.ParticipanteGrupo.Where(c => c.UsuarioId == id).ToList();

                return participanteGrupo;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar grupos do usuário: {ex.Message}");
            }
        }

        public async Task Excluir(IEnumerable<ParticipanteGrupo> participanteGrupo)
        {
            try
            {
                _contexto.ParticipanteGrupo.RemoveRange(participanteGrupo);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Excluir usuário no grupo: {ex.Message}");
            }
        }

        public async Task Inserir(ParticipanteGrupo participanteGrupo)
        {
            try
            {
                await _contexto.ParticipanteGrupo.AddAsync(participanteGrupo);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Adicionar usuário no grupo: {ex.Message}");
            }
        }

    }
}
