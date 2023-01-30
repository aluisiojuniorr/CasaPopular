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
    public class ParentescoApp : IParentescoApp
    {
        IParentesco _IParentesco;
        IParentescoService _IParentescoService;

        public ParentescoApp(IParentesco IParentesco, IParentescoService IParentescoService)
        {
            _IParentesco = IParentesco;
            _IParentescoService = IParentescoService;

        }

        public void AddParentesco(Parentesco objeto)
        {
            _IParentescoService.AddParentesco(objeto);
        }

        public void UpdateParentesco(Parentesco objeto)
        {
            _IParentescoService.UpdateParentesco(objeto);
        }

        public async Task Add(Parentesco Objeto)
        {
            await _IParentesco.Add(Objeto);
        }

        public async Task Delete(Parentesco Objeto)
        {
            await _IParentesco.Delete(Objeto);
        }

        public async Task<Parentesco> GetEntityById(int Id)
        {
            return await _IParentesco.GetEntityById(Id);
        }

        public async Task<List<Parentesco>> List()
        {
            return await _IParentesco.List();
        }

        public async Task Update(Parentesco Objeto)
        {
            await _IParentesco.Update(Objeto);
        }
    }
}
