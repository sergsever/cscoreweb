using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cscoreweb.Data
{
	public interface IDAO<Entity>
	{
		void Add(Entity entitity);
		IEnumerable<Entity> GetAll();


	}
}
