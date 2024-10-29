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
    public class FichaUpdateCommandHandler : IRequestHandler<FichaUpdateCommand, Ficha>
    {
        private readonly IFichaRepository fichaRepository;
        public FichaUpdateCommandHandler(IFichaRepository fichaRepository)
        {
            this.fichaRepository = fichaRepository;
        }
        public async Task<Ficha> Handle(FichaUpdateCommand request, CancellationToken cancellationToken)
        {
            var ficha = await fichaRepository.GetFichaByIdAsync(request.Id);
            if(ficha == null)
                throw new ApplicationException("Erro when get ficha on hadler");
            
            ficha.Update(
                request.Id, request.Name, request.Idade, request.Peso, request.Altura, request.Serie, 
                request.Repeticao, request.Created_at, request.Deleted_at, request.Updated_at);

            await fichaRepository.UpdateAsync(ficha);
            return ficha;
        }
    }
}