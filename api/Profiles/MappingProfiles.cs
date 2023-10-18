using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using AutoMapper;
using core.Entities;
using core.Interfaces;

namespace api.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles(){
            CreateMap<Auditoria, AuditoriaDto>().ReverseMap();
            CreateMap<BlockChain, BlockChainDto>().ReverseMap();
            CreateMap<EstadoNotificacion, EstadoNotiDto>().ReverseMap();
            CreateMap<Formatos, FormatoDto>().ReverseMap();
            CreateMap<HiloRespuestaNot, HiloRespuestaDto>().ReverseMap();
            CreateMap<ModulosMaestros, ModuloMaestrosDto>().ReverseMap();
            CreateMap<ModuloNoficaciones, ModuloNotificacionesDto>().ReverseMap();
            CreateMap<PermisosGenericos, PermisosGenericosDto>().ReverseMap();
            CreateMap<Radicados, RadicadosDto>().ReverseMap();
            CreateMap<Rol, RolDto>().ReverseMap();
            CreateMap<SubModulos, SubmodulosDto>().ReverseMap();
            CreateMap<TipoNotificaciones, TipoNotiDto>().ReverseMap();
            CreateMap<TipoRequerimiento, TipoRequrimientoDto>().ReverseMap();
        }
    }
}