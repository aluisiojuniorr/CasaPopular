using Domain.Interfaces;
using Entities.Entities;
using Intera.CasaPopular.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intera.CasaPopular.Domain.Services
{
    public class CriterioService : ICriterioService
    {
        private readonly ICriterio _ICriterio;

        public CriterioService(ICriterio ICriterio)
        {
            _ICriterio = ICriterio;
        }

        public void AddCriterio(Criterio objeto)
        {
            var valido = objeto.ValidarPropriedadeString(objeto.Nome, nameof(objeto.Nome));
            if (valido)
                _ICriterio.Add(objeto);
        }

        public void UpdateCriterio(Criterio objeto)
        {
            var valido = objeto.ValidarPropriedadeString(objeto.Nome, nameof(objeto.Nome));

            if (valido)
                _ICriterio.Update(objeto);
        }
    }
}
