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
    public class ExercicioCreateCommandHandler : IRequestHandler<ExercicioCreateCommand, Exercicios>
    {
        private readonly IExerciciosRepository exerciciosRepository;
        public ExercicioCreateCommandHandler(IExerciciosRepository exerciciosRepository)
        {
            this.exerciciosRepository = exerciciosRepository;  
        }
        public async Task<Exercicios> Handle(ExercicioCreateCommand request, CancellationToken cancellationToken)
        {
            var exercicios = new Exercicios(request.Name, request.Created_at, request.Updated_at, request.Deleted_at);
            if(exercicios == null)
            {
                throw new ApplicationException("Error creating entity exercicios");
            }
            else
            {
                exercicios.FichaId = request.FichaId;
                await exerciciosRepository.CreateAsync(exercicios);
                return exercicios;
            }
        }
    }
}