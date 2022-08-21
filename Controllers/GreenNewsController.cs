using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _21487822_HW04.Controllers
{
    public class GreenNewsController : Controller
    {
        // GET: GreenNews
        //private readonly ILogger<HomeController> _logger;
        public ActionResult Index()
        {
            //List<Article> articles = RuntimeDataRepo.getArticles();
            return View(/*articles*/);
        }
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}