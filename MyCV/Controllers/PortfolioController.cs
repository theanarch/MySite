using System.Web.Mvc;


namespace MyCV.Controllers
{
    
    
    public class PortfolioController : Controller
    {
        [HttpGet]
        public ActionResult RaspberryPiGeneral()
        {
            return View();
        }

        [HttpGet]
        public ActionResult IOSGeneral()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TodoListiOS()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ArduinoGeneral()
        {
            return View();
        }

        [HttpGet]
        public ActionResult WebDevGeneral()
        {
            return View();
        }
    }
}
