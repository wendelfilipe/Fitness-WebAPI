using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Application.Fichas.Command;
using Fitness.Domain.Entites;
using Fitness.Domain.Interfaces;
using MediatR;

namespace Fitness.Application.Fichas.Handler
{
    public class FichaCreateCommandHandler : IRequestHandler<FichaCreateCommand, Ficha>
    {
        private readonly IFichaRepository fichaRepository;
        public FichaCreateCommandHandler(IFichaRepository fichaRepository)
        {
            this.fichaRepository = fichaRepository;
        }
        public async Task<Ficha> Handle(FichaCreateCommand request, CancellationToken cancellationToken)
        {
            var ficha = new Ficha(
                request.Name, request.Idade, request.Peso, request.Altura, request.Serie, 
                request.Repeticao, request.Created_at, request.Deleted_at, request.Updated_at);
            if(ficha == null)
                throw new ApplicationException("Error when create ficha on handler");

            await fichaRepository.CreateAsync(ficha);
            return ficha;

        }
    }
}