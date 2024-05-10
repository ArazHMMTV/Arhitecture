using Pronia.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Core.RepositoryAbstract
{
    public interface IGenericRepository<T> where T :BaseEntity , new()
    {
        void Add(T entity);
        void Delete(T entity);
        int Commit();
        Task<int> CommitAsync();
        T Get(Func<T, bool>? func = null);
        List<T> GetALl(Func<T, bool>? func = null);
    }
}
