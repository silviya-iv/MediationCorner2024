using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Infrastructure.Common
{
    public class Repository : IRepository
    {
        public Task AddAsync<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> All<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync<T>(object id) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
