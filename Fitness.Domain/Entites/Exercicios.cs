using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Validation;

namespace Fitness.Domain.Entites
{
    public sealed class Exercicios : Entity
    {
        public string Name { get; private set; }

        public int FichaId { get; set; }

        public Ficha Ficha { get; set; }
        

        public Exercicios(string name, DateTime created_at, DateTime deleted_at, DateTime updated_at)
        {
            ValidateDomain(name, created_at, deleted_at, updated_at);
        }

         public Exercicios(int id, string name, DateTime created_at, DateTime deleted_at, DateTime updated_at)
        {
            ValidateDomain(name, created_at, deleted_at, updated_at);
            DomainExceptionValidation.When(id <= 0, "Invalid id value");
            Id = id;
        }

        public void Update(int id, string name, DateTime created_at, DateTime deleted_at, DateTime updated_at)
        {
            ValidateDomain(name, created_at, deleted_at, updated_at);
            DomainExceptionValidation.When(id <= 0, "Invalid Id value");
            Id = id;
        }

        public void ValidateDomain(string name, DateTime created_at, DateTime deleted_at, DateTime updated_at)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name, Name is required");
            DomainExceptionValidation.When(name.Length < 4, "Invalid name, too short");
            Name = name;
            Created_at = created_at;
            Deleted_at = deleted_at;
            Updated_at = updated_at;
        }
    }
}