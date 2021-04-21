using System;

namespace Domain.Base
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public int Ativo { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
