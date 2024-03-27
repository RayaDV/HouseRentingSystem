using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HouseRentingSystem.ModelBindders
{
    public class DecimalModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(decimal) ||
                context.Metadata.ModelType == typeof(decimal?))
            {
                return new DecimalModelBinder();
            }

            return null;  // if return null, it will be ignored and will go to the next modelBinder
        }
    }
}
