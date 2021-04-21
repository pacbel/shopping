using System;

namespace Domain.Base
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public byte Ativo { get; set; }
        public DateTime DataLog { get; set; }
    }
}
