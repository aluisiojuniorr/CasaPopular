using Domain.Interfaces;
using Entities.Entities;
using Intera.CasaPopular.Domain.Interfaces.Services;

namespace Intera.CasaPopular.Domain.Services
{
    public class ParentescoService : IParentescoService
    {
        private readonly IParentesco _IParentesco;

        public ParentescoService(IParentesco IParentesco)
        {
            _IParentesco = IParentesco;
        }

        public void AddParentesco(Parentesco objeto)
        {
            var valido = objeto.ValidarPropriedadeString(objeto.Nome, nameof(objeto.Nome));
            if (valido)
                _IParentesco.Add(objeto);
        }

        public void UpdateParentesco(Parentesco objeto)
        {
            var valido = objeto.ValidarPropriedadeString(objeto.Nome, nameof(objeto.Nome));

            if (valido)
                _IParentesco.Update(objeto);
        }
    }
}