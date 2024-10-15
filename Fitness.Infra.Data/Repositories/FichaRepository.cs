using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;
using Fitness.Domain.Interfaces;
using Fitness.Infra.Data.Context;

namespace Fitness.Infra.Data.Repositories
{
    public class FichaRepository : IFichaRepository
    {
        private readonly AppDbContext context;
        public FichaRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task Create(Ficha ficha)
        {
            context.Ficha.Add(ficha);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var ficha = await context.Ficha.FindAsync(id);
            if (ficha != null)
            {
                context.Ficha.Remove(ficha);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Ficha> GetFichaById(int id)
        {
            return await context.Ficha.FindAsync(id);
        }

        public async Task Update(Ficha ficha)
        {
            context.Ficha.Update(ficha);
            await context.SaveChangesAsync();
        }
    }
}