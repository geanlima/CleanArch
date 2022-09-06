using CleanArch.Domain.Entities;
using CleanArch.Domain.Validation;
using System.Collections.Generic;

namespace CleanArch.Domain.Entites
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }
        public ICollection<Product> Products { get; private set; }

        public Category(string name)
        {
            ValidateDomain(name);
            Name = name;
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            Id = id;
            ValidateDomain(name);
        }

        public void Update(string nome)
        {
            ValidateDomain(nome);
        }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), 
                "Invalid Name is required");
            DomainExceptionValidation.When(name.Length < 3, 
                "Invalid name, too short, minimum 3 characters");

            Name = name;
        }

    }
}
