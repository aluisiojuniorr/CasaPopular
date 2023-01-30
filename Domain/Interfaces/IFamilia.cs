using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IFamilia : IGeneric<Familia>
    {
        IList<Familia> ListFamiliasCriterio();

        IList<Familia> ListFamilias();

        IList<Familia> FamiliasPorCriterio();

        
    }
}
