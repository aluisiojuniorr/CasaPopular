using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Criterio : Base
    {
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }

        [Display(Name = "Pontos")]
        public int QtdPontos { get; set; }

        [Display(Name = "DataVigencia")]
        public DateTime DataVigencia { get; set; }

        [Display(Name = "Observacao")]
        public string Observacao { get; set; }
    }
}
