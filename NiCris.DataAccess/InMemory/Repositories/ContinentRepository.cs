using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NiCris.DataAccess.Interfaces;
using NiCris.BusinessObjects;

namespace NiCris.DataAccess.InMemory
{
    public class ContinentRepository : IContinentRepository
    {
        // FIELDS
        private List<Continent> _continent;

        // C~tors
        public ContinentRepository()
	    {
            _continent = ContinentData.Current;
	    }

        #region IRepository<Continent> Members

        public IQueryable<BusinessObjects.Continent> GetAll()
        {
            return _continent.AsQueryable();
        }

        public BusinessObjects.Continent GetById(object id)
        {
            return _continent.Where(c => c.id == (int)id).SingleOrDefault();
        }

        public IEnumerable<BusinessObjects.Continent> Get(System.Linq.Expressions.Expression<Func<BusinessObjects.Continent, bool>> filter = null, Func<IQueryable<BusinessObjects.Continent>, IOrderedQueryable<BusinessObjects.Continent>> orderBy = null, string includeProperties = "")
        {
            IQueryable<Continent> query = _continent.AsQueryable();

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                return orderBy(query).ToList();
            else
                return query.ToList();
        }

        public void Insert(BusinessObjects.Continent entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(BusinessObjects.Continent entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Update(BusinessObjects.Continent entityToUpdate)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
