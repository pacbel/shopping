using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class IndiceMonetario : Entity
    {
        [Display(Name = "Nome do Índice")]
        public string NomeIndice { get; set; }
        [Display(Name = "Código Banco Central")]
        public int CodBancoCentral { get; set; }
    }
}
