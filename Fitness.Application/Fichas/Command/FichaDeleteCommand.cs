using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Application.Fichas.Command
{
    public class FichaDeleteCommand : FichaCommand
    {
        public int Id { get; set; }
        
        public FichaDeleteCommand(int id)
        {
            Id = id;
        }
    }
}