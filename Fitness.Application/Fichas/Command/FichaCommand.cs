using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;
using MediatR;

namespace Fitness.Application.Fichas.Command
{
    public class FichaCommand : IRequest<Ficha>
    {
        public string Name { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public int Serie { get; set; }
        public int Repeticao { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Deleted_at{ get; set; }
        public DateTime Updated_at { get; set; }
    }
}