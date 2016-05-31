using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.ModelBinding.Binders;
using NodaTime;

namespace Nodatime.Webapi
{
    public static class HttpConfigExtensions
    {
	    public static void ConfigureNodatimeWebapi(this HttpConfiguration config)
	    {
			var provider = new SimpleModelBinderProvider(typeof(Instant), new InstantModelBinder());
			config.Services.Insert(typeof(ModelBinderProvider), 0, provider);
		}
    }
}
