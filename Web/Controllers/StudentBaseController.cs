using Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;
using Web.Filters;

namespace Web.Controllers
{
    [Authorize]
    [IsDeleted]
    public class StudentBaseController : Controller
    {
    }
}
