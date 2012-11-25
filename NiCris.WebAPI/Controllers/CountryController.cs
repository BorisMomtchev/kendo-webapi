using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NiCris.BusinessObjects;
using NiCris.DataAccess.Interfaces;

namespace NiCris.WebAPI.Controllers
{
    public class CountryController : BaseController<Country>
    {
        // FIELDS
        private readonly ICountryRepository _countryRepository;

        /// <summary>
        /// Dependency Injection using Unity.  Look at the App_Start/UnityWebApi.cs file for usage.
        /// </summary>
        /// <param name="repository"></param>
        public CountryController(ICountryRepository countryRepository) : base(countryRepository)
        {
            this._countryRepository = countryRepository;
        }
    }
}