using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;
using MediatR;

namespace Fitness.Application.Exercicio.Queries
{
    public class GetAllExerciciosQuery : IRequest<IEnumerable<Exercicios>>
    {
    }
}