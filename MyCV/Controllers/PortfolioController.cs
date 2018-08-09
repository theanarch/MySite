using System.Web.Mvc;


namespace MyCV.Controllers
{
    
    
    public class PortfolioController : Controller
    {
        [HttpGet]
        public ActionResult OneColumn()
        {
            return View();
        }
        
    }
}
