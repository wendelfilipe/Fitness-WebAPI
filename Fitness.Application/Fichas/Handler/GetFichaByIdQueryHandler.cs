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
    public class GetFichaByIdQueryHandler : IRequestHandler<GetFichaByIdQuery, Ficha>
    {
        private readonly IFichaRepository fichaRepository;
        public GetFichaByIdQueryHandler(IFichaRepository fichaRepository)   
        {
            this.fichaRepository = fichaRepository;
        }
        public async Task<Ficha> Handle(GetFichaByIdQuery request, CancellationToken cancellationToken)
        {
            var ficha = await fichaRepository.GetFichaByIdAsync(request.Id);
            if(ficha == null)
                throw new ApplicationException("Erro when get ficha by id on handler");

            return ficha;
        }
    }
}