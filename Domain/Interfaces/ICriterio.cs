using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface ICriterio : IGeneric<Criterio>
    {
        IList<Criterio> ListCriterios(string emailUsuario);
    }
}
