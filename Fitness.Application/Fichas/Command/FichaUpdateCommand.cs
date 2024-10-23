using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Application.Fichas.Command
{
    public class FichaUpdateCommand : FichaCommand
    {
        public int Id { get; set; }
    }
}