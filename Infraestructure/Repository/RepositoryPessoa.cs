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
    public class RepositoryPessoa : RepositoryGenerico<Pessoa>, IPessoa
    {
        private readonly DbContextOptions<Contexto> _OptionsBuilder;

        public RepositoryPessoa()
        {
            _OptionsBuilder = new DbContextOptions<Contexto>();
        }

        public IList<Pessoa> ListPessoasPorCpf(string cpf)
        {
            using (var banco = new Contexto(_OptionsBuilder))
            {
                return (from p in banco.Pessoa
                        where p.Cpf.Equals(cpf)
                        select p).ToList();
            }
        }
    }
}
