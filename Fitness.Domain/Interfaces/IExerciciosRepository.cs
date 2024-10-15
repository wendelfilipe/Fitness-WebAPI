using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;

namespace Fitness.Domain.Interfaces
{
    public interface IExerciciosRepository
    {
        Task Create(Exercicios exercicios);
        Task Update(Exercicios exercicios);
        Task Delete(int id);
        Task<Exercicios> GetExercicioById(int id);
        Task<IEnumerable<Exercicios>> GetAllExercicio();
    }
}