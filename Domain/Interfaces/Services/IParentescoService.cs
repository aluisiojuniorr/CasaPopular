using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intera.CasaPopular.Domain.Interfaces.Services
{
    public interface IParentescoService
    {
        void AddParentesco(Parentesco objeto);
        void UpdateParentesco(Parentesco objeto);
    }
}
