using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Validation;

namespace Fitness.Domain.Entites
{
    public sealed class Ficha : Entity
    {
        public string Name { get; private set; }
        public int Idade { get; private set; }
        public double Peso { get; private set; }
        public double Altura { get; private set; }
        public ICollection<Exercicios> Exercicios { get; private set; }
        public int Serie { get; private set; }
        public int Repeticao { get; private set; }
        
        public Ficha(int id, string name, int idade, double peso, double altura, int serie, int repeticao, DateTime created_at, DateTime deleted_at, DateTime updated_at)
        {
            ValidateDomain(name, idade, peso, altura,  serie, repeticao, created_at, deleted_at, updated_at);
            DomainExceptionValidation.When(id <= 0, "Invalid id value");
            Id = id;
        }

        public Ficha(string name, int idade, double peso, double altura, int serie, int repeticao, DateTime created_at, DateTime deleted_at, DateTime updated_at)
        {
             ValidateDomain(name, idade, peso, altura,  serie, repeticao, created_at, deleted_at, updated_at);
        }

        public void Update(int id, string name, int idade, double peso, double altura, int serie, int repeticao, DateTime created_at, DateTime deleted_at, DateTime updated_at)
        {
            ValidateDomain(name, idade, peso, altura,  serie, repeticao, created_at, deleted_at, updated_at);
            DomainExceptionValidation.When(id <= 0, "Invalid id value");
            Id = id;
        }

        public void ValidateDomain(string name, int idade, double peso, double altura, int serie, int repeticao, DateTime created_at, DateTime deleted_at, DateTime updated_at)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name, name is required");
            DomainExceptionValidation.When(name.Length < 5, "Invalid name, too short");
            DomainExceptionValidation.When(idade <= 0, "Invalid idade, idade must be greater than 0");
            DomainExceptionValidation.When(peso < 20.0, "Invalid peso, invalid peso value too small");
            DomainExceptionValidation.When(peso > 600.0, "Invalid peso, invalid peso value, too big");
            DomainExceptionValidation.When(altura < 0.6, "Invalid altura, too short" );
            DomainExceptionValidation.When(altura > 2.51, "Invalid altura, too big");
            DomainExceptionValidation.When(serie <= 0, "Invalid amount serie, required more then 0");
            DomainExceptionValidation.When(serie > 8, "Invalid serie, too long");
            DomainExceptionValidation.When(repeticao < 3, "Invalid repetion amount, too short");
            DomainExceptionValidation.When(repeticao > 30, "Invalid repetion amount, too long");
            Name = name;
            Idade = idade;
            Peso = peso;
            Altura = altura;
            Serie = serie;
            Repeticao = repeticao;
            Created_at = created_at;
            Deleted_at = deleted_at;
            Updated_at = updated_at;
        }
        
    }
}