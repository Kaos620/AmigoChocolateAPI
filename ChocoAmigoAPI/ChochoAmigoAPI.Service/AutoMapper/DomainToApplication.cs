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
    public class DomainToApplication : Profile
    {
        public DomainToApplication()
        {
            CreateMap<Grupo, GrupoViewModel>();
            CreateMap<ParticipanteGrupo, ParticipanteGrupoViewModel>();
            CreateMap<Sorteio, SorteioViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}
