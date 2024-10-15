using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;

namespace Fitness.Domain.Interfaces
{
    public interface IFichaRepository
    {
        Task Create(Ficha ficha);
        Task Update(Ficha ficha);
        Task Delete(int id);
        Task<Ficha> GetFichaById(int id);
    }
}