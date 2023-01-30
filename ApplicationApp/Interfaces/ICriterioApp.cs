using ApplicationApp.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationApp.Interfaces
{
    public interface ICriterioApp : IGenericApp<Criterio>
    {
        IList<Criterio> ListCriterios(string emailUsuario);

        void AddCriterio(Criterio objeto);
        void UpdateCriterio(Criterio objeto);
    }
}
