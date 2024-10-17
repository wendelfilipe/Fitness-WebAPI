using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Application.DTOs;

namespace Fitness.Application.Interfaces
{
    public interface IExerciciosService
    {
        Task Create(ExerciciosDTO exerciciosDTO);
        Task Delete(int id);
        Task Update(ExerciciosDTO exerciciosDTO);
        Task<IEnumerable<ExerciciosDTO>> GetAllExercicios();
        Task<ExerciciosDTO> GetExercicioById(int id);
    }
}