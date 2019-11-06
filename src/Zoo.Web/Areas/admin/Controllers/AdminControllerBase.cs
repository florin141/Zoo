using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Zoo.Web.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class AdminControllerBase : Controller
    {
    }
}
