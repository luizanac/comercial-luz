using System.Collections.Generic;
using ContaLuz.Domain;

namespace ContaLuz.Data
{
    public interface IRepository<T> where T : Entity
    {
        void Save(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Delete(int id);
        void Update(T entity);
        void Commit();
    }
}