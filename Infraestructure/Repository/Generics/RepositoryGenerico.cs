using Domain.Interfaces.Generics;
using Infraestructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Generics
{
    public class RepositoryGenerico<T> : IGeneric<T>, IDisposable where T : class
    {

        private readonly DbContextOptions<Contexto> _OptionsBuilder;

        public RepositoryGenerico()
        {
            _OptionsBuilder = new DbContextOptions<Contexto>();
        }

        public async Task Add(T Objeto)
        {
            using (var data = new Contexto(_OptionsBuilder))
            {
                await data.Set<T>().AddAsync(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task Delete(T Objeto)
        {
            using (var data = new  Contexto(_OptionsBuilder))
            {
                data.Set<T>().Remove(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task<T> GetEntityById(int Id)
        {
            using (var data = new Contexto(_OptionsBuilder))
            {
                return await data.Set<T>().FindAsync(Id);
            }
        }

        public async Task<List<T>> List()
        {
            using (var data = new Contexto(_OptionsBuilder))
            {
                return await data.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        public async Task Update(T Objeto)
        {
            using (var data = new Contexto(_OptionsBuilder))
            {
                data.Set<T>().Update(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
