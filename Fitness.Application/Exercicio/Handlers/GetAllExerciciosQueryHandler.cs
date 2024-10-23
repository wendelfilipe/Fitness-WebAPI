using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Application.Exercicio.Queries;
using Fitness.Domain.Entites;
using Fitness.Domain.Interfaces;
using MediatR;

namespace Fitness.Application.Exercicio.Handlers
{
    public class GetAllExerciciosQueryHandler : IRequestHandler<GetAllExerciciosQuery, IEnumerable<Exercicios>>
    {
        private readonly IExerciciosRepository exerciciosRepository;
        public GetAllExerciciosQueryHandler(IExerciciosRepository exerciciosRepository)
        {
            this.exerciciosRepository = exerciciosRepository;
        }
        public async Task<IEnumerable<Exercicios>> Handle(GetAllExerciciosQuery request, CancellationToken cancellationToken)
        {
            var exercicios = await exerciciosRepository.GetAllExercicioAsync();
            if(exercicios == null)
                throw new ApplicationException("Error when get all exercicios on handler");
            
            return exercicios;
            
        }
    }
}