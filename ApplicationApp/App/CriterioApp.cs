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
    public class CriterioApp : ICriterioApp
    {
        ICriterio _ICriterio;
        ICriterioService _ICriterioService;

        public CriterioApp(ICriterio ICriterio, ICriterioService ICriterioService)
        {
            _ICriterio = ICriterio;
            _ICriterioService = ICriterioService;
        }

        public IList<Criterio> ListCriterios(string emailUsuario)
        {
            return _ICriterio.ListCriterios(emailUsuario);
        }

        public void AddCriterio(Criterio objeto)
        {
            _ICriterioService.AddCriterio(objeto);
        }

        public void UpdateCriterio(Criterio objeto)
        {
            _ICriterioService.UpdateCriterio(objeto);
        }

        public async Task Add(Criterio objeto)
        {
            await _ICriterio.Add(objeto);
        }

        public async Task Delete(Criterio objeto)
        {
            await _ICriterio.Delete(objeto);
        }

        public async Task<Criterio> GetEntityById(int Id)
        {
            return await _ICriterio.GetEntityById(Id);
        }

        public async Task<List<Criterio>> List()
        {
            return await _ICriterio.List();
        }

        public async Task Update(Criterio objeto)
        {
            await _ICriterio.Update(objeto);
        }

    }
}
