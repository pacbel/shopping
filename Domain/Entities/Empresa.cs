using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Empresa : Entity
    {
        public  string Sigla { get; set; }
        public string  NomeFantasia { get; set; }
        public string RazaoSocial{ get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string  Estado { get; set; }
        public string CNPJ { get; set; }
        public string  InscricaoEstadual { get; set; }

    }
}
