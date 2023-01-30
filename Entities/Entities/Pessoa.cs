using Intera.CasaPopular.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Pessoa : Base
    {
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Display(Name = "DataNascimento")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Sexo")]
        public EnumSexo Sexo { get; set; }
    }
}