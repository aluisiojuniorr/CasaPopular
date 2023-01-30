using Entities.Entities;

namespace Intera.CasaPopular.Domain.Interfaces.Services
{
    public interface IPessoaService
    {
        void AddPessoa(Pessoa objeto);
        void UpdatePessoa(Pessoa objeto);

    }
}
