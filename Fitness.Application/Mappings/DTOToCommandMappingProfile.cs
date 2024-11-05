using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Fitness.Application.DTOs;
using Fitness.Application.Exercicio.Commands;
using Fitness.Application.Fichas.Command;

namespace Fitness.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ExerciciosDTO, ExercicioCreateCommand>();
            CreateMap<ExerciciosDTO, ExercicioUpdateCommand>();
            CreateMap<FichaDTO, FichaCreateCommand>();
            CreateMap<FichaDTO, FichaUpdateCommand>();
        }
    }
}