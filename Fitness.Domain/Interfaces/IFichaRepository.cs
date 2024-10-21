using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;

namespace Fitness.Domain.Interfaces
{
    public interface IFichaRepository
    {
        Task CreateAsync(Ficha ficha);
        Task UpdateAsync(Ficha ficha);
        Task DeleteAsync(int id);
        Task<Ficha> GetFichaByIdAsync(int id);
    }
}