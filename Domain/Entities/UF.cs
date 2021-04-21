using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class UF : Entity
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }
    }
}
