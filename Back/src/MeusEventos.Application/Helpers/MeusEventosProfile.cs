using System;
using AutoMapper;
using MeusEventos.Application.Dtos;
using MeusEventos.Domain;
using MeusEventos.Domain.Identity;
using MeusEventos.Persistence.Models;

namespace MeusEventos.API.Helpers
{
    public class MeusEventosProfile : Profile
    {
        public MeusEventosProfile()
        {
            CreateMap<Evento, EventoDto>().ReverseMap();
            CreateMap<Lote, LoteDto>().ReverseMap();
            CreateMap<RedeSocial, RedeSocialDto>().ReverseMap();
            CreateMap<Palestrante, PalestranteDto>().ReverseMap();
            CreateMap<Palestrante, PalestranteAddDto>().ReverseMap();
            CreateMap<Palestrante, PalestranteUpdateDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
        }
    }
}