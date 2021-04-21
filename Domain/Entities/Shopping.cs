using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Shopping : Entity
    {
        public Empresa Empresa { get; set; }
        public string Sigla { get; set; }
        public int Serial { get; set; }
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }
        public string  Bairro { get; set; }
        public UF Uf { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string CNPJ { get; set; }
        public string IncricaoEstadual { get; set; }
        public string EmailPrincipal { get; set; }
        public string Contato { get; set; }
    }
}
