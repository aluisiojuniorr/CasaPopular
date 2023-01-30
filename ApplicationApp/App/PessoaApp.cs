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
    public class PessoaApp : IPessoaApp
    {
        IPessoa _IPessoa;
        IPessoaService _IPessoaService;

        public PessoaApp(IPessoa IPessoa, IPessoaService IPessoaService)
        {
            _IPessoa = IPessoa;
            _IPessoaService = IPessoaService;
        }
        public void AddPessoa(Pessoa objeto)
        {
            _IPessoaService.AddPessoa(objeto);
        }

        public void UpdatePessoa(Pessoa objeto)
        {
            _IPessoaService.UpdatePessoa(objeto);
        }

        public IList<Pessoa> ListPessoasPorCpf(string cpf)
        {
            return _IPessoa.ListPessoasPorCpf(cpf);
        }

        public async Task Add(Pessoa Objeto)
        {
            await _IPessoa.Add(Objeto);
        }

        public async Task Delete(Pessoa Objeto)
        {
            await _IPessoa.Delete(Objeto);
        }

        public async Task<Pessoa> GetEntityById(int Id)
        {
            return await _IPessoa.GetEntityById(Id);
        }

        public async Task<List<Pessoa>> List()
        {
            return await _IPessoa.List();
        }

        public async Task Update(Pessoa Objeto)
        {
            await _IPessoa.Update(Objeto);
        }
    }
}
