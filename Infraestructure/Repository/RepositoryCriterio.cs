using Domain.Interfaces;
using Entities.Entities;
using Infraestructure.Configuration;
using Infraestructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infraestructure.Repository
{
    public class RepositoryCriterio : RepositoryGenerico<Criterio>, ICriterio
    {
        private readonly DbContextOptions<Contexto> _OptionsBuilder;

        public RepositoryCriterio()
        {
            _OptionsBuilder = new DbContextOptions<Contexto>();
        }

        public IList<Criterio> ListCriterios(string codigo)
        {
            using (var banco = new Contexto(_OptionsBuilder))
            {
                return (from c in banco.Criterio select c).ToList();
            }
        }
    }
}