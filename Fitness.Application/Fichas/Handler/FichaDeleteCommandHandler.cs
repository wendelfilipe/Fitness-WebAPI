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
    public class FichaDeleteCommandHandler : IRequestHandler<FichaDeleteCommand, Ficha>
    {
        private readonly IFichaRepository fichaRepository;
        public FichaDeleteCommandHandler(IFichaRepository fichaRepository)
        {
            this.fichaRepository = fichaRepository;
        }
        public async Task<Ficha> Handle(FichaDeleteCommand request, CancellationToken cancellationToken)
        {
            var ficha = await fichaRepository.GetFichaByIdAsync(request.Id);
            if (ficha == null)
            {
                throw new ApplicationException("erro when get ficha on hadler");
            }
            
            await fichaRepository.DeleteAsync(request.Id);
            return ficha;
        }
    }
}