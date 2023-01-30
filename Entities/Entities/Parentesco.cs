using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Parentesco : Base
    {
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }
    }
}
