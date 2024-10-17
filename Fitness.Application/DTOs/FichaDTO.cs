using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Application.DTOs
{
    public class FichaDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Idade { get; private set; }
        public double Peso { get; private set; }
        public double Altura { get; private set; }
        public DateTime Created_at { get; protected set; }
        public DateTime Deleted_at{ get; protected set; }
        public DateTime Updated_at { get; protected set; }
    }
}