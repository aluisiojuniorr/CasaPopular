using System;
using System.Collections.Generic;
using System.Text;

namespace Intera.CasaPopular.Domain.Validations.ValueObjects
{
    public class CpfCnpj
    {
        public string Valor { get; private set; }
        public string ValorSemMascara { get; private set; }

        public CpfCnpj(string valor)
        {
            Valor = valor.Trim();
            ValorSemMascara = RemoverMascara(valor);
        }

        public static CpfCnpj Novo(string valor)
        {
            return new CpfCnpj(valor);
        }

        public static string RemoverMascara(string valor)
        {
            return valor.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
        }
    }
}
