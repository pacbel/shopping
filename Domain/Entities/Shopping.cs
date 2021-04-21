using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class Shopping : Entity
    {
        public Empresa Empresa { get; set; }
        public string Sigla { get; set; }
        public int Serial { get; set; }

        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public string  Bairro { get; set; }
        public UF Uf { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string CNPJ { get; set; }
        [Display(Name = "Inscrição Estadual")]
        public string IncricaoEstadual { get; set; }
        [Display(Name = "E-mail Principal")]
        public string EmailPrincipal { get; set; }
        public string Contato { get; set; }
    }
}
