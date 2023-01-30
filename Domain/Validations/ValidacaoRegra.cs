using Entities.Entities;
using Intera.CasaPopular.Domain.Interfaces.Validacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intera.CasaPopular.Domain.Validations
{
    //pode receber uma <T>
    public class ValidacaoRegra : IValidacaoRegra
    {
        private readonly List<Familia> _familia;

        //Regra pode vir do banco minha tabela Criterios
        public int IsRendaRegra1(decimal renda)
        {
            return (renda > 0 && renda <= 900.00M) ? 5 : 0;
        }
        public int IsRendaRegra2(decimal renda)
        {
            return (renda > 900.00M && renda < 1500.00M) ? 3 : 0;
        }

        public int IsMaiorIdadeValidador(List<Familia> familias)
        {
            int response = 0;
            int qtdMenores = 0;
            foreach (var familia in familias)
            {
                int idade = DateTime.Now.Year - familia.Pessoa.DataNascimento.Year;
                if (DateTime.Now.DayOfYear < familia.Pessoa.DataNascimento.Year) idade = idade - 1;
                if (idade < 18) qtdMenores += 1;
            }
            if (qtdMenores >= 3) response = 3;
            if (qtdMenores >= 1 && qtdMenores < 3) response = 2;
            return response;
        }
    }
}
