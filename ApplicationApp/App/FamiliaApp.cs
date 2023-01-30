using ApplicationApp.Interfaces;
using Domain.Interfaces;
using Entities.Entities;
using Intera.CasaPopular.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.App
{
    public class FamiliaApp : IFamiliaApp
    {
        IFamilia _IFamilia;
        IFamiliaService _IFamiliaService;

        public FamiliaApp(IFamilia IFamilia, IFamiliaService IFamiliaService)
        {
            _IFamilia = IFamilia;
            _IFamiliaService = IFamiliaService;
        }

        public IList<Familia> FamiliasPorCriterio()
        {
            return _IFamiliaService.FamiliasPorCriterio();
        }

        public IList<Familia> ListFamilias()
        {
            return _IFamilia.ListFamilias();
        }

        public IList<Familia> ListFamiliasCriterio()
        {
            return _IFamilia.ListFamiliasCriterio();
        }

        public async Task Add(Familia Objeto)
        {
            await _IFamilia.Add(Objeto);
        }

        public async Task Delete(Familia Objeto)
        {
            await _IFamilia.Delete(Objeto);
        }

        public async Task<Familia> GetEntityById(int Id)
        {
            return await _IFamilia.GetEntityById(Id);
        }

        public async Task<List<Familia>> List()
        {
            return await _IFamilia.List();
        }

        public async Task Update(Familia Objeto)
        {
            await _IFamilia.Update(Objeto);
        }
    }
}
