using Microsoft.AspNetCore.Mvc;

namespace Log_09_Account.Areas.Account.Controllers
{
    public class AccountDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
