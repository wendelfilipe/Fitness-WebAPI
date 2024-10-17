using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Application.Exercicio.Commands
{
    public class ExercicioDeleteCommand : ExercicioCommand
    {
        public int Id { get; set; }
        
        public ExercicioDeleteCommand(int id)
        {
            Id = id;
        }
    }
}