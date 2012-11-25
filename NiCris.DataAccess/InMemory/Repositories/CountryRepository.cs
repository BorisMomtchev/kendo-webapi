using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using NiCris.BusinessObjects;
using NiCris.DataAccess.Interfaces;

namespace NiCris.DataAccess.InMemory
{
    public class CountryRepository : ICountryRepository
    {
        // FIELDS
        private List<Country> _country;

        // C~tors
        public CountryRepository ()
	    {
            _country = CountryData.Current;
	    }

        #region IRepository<Country> Members

        public IQueryable<BusinessObjects.Country> GetAll()
        {
            return _country.AsQueryable();
        }

        public BusinessObjects.Country GetById(object id)
        {
            return _country.Where(c => c.id == (int)id).SingleOrDefault();
        }

        public IEnumerable<BusinessObjects.Country> Get(
            Expression<Func<BusinessObjects.Country, bool>> filter = null, 
            Func<IQueryable<BusinessObjects.Country>, 
            IOrderedQueryable<BusinessObjects.Country>> orderBy = null, 
            string includeProperties = "")
        {
            IQueryable<Country> query = _country.AsQueryable();

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                return orderBy(query).ToList();
            else
                return query.ToList();
        }

        public void Insert(BusinessObjects.Country entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(BusinessObjects.Country entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Update(BusinessObjects.Country entityToUpdate)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
