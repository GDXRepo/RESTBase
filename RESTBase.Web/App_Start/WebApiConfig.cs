using System.Web.Http;
using RESTBase.Data.DAL;
using RESTBase.Data.Models;
using RESTBase.Domain;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace RESTBase.Web
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Dependency Injection
			var container = new Container();
			container.Register<IAdapter, Adapter>(Lifestyle.Singleton);
			// services list
			container.Register<IUtilsService, UtilsService>(Lifestyle.Singleton);
			// finish injection
			config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

			// Web API routes
			config.MapHttpAttributeRoutes();
		}
	}
}
