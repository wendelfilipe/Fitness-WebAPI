using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Application.DTOs;

namespace Fitness.Application.Interfaces
{
    public interface IFichaService
    {
        Task Create(FichaDTO fichaDTO);
        Task Delete(int id);
        Task Update(FichaDTO fichaDTO);
        Task<IEnumerable<FichaDTO>> GetAllFichas();
        Task<FichaDTO> GetFichaById(int id);
    }
}