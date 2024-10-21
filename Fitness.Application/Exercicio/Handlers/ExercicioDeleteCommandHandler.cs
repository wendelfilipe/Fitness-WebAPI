using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Application.Exercicio.Commands;
using Fitness.Domain.Entites;
using Fitness.Domain.Interfaces;
using MediatR;

namespace Fitness.Application.Exercicio.Handlers
{
    public class ExercicioDeleteCommandHandler : IRequestHandler<ExercicioDeleteCommand, Exercicios>
    {
        private readonly IExerciciosRepository exerciciosRepository;
        public ExercicioDeleteCommandHandler(IExerciciosRepository exerciciosRepository)
        {
            this.exerciciosRepository = exerciciosRepository;
        }
        public async Task<Exercicios> Handle(ExercicioDeleteCommand request, CancellationToken cancellationToken)
        {
            var exercicio = await exerciciosRepository.GetExercicioByIdAsync(request.Id);
            if (exercicio == null)
                throw new ApplicationException("Error cant found a exercicio to delete");

            await exerciciosRepository.DeleteAsync(request.Id);
            return exercicio;
        }
    }
}