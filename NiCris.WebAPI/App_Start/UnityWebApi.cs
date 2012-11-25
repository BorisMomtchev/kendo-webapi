[assembly: WebActivator.PreApplicationStartMethod(typeof(NiCris.WebAPI.App_Start.UnityWebApi), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(NiCris.WebAPI.App_Start.UnityWebApi), "Stop")]

namespace NiCris.WebAPI.App_Start
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using NiCris.DataAccess.Interfaces;
    using Microsoft.Practices.Unity;

    public static class UnityWebApi
    {
        private static IUnityContainer container;

        #region Public Methods

        public static void Start()
        {
            Initialise();
        }

        public static void Stop(){} 

        #endregion

        #region Private Methods

        private static void Initialise()
        {
            container = BuildUnityContainer();
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            
            container.RegisterType<IProductRepository, NiCris.DataAccess.InMemory.ProductRepository>();
            container.RegisterType<ICountryRepository, NiCris.DataAccess.InMemory.CountryRepository>();
            container.RegisterType<IContinentRepository, NiCris.DataAccess.InMemory.ContinentRepository>();

            return container;
        } 

        #endregion
    }
}