using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;
using MediatR;

namespace Fitness.Application.Fichas.Query
{
    public class GetFichaByIdQuery : IRequest<Ficha>
    {
        public int Id { get; set; }
        public GetFichaByIdQuery(int id)
        {
            Id = id;
        }
    }
}