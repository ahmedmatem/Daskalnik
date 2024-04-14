using Core.Contracts;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace Web.Filters
{
    public class IsDeletedAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var studentService = (IStudentService) context.HttpContext.RequestServices.GetService(typeof(IStudentService))!;

            string userId = context
                .HttpContext
                .User
                .FindFirstValue(ClaimTypes.NameIdentifier);
            var isDeleted = await studentService.IsDeleted(userId);

            if(isDeleted)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary()
                {
                    { "Area", "Default"},
                    { "controller", "Home"},
                    { "action", "NotActivated"}
                });
            }
            else
            {
                await next();
            }

        }
    }
}
