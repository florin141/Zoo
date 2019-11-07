using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Zoo.Web.Controllers
{
    public class AuthorizationController : Controller
    {
        public async Task Logout()
        {
            // Clears the local cookie ("Cookies" must match the name for scheme)
            await HttpContext.SignOutAsync("Cookies");
            await HttpContext.SignOutAsync("oidc");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}