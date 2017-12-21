using FGA.Congressus2.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGA.Congressus2.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T: class
    {        
        Task Create(T entity);
        Task<IQueryable<T>> FindAll();
        Task<T> FindById(int entityId);
        Task Update(T entity);
        Task Delete(T entity);
        Task Delete(int entityId);
    }
}
