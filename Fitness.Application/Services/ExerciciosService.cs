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
        public Task Create(ExerciciosDTO exerciciosDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExerciciosDTO>> GetAllExercicios()
        {
            throw new NotImplementedException();
        }

        public Task<ExerciciosDTO> GetExercicioById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ExerciciosDTO exerciciosDTO)
        {
            throw new NotImplementedException();
        }
    }
}