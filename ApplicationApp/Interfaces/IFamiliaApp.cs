using ApplicationApp.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationApp.Interfaces
{
    public interface IFamiliaApp : IGenericApp<Familia>
    {
        IList<Familia> ListFamilias();

        IList<Familia> ListFamiliasCriterio();

        IList<Familia> FamiliasPorCriterio();

        
        //void AdicionarCategoria(Categoria categoria);
        //void AtualizarCategoria(Categoria categoria);
    }
}
