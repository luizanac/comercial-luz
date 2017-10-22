using System.Collections.Generic;
using ContaLuz.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ContaLuz.Data
{
	public class Repository<T> : IRepository<T> where T : Entity
	{

		private readonly DbContext _context;
		private readonly DbSet<T> _entity;
		
		public Repository(ApplicationDbContext context){
			_context = context;
			_entity = _context.Set<T>();
		}

		public void Delete(int id)
		{
			_entity.Remove(GetById(id));
		}

		public IEnumerable<T> GetAll()
		{
			return _entity.AsEnumerable();
		}

		public T GetById(int id)
		{
			return _entity.SingleOrDefault(e => e.Id == id);
		}

		public void Save(T entity)
		{
			_entity.Add(entity);
		}

		public void Update(T entity)
		{
			_entity.Update(entity);
		}

		public void Commit(){
			_context.SaveChanges();
		}
	}
}