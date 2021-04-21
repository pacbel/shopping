using System;
using System.Linq;
using FluentValidation.Results;

namespace Domain.Base
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public int Ativo { get; set; }
        public DateTime DataRegistro { get; set; }
        public ValidationResult ValidationResult { get; protected set; }
        public string[] ErrorMessages => ValidationResult?.Errors?.Select(a => a.ErrorMessage)?.ToArray();
    }
}
