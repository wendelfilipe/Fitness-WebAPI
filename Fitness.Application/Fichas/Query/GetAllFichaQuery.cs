using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;
using MediatR;

namespace Fitness.Application.Fichas.Query
{
    public class GetAllFichaQuery : IRequest<IEnumerable<Ficha>>
    {
    }
}