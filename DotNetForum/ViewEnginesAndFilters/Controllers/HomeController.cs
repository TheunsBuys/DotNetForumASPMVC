using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Templates()
        {

            var model = new BooleanViewModel()
                        {
                            ModelWithoutValue = null,
                            ModelWithValue = true,
                        };
            return View(model);
        }

      

    }

    public class BooleanViewModel
    {
        [Display(Name="Model Without Value")]
        public bool? ModelWithoutValue { get; set; }
        [Display(Name = "Model With Value")]
        public bool? ModelWithValue { get; set; }

        [Display(Name = "Default Model With Value")]
        public bool DefaultModelWithValue { get; set; }
    }
}