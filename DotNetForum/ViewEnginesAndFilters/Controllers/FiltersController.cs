using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using Microsoft.Ajax.Utilities;

namespace ViewEngines.Controllers
{
    //[MyResultFilter("local", "bread")]
    //[RemoveXHeader()]
    public class FiltersController : Controller
    {
        // GET: Filters
        [AddMyCustomBakeryHeader("local", "bread")]
        [RemoveXHeader()]
        public ActionResult Index()
        {
            return View();
        }

        #region Filters
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

        protected override void OnAuthentication(AuthenticationContext filterContext)
        {
            base.OnAuthentication(filterContext);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);

        }

        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }

        protected override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

        protected override void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            base.OnAuthenticationChallenge(filterContext);
        }

        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }

        #endregion

    }

    public class MyActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }
    }

    public class MyAuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            throw new NotImplementedException();
        }
    }

    public class MyAuthenticationFilter : IAuthenticationFilter
    {
     
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            throw new NotImplementedException();
        }
    }

    public class MyErrorFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            throw new NotImplementedException();
        }
    }

    public class AddMyCustomBakeryHeader : ActionFilterAttribute
    {

        public AddMyCustomBakeryHeader()
        {
            
        }
        public AddMyCustomBakeryHeader(string bakery,  string item )
        {
     
            this.Bakery = bakery;
            this.Item = item;
        }

        public string Item { get; set; }
        public string Bakery { get; set; }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (Bakery.IsNullOrWhiteSpace())
            {
                Bakery = "Default";
            }
            if (Item.IsNullOrWhiteSpace())
            {
                Item = "Default";
            }

            filterContext.HttpContext.Response.Headers.Add(Bakery , Item);

            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
    }

    public class RemoveXHeader : ActionFilterAttribute
    {


        public RemoveXHeader()
        {

        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var headersToRemove = filterContext.HttpContext.Response.Headers.AllKeys.Where(r => r.StartsWith("X-"));

            foreach (var header in headersToRemove)
            {
              //  filterContext.HttpContext.Response.Headers.Remove(header);

            }
            

            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
    }
}