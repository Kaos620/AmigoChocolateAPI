using AutoMapper;
using ChochoAmigoAPI.Service.ViewModel.Grupo;
using ChochoAmigoAPI.Service.ViewModel.ParticipanteGrupo;
using ChochoAmigoAPI.Service.ViewModel.Sorteio;
using ChochoAmigoAPI.Service.ViewModel.Usuario;
using ChocoAmigoAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChochoAmigoAPI.Service.AutoMapper
{
    public class ApplicationToDomain : Profile
    {
        public ApplicationToDomain()
        {
            #region - Grupo

            CreateMap<GrupoViewModel, Grupo>()
               .ConstructUsing(p => new Grupo(
                   p.GrupoId,
                   p.NomeGrupo,
                   p.QtdMax,
                   p.Valor,
                   p.DataRevelacao,
                   p.Descricao,
                   p.Icone,
                   p.SenhaGrupo
                ));

            CreateMap<NovoGrupoViewModel, Grupo>()
               .ConstructUsing(p => new Grupo(
                   p.NomeGrupo,
                   p.QtdMax,
                   p.Valor,
                   p.DataRevelacao,
                   p.Descricao,
                   p.Icone,
                   p.SenhaGrupo
                ));

            #endregion

            #region - ParticipanteGrupo

            CreateMap<ParticipanteGrupoViewModel, ParticipanteGrupo>()
               .ConstructUsing(c => new ParticipanteGrupo(
                   c.UsuarioId,
                   c.GrupoId
                ));

            #endregion

            #region - Sorteio

            CreateMap<SorteioViewModel, Sorteio>()
               .ConstructUsing(d => new Sorteio(
                   d.SorteioId,
                   d.GrupoId,
                   d.UsuarioId,
                   d.UsuarioSorteado
                ));

            CreateMap<NovoSorteioViewModel, Sorteio>()
               .ConstructUsing(d => new Sorteio(
                   d.GrupoId,
                   d.UsuarioId,
                   d.UsuarioSorteado
                ));

            #endregion

            #region - Usuario

            CreateMap<UsuarioViewModel, Usuario>()
                .ConstructUsing(u => new Usuario(
                    u.UsuarioId,
                    u.NomeUsuario,
                    u.Email,
                    u.Senha,
                    u.Foto
                ));

            CreateMap<NovoUsuarioViewModel, Usuario>()
                .ConstructUsing(u => new Usuario(
                    u.NomeUsuario,
                    u.Email,
                    u.Senha,
                    u.Foto
                ));

            #endregion
        }
    }
}
