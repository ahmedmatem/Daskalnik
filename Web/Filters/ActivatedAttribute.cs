using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using static Core.Claims.CustomUserClaims;

namespace Web.Filters
{
    public class ActivatedAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var activeClaim = context.HttpContext.User.Claims
                .Where(c => c.Type == ActiveClaim.Key)
                .FirstOrDefault();
            if (activeClaim == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary()
                {
                    { "Area", "Default"},
                    { "controller", "Home"},
                    { "action", "NotActivated"}
                });
            }
            base.OnActionExecuting(context);
        }
    }
}
