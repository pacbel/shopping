using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Configuration
{
    public class SystemConfiguration
    {
        public bool UsuarioLogado { get; set; }
        public string UsuarioNome { get; set; }

    }
    public class RetryPolicy
    {
        public int QuantidadeRetry { get; set; }
        public int TempoDeEsperaEmSegundos { get; set; }
        public string SessionId { get; set; }
    }
}
