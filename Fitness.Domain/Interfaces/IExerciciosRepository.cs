using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;

namespace Fitness.Domain.Interfaces
{
    public interface IExerciciosRepository
    {
        Task CreateAsync(Exercicios exercicios);
        Task UpdateAsync(Exercicios exercicios);
        Task DeleteAsync(int id);
        Task<Exercicios> GetExercicioByIdAsync(int id);
        Task<IEnumerable<Exercicios>> GetAllExercicioAsync();
    }
}