namespace AspMvcSampleApp.Controllers
{
    using Models;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {   
            return View(new CalculationModel());
        }

        [HttpPost]
        public ActionResult Index(CalculationModel model)
        {
            model.ResultValue = model.FirstValue + model.SecondValue;
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}