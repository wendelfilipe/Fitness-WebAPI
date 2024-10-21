using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Application.DTOs;

namespace Fitness.Application.Interfaces
{
    public interface IFichaService
    {
        Task CreateAsync(FichaDTO fichaDTO);
        Task DeleteAsync(int id);
        Task UpdateAsync(FichaDTO fichaDTO);
        Task<IEnumerable<FichaDTO>> GetAllFichasAsync();
        Task<FichaDTO> GetFichaByIdAsync(int id);
    }
}