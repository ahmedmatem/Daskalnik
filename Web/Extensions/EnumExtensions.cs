using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Web.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayDescription(this Enum enumValue)
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()?
                .GetCustomAttribute<DisplayAttribute>()?
                .GetDescription() ?? "unknown";
        }
    }
}
