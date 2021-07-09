using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LearningCoding.Data
{
    public class CRepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        AppDbContext _appDbContext;

        public CRepositoryBase(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Create(T element)
        {
            _appDbContext.Set<T>().Add(element);
        }

        public IEnumerable<T> FindAll()
        {
            return _appDbContext.Set<T>();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _appDbContext.Set<T>().Where(expression);
        }

        public T FindById(int Id)
        {
            return _appDbContext.Set<T>().Find(Id);
        }

        public void Remove(T element)
        {
            _appDbContext.Set<T>().Remove(element);
        }

        public void Save()
        {
            _appDbContext.SaveChanges();
        }

        public void Update(T element)
        {
            _appDbContext.Set<T>().Update(element);
        }
    }
}
