using ApplicationApp.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationApp.Interfaces
{
    public interface IPessoaApp : IGenericApp<Pessoa>
    {
        void AddPessoa(Pessoa objeto);
        
        void UpdatePessoa(Pessoa objeto);

        IList<Pessoa> ListPessoasPorCpf(string cpf);
    }
}
