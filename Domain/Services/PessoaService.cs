using Domain.Interfaces;
using Entities.Entities;
using Intera.CasaPopular.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Intera.CasaPopular.Domain.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoa _IPessoa;

        public PessoaService(IPessoa IPessoa)
        {
            _IPessoa = IPessoa;
        }

        public void AddPessoa(Pessoa objeto)
        {
            var valido = objeto.ValidarPropriedadeString(objeto.Nome, nameof(objeto.Nome));
            if (valido)
                _IPessoa.Add(objeto);
        }

        public void UpdatePessoa(Pessoa objeto)
        {
            var valido = objeto.ValidarPropriedadeString(objeto.Nome, nameof(objeto.Nome));

            if (valido)
                _IPessoa.Update(objeto);
        }
    }
}