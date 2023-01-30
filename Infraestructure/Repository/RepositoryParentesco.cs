using Domain.Interfaces;
using Entities.Entities;
using Infraestructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Repository
{
    public class RepositoryParentesco : RepositoryGenerico<Parentesco>, IParentesco
    {
    }
}
