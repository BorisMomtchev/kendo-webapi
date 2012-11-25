using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NiCris.BusinessObjects;
using NiCris.DataAccess.Interfaces;

namespace NiCris.WebAPI.Controllers
{
    public class ContinentController : BaseController<Continent>
    {
        // FIELDS
        private readonly IContinentRepository _continentRepository;

        /// <summary>
        /// Dependency Injection using Unity.  Look at the App_Start/UnityWebApi.cs file for usage.
        /// </summary>
        /// <param name="repository"></param>
        public ContinentController(IContinentRepository continentRepository)
            : base(continentRepository)
        {
            this._continentRepository = continentRepository;
        }
    }
}