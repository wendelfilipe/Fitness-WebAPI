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
        public Task Create(FichaDTO fichaDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FichaDTO>> GetAllFichas()
        {
            throw new NotImplementedException();
        }

        public Task<FichaDTO> GetFichaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(FichaDTO fichaDTO)
        {
            throw new NotImplementedException();
        }
    }
}