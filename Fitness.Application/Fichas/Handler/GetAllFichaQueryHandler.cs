using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Application.Fichas.Query;
using Fitness.Domain.Entites;
using Fitness.Domain.Interfaces;
using MediatR;

namespace Fitness.Application.Fichas.Handler
{
    public class GetAllFichaQueryHandler : IRequestHandler<GetAllFichaQuery, IEnumerable<Ficha>>
    {
        private readonly IFichaRepository fichaRepository;
        public GetAllFichaQueryHandler(IFichaRepository fichaRepository)
        {
            this.fichaRepository = fichaRepository;
        }
        public async Task<IEnumerable<Ficha>> Handle(GetAllFichaQuery request, CancellationToken cancellationToken)
        {
            var fichas = await fichaRepository.GetAllFichasAsync();
            if(fichas == null)
                throw new ApplicationException("erro when get all fichas on hadler");

            return fichas;
        }
    }
}