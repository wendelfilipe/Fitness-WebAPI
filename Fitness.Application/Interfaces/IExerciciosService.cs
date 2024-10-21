using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Application.DTOs;

namespace Fitness.Application.Interfaces
{
    public interface IExerciciosService
    {
        Task CreateAsync(ExerciciosDTO exerciciosDTO);
        Task DeleteAsync(int id);
        Task UpdateAsync(ExerciciosDTO exerciciosDTO);
        Task<IEnumerable<ExerciciosDTO>> GetAllExerciciosAsync();
        Task<ExerciciosDTO> GetExercicioByIdAsync(int id);
    }
}