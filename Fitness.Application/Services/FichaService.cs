using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Application.DTOs;
using Fitness.Application.Interfaces;

namespace Fitness.Application.Services
{
    public class FichaService : IFichaService
    {
        public Task CreateAsync(FichaDTO fichaDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FichaDTO>> GetAllFichasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FichaDTO> GetFichaByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(FichaDTO fichaDTO)
        {
            throw new NotImplementedException();
        }
    }
}