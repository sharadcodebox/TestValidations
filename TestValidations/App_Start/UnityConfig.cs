using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using TestValidations.Repository;
using TestValidations.Controllers;

namespace TestValidations
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService
            container.RegisterType<IIMDBRepository, IMDBRepositoryTwo>();
            container.RegisterType<IIMDBRepository, IMDBRepository>();
            
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}