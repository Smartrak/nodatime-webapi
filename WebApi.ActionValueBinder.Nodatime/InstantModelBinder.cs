using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using NodaTime.Text;

namespace WebApi.ActionValueBinder.Nodatime
{
	public class InstantModelBinder : IModelBinder
	{
		public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
		{
			var key = bindingContext.ModelName;
			var val = bindingContext.ValueProvider.GetValue(key);
			if (val != null)
			{
				var s = val.AttemptedValue;

				var result = InstantPattern.ExtendedIsoPattern.Parse(s);
				if (result.Success)
				{
					bindingContext.Model = result.Value;
					return true;
				}
			}
			return false;
		}
	}
}
