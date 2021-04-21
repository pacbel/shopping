using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class Empresa : Entity
    {
        public  string Sigla { get; set; }
        [Display(Name = "Nome Fantasia")]
        public string  NomeFantasia { get; set; }
        [Display(Name = "Razão Social")]
        public string RazaoSocial{ get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string  Estado { get; set; }
        public string CNPJ { get; set; }
        [Display(Name = "Inscrição Estadual")]
        public string  InscricaoEstadual { get; set; }

    }
}
