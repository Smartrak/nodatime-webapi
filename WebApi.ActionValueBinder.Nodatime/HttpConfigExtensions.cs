using System.Web.Http;
using System.Web.Http.Controllers;
using WebApi.ActionValueBinder.Contrib;

namespace WebApi.ActionValueBinder.Nodatime
{
	public static class HttpConfigExtensions
	{
		public static void ConfigureNodatimeWebApi(this HttpConfiguration config)
		{
			ConfigureNodatimeWebApi(config, new MultiActionBinder());
		}

		public static void ConfigureNodatimeWebApi(this HttpConfiguration config, MultiActionBinder actionValueBinder)
		{
			actionValueBinder.AddBinding(new InstantBinder());
			config.Services.Replace(typeof(IActionValueBinder), actionValueBinder);
		}
	}
}
