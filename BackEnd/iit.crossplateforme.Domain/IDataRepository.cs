using System.Collections.Generic;

namespace iit.crossplateforme.Domain
{
	public interface IDataRepository<TEntity>
	{
		IList<TEntity> GetAll();
		TEntity Get(long id);
		void Add(TEntity entity);
	}
}
