using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    public class Familia : Base
    {
        [Display(Name = "CodigoFamilia")]
        public string CodigoFamilia { get; set; }

        [Display(Name = "Renda")]
        public decimal Renda { get; set; }

        [Display(Name = "IsPretendente")]
        public bool IsPretendente { get; set; }

        [Display(Name = "IsConjuge")]
        public bool IsConjuge { get; set; }

        [Display(Name = "DataCriacao")]
        public DateTime? DataCriacao { get; set; }

        [Display(Name = "DataAtualizacao")]
        public DateTime? DataAtualizacao { get; set; }

        [Display(Name = "Pessoa")]
        [ForeignKey("Pessoa")]
        [Column(Order = 1)]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        [Display(Name = "Parentesco")]
        [ForeignKey("Parentesco")]
        [Column(Order = 1)]
        public int ParentescoId { get; set; }
        public virtual Parentesco Parentesco { get; set; }

        [NotMapped]
        public int Pontos { get; set; }
    }
}
