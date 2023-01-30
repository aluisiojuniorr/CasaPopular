using Domain.Interfaces;
using Entities.Entities;
using Infraestructure.Configuration;
using Infraestructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Infraestructure.Repository
{
    public class RepositoryFamilia : RepositoryGenerico<Familia>, IFamilia
    {
        private readonly DbContextOptions<Contexto> _OptionsBuilder;

        public RepositoryFamilia()
        {
            _OptionsBuilder = new DbContextOptions<Contexto>();
        }

        public IList<Familia> ListFamilias()
        {
            using (var banco = new Contexto(_OptionsBuilder))
            {
                var sistemasusuario = (from f in banco.Familia select f).ToList();
                //Fazer a consulta
                return sistemasusuario;
            }
        }

        public IList<Familia> ListFamiliasCriterio()
        {
            using (var banco = new Contexto(_OptionsBuilder))
            {
                var sistemasusuario = (from f in banco.Familia
                                       join p in banco.Pessoa on f.PessoaId equals p.Id
                                       select f).Include(a => a.Pessoa).ToList();
                //Fazer a consulta
                return sistemasusuario;
            }
        }

        public IList<Familia> FamiliasPorCriterio()
        {
            using (var banco = new Contexto(_OptionsBuilder))
            {
                var sistemasusuario = (from f in banco.Familia
                                       join p in banco.Pessoa on f.PessoaId equals p.Id
                                       select f).Include(a => a.Pessoa).ToList();
                //Fazer a consulta
                return sistemasusuario;
            }
        }


    }
}