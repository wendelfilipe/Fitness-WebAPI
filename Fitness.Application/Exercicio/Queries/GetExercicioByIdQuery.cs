using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;
using MediatR;

namespace Fitness.Application.Exercicio.Queries
{
    public class GetExercicioByIdQuery : IRequest<Exercicios>
    {
        public int Id { get; set; }
        
        public GetExercicioByIdQuery(int id)   
        {
            Id = id;  
        }
    }
}