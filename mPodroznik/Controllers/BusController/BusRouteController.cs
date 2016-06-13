using mPodroznik.HelperClass.ViewModel;
using mPodroznik.ViewModel;
using System.Linq;
using System.Web.Mvc;

namespace mPodroznik.Controllers.BusController
{
    public class BusRouteController : Controller
    {
        ViewModelRepozytory repo = new ViewModelRepozytory();

        [HttpPost]
        public ActionResult ShowRoute(BusViewModel busNum)
        {
            var busList = repo.GetBusList();
            var buses = busList.Where(b => b.BusNumber == busNum.BusNumber).FirstOrDefault();

            return View(buses.BusStops);
        }

        //[HttpGet]
        //public ActionResult AddStop()
        //{

        //}
    }
}