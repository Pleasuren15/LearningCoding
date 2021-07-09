using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LearningCoding.Data
{
    public interface IRepositoryBase<T>
    {
        void Create(T element);
        void Remove(T element);
        void Update(T element);
        void Save();
        IEnumerable<T> FindAll();
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        T FindById(int Id);
    }
}
