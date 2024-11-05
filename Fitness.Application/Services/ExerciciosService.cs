using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Fitness.Application.DTOs;
using Fitness.Application.Exercicio.Commands;
using Fitness.Application.Exercicio.Queries;
using Fitness.Application.Interfaces;
using MediatR;

namespace Fitness.Application.Services
{
    public class ExerciciosService : IExerciciosService
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public ExerciciosService(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }
        public async Task CreateAsync(ExerciciosDTO exerciciosDTO)
        {
            var exercicioCreateCommand = mapper.Map<ExercicioCreateCommand>(exerciciosDTO);
            await mediator.Send(exercicioCreateCommand);
        }

        public async Task DeleteAsync(int id)
        {
            var exercicioDeleteCommand = new ExercicioDeleteCommand(id);
            if(exercicioDeleteCommand == null)
            {
                throw new ApplicationException("error not exercicioDeleteCommand not found");
            }
            await mediator.Send(exercicioDeleteCommand);
        }

        public async Task<IEnumerable<ExerciciosDTO>> GetAllExerciciosAsync()
        {
            var getAllExerciciosQuery = new GetAllExerciciosQuery();
            if(getAllExerciciosQuery == null)
            {
                throw new ApplicationException("error not found, getExercicioQuery not found");
            }

            var result = await mediator.Send(getAllExerciciosQuery);
            return mapper.Map<IEnumerable<ExerciciosDTO>>(result);
        }

        public async Task<ExerciciosDTO> GetExercicioByIdAsync(int id)
        {
            var getExercicioByIdQuery = new GetExercicioByIdQuery(id);
            if(getExercicioByIdQuery == null)
                throw new ApplicationException("error not found, getExercicioByIdQuery not found");

            var result = await mediator.Send(getExercicioByIdQuery);
            return mapper.Map<ExerciciosDTO>(result);
        }

        public async Task UpdateAsync(ExerciciosDTO exerciciosDTO)
        {
            var exercicioUpdateCommand = mapper.Map<ExercicioUpdateCommand>(exerciciosDTO);
            if(exercicioUpdateCommand == null)
                throw new ApplicationException("error, exercicioUpdateCommando not found");

            await mediator.Send(exercicioUpdateCommand); 
        }
    }
}