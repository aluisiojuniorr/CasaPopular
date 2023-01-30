using ApplicationApp.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface IParentescoApp : IGenericApp<Parentesco>
    {
        void AddParentesco(Parentesco Parentesco);
        void UpdateParentesco(Parentesco Parentesco);
    }
}
