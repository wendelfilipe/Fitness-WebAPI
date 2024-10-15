using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;
using Fitness.Domain.Interfaces;
using Fitness.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Fitness.Infra.Data.Repositories
{
    public class ExerciciosRepository : IExerciciosRepository
    {
        private readonly AppDbContext context;
        public ExerciciosRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task Create(Exercicios exercicios)
        {
            context.Exercicios.Add(exercicios);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var exercicio = await context.Exercicios.FindAsync(id);
            if(exercicio != null)
            {
                context.Exercicios.Remove(exercicio);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Exercicios>> GetAllExercicio()
        {
            return await context.Exercicios.ToListAsync();
        }

        public async Task<Exercicios> GetExercicioById(int id)
        {
            return await context.Exercicios.FindAsync(id);
        }

        public async Task Update(Exercicios exercicios)
        {
            context.Exercicios.Update(exercicios);
            await context.SaveChangesAsync();
        }
    }
}