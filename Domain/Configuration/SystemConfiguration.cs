using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Configuration
{
    public class SystemConfiguration : Entity
    {
        public bool UsuarioLogado { get; set; }
        public string UsuarioNome { get; set; }

    }
    public class RetryPolicy : Entity
    {
        public int QuantidadeRetry { get; set; }
        public int TempoDeEsperaEmSegundos { get; set; }
        public string SessionId { get; set; }
    }
}
