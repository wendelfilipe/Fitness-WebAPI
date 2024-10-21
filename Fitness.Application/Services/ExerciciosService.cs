using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Application.DTOs;
using Fitness.Application.Interfaces;

namespace Fitness.Application.Services
{
    public class ExerciciosService : IExerciciosService
    {
        public Task CreateAsync(ExerciciosDTO exerciciosDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExerciciosDTO>> GetAllExerciciosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ExerciciosDTO> GetExercicioByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ExerciciosDTO exerciciosDTO)
        {
            throw new NotImplementedException();
        }
    }
}