using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IPessoa : IGeneric<Pessoa>
    {
        IList<Pessoa> ListPessoasPorCpf(string cpf);
    }
}
