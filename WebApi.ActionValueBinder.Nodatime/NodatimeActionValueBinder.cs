using System.Web.Http.Controllers;
using NodaTime;
using WebApi.ActionValueBinder.Contrib;

namespace WebApi.ActionValueBinder.Nodatime
{
	public class InstantBinder : IActionBinding
	{
		public bool CanBind(HttpParameterDescriptor parameter)
		{
			return parameter.ParameterType == typeof (Instant) || parameter.ParameterType == typeof (Instant?);
		}

		public HttpParameterBinding Bind(HttpParameterDescriptor parameter)
		{
			return parameter.BindWithModelBinding(new InstantModelBinder());
		}
	}
}
