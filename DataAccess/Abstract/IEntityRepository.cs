using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T GetById(int id);
        List<T> GetAll();

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
