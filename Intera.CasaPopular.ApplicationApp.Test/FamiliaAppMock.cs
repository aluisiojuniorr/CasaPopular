using ApplicationApp.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Intera.CasaPopular.ApplicationApp.Test
{
    public class FamiliaAppMock : IFamiliaApp
    {
        private readonly List<Familia> _familia;

        public FamiliaAppMock()
        {
            _familia = new List<Familia>()
            {
                new Familia(){
                    CodigoFamilia = "1001",
                    DataAtualizacao = DateTime.Now,
                    DataCriacao= DateTime.Now,
                    IsConjuge = false,
                    IsPretendente = true,
                    ParentescoId = 2,
                    PessoaId = 39,
                    Renda = 500.00M
                }
            };
        }

        public Task Add(Familia Objeto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Familia Objeto)
        {
            throw new NotImplementedException();
        }

        public IList<Familia> FamiliasPorCriterio()
        {
            return _familia;
        }

        public Task<Familia> GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Familia>> List()
        {
            throw new NotImplementedException();
        }

        public IList<Familia> ListFamilias()
        {
            throw new NotImplementedException();
        }

        public IList<Familia> ListFamiliasCriterio()
        {
            throw new NotImplementedException();
        }

        public Task Update(Familia Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
