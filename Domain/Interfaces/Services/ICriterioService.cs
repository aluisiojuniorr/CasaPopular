using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intera.CasaPopular.Domain.Interfaces.Services
{
    public interface ICriterioService
    {
        void AddCriterio(Criterio objeto);
        void UpdateCriterio(Criterio objeto);

    }
}
