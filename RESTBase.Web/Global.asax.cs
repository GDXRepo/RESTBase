using System.Web;
using System.Web.Http;
using Newtonsoft.Json;

namespace RESTBase.Web
{
	public class Global : HttpApplication
	{
		protected void Application_Start()
		{
			var config = GlobalConfiguration.Configuration;
			// configure JSON
			var json = config.Formatters.JsonFormatter;
			json.SerializerSettings.DateFormatString = "YYYY-MM-ddTHH:mm:ssZ";
			json.SerializerSettings.DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate;
			// remove XML formatter
			config.Formatters.Remove(config.Formatters.XmlFormatter);
			// finish configuration
			GlobalConfiguration.Configure(WebApiConfig.Register);
		}
	}
}
