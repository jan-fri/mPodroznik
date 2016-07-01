using System.Linq;
using System.Web.Mvc;
using mPodroznik.Domain.Entities;
using mPodroznik.HelperClass.ViewModel;
using System;
using System.Reflection;
using mPodroznik.ViewModel;

namespace mPodroznik.Controllers
{
    public class HomeController : Controller
    {
        ViewModelRepozytory repo = new ViewModelRepozytory();

        [HttpGet]
        public ActionResult Index()
        {
            var busList = repo.GetBusesFromDB();
            return View(busList);
        }

        [HttpPost]
        [MultiButton(MatchFormKey = "action", MatchFormValue = "Szczegoly")]
        public ActionResult ShowRouteTable(BusViewModel busNum)
        {
            return RedirectToAction("ShowRouteTable", "BusRoute", busNum);
        }

        [HttpPost]
        [MultiButton(MatchFormKey = "action", MatchFormValue = "Pokaż trasę")]
        public ActionResult ShowRouteMap(BusViewModel busNum)
        {
            return RedirectToAction("ShowRouteMap", "BusRoute", busNum);
        }

        [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
        public class MultiButtonAttribute : ActionNameSelectorAttribute
        {
            public string MatchFormKey { get; set; }
            public string MatchFormValue { get; set; }

            public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
            {
                return controllerContext.HttpContext.Request[MatchFormKey] != null &&
                    controllerContext.HttpContext.Request[MatchFormKey] == MatchFormValue;
            }
        }
    }
}