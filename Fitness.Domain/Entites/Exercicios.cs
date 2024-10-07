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
        public int Serie { get; private set; }
        public int Repeticao { get; private set; }

        public Exercicios(string name, int serie, int repeticao, DateTime created_at, DateTime deleted_at, DateTime updated_at)
        {
            ValidateDomain(name, serie, repeticao, created_at, deleted_at, updated_at);
        }

         public Exercicios(int id, string name, int serie, int repeticao, DateTime created_at, DateTime deleted_at, DateTime updated_at)
        {
            ValidateDomain(name, serie, repeticao, created_at, deleted_at, updated_at);
            DomainExceptionValidation.When(id <= 0, "Invalid id value");
            Id = id;
        }

        public void Update(int id, string name, int serie, int repeticao, DateTime created_at, DateTime deleted_at, DateTime updated_at)
        {
            ValidateDomain(name, serie, repeticao, created_at, deleted_at, updated_at);
            DomainExceptionValidation.When(id <= 0, "Invalid Id value");
            Id = id;
        }

        public void ValidateDomain(string name, int serie, int repeticao, DateTime created_at, DateTime deleted_at, DateTime updated_at)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name, Name is required");
            DomainExceptionValidation.When(name.Length < 4, "Invalid name, too short");
            DomainExceptionValidation.When(serie <= 0, "Invalid amount serie, required more then 0");
            DomainExceptionValidation.When(serie > 8, "Invalid serie, too long");
            DomainExceptionValidation.When(repeticao < 3, "Invalid repetion amount, too short");
            DomainExceptionValidation.When(repeticao > 30, "Invalid repetion amount, too long");
            Name = name;
            Serie = serie;
            Repeticao = repeticao;
            Created_at = created_at;
            Deleted_at = deleted_at;
            Updated_at = updated_at;
        }
    }
}