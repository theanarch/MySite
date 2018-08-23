using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace MyCV.Controllers
{
    public class ServicesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}