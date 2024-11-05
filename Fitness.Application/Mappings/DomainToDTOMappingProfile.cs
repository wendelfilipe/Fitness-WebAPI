using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Fitness.Application.DTOs;
using Fitness.Domain.Entites;

namespace Fitness.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Exercicios, ExerciciosDTO>().ReverseMap();
            CreateMap<Ficha, FichaDTO>().ReverseMap();
        }
    }
}