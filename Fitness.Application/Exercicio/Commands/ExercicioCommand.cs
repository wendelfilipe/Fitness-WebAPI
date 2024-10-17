using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;
using MediatR;

namespace Fitness.Application.Exercicio.Commands
{
    public class ExercicioCommand : IRequest<Exercicios>
    {
         public string Name { get; set; }
        public int FichaId { get; set; }
        public DateTime Created_at { get; protected set; }
        public DateTime Deleted_at{ get; protected set; }
        public DateTime Updated_at { get; protected set; }
    }
}