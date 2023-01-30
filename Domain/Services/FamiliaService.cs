using Domain.Interfaces;
using Entities.Entities;
using Intera.CasaPopular.Domain.Interfaces.Services;
using Intera.CasaPopular.Domain.Interfaces.Validacao;
using Intera.CasaPopular.Domain.Validations;
using System.Collections.Generic;
using System.Linq;

namespace Intera.CasaPopular.Domain.Services
{
    public class FamiliaService : IFamiliaService
    {
        private readonly IFamilia _IFamilia;
        private readonly IValidacaoRegra _IValidacaoRegra;

        public FamiliaService(IFamilia IFamilia, IValidacaoRegra IValidacaoRegra)
        {
            _IFamilia = IFamilia;
            _IValidacaoRegra = IValidacaoRegra;
        }

        public void Adicionar(Familia objeto)
        {
            var valido = objeto.ValidarPropriedadeString(objeto.CodigoFamilia, nameof(objeto.Nome));
            if (valido)
                _IFamilia.Add(objeto);
        }

        public void Atualizar(Familia objeto)
        {
            var valido = objeto.ValidarPropriedadeString(objeto.Nome, nameof(objeto.Nome));

            if (valido)
                _IFamilia.Update(objeto);
        }

        public IList<Familia> FamiliasPorCriterio()
        {
            List<Familia> familias = new List<Familia>();
            var regras = new ValidacaoRegra();
            var familiasPorGroupo = _IFamilia.ListFamiliasCriterio().GroupBy(a => a.CodigoFamilia).ToList();

            foreach (var familia in familiasPorGroupo)
            {
                var familiaPretendente = new Familia();
                int pontos = 0;
                pontos += _IValidacaoRegra.IsRendaRegra2(familia.Sum(a => a.Renda));
                pontos += _IValidacaoRegra.IsRendaRegra1(familia.Sum(a => a.Renda));
                pontos += _IValidacaoRegra.IsMaiorIdadeValidador(familia.ToList());
                familiaPretendente = familia.Where(a => a.IsPretendente).FirstOrDefault();
                familiaPretendente.Pontos = pontos;
                familias.Add(familiaPretendente);
            }
            return familias.OrderByDescending(a => a.Pontos).ToList();
        }
    }
}
