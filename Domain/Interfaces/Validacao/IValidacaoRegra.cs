using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intera.CasaPopular.Domain.Interfaces.Validacao
{
    public interface IValidacaoRegra
    {
        public int IsRendaRegra1(decimal renda);
        public int IsRendaRegra2(decimal renda);
        public int IsMaiorIdadeValidador(List<Familia> familias);

    }
}
