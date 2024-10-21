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
    public class ExercicioUpdateCommandHandler : IRequestHandler<ExercicioUpdateCommand, Exercicios>
    {
        private readonly IExerciciosRepository exerciciosRepository;
        public ExercicioUpdateCommandHandler(IExerciciosRepository exerciciosRepository)
        {
            this.exerciciosRepository = exerciciosRepository;
        }
        public async Task<Exercicios> Handle(ExercicioUpdateCommand request, CancellationToken cancellationToken)
        {
            var exercicios = await exerciciosRepository.GetExercicioByIdAsync(request.Id);
            if( exercicios == null )
            {
                throw new ApplicationException("Error could not found a exercicio");
            }
            else
            {

                exercicios.Update(request.Id, request.Name, request.Created_at, request.Deleted_at, request.Updated_at);

                await exerciciosRepository.UpdateAsync(exercicios);
                return exercicios;
            }
        }
    }
}