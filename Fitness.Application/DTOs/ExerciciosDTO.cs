using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Fitness.Domain.Entites;

namespace Fitness.Application.DTOs
{
    public class ExerciciosDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FichaId { get; set; }
        
        [JsonIgnore]
        public Ficha Ficha { get; set; }
        public DateTime Created_at { get; protected set; }
        public DateTime Deleted_at{ get; protected set; }
        public DateTime Updated_at { get; protected set; }
    }
}