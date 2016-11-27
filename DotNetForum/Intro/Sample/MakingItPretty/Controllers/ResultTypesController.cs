using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Script.Serialization;

namespace MakingItPretty.Controllers
{
    public class ResultTypesController : Controller
    {
        // GET: ResultTypes
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult ViewResult()
        {
            return View();
        }

        public PartialViewResult PartialViewResult()
        {
            return PartialView();
        }

        public RedirectResult RedirectResult()
        {
            var url = "http://www.google.co.za";
            return Redirect(url);
        }

        public RedirectToRouteResult RedirectToRouteResult()
        {
            return RedirectToAction("Index");
            //return RedirectToActionPermanent("Index");

            //var routeValues = new RouteValueDictionary();
            //routeValues.Add("Action", "Index");
            //routeValues.Add("Controller", "Candidate");

            //return RedirectToRoute(routeValues);
            //return RedirectToRoutePermanent(routeValues);
        }

        public ContentResult ContentResult()
        {
            return Content("SomeText", "text/plain");
        }

        public JsonResult JsonResult()
        {
            var model = new {Name = "John", Surname = "Wick"};
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public JavaScriptResult JavaScriptResult()
        {
            // antipattern 
            // use seldomly or NEVER

            return JavaScript("alert('from controller')");
        }

        public FileResult FileResult()
        {
            return File("file.txt", "text/plain");
        }

        public EmptyResult EmptyResultAction()
        {
            return new EmptyResult();
        }


    }
}