using AutoMapper;
using mPodroznik.Domain.Entities;
using mPodroznik.HelperClass.ViewModel;
using mPodroznik.ViewModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace mPodroznik.Controllers.BusController
{
    public class BusRouteController : Controller
    {
        ViewModelRepozytory repo = new ViewModelRepozytory();
        private static List<BusStopViewModel> _busStopsVM;
 
        private BusContex db = new BusContex();

        public ActionResult ShowRouteTable(BusViewModel busNum)
        {
            var busList = repo.GetBusListViewModel();
            var buses = busList.Where(b => b.BusNumber == busNum.BusNumber).FirstOrDefault();
            _busStopsVM = buses.BusStops;
            return View(_busStopsVM);
        }
        public ActionResult ShowRouteMap(BusViewModel busNum)
        {
            var busList = repo.GetBusListViewModel();
            var buses = busList.Where(b => b.BusNumber == busNum.BusNumber).FirstOrDefault();
            _busStopsVM = buses.BusStops;
            return View(_busStopsVM);

        }

        // GET: Authors/Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            id--;
            int countBusStops = _busStopsVM.Count;
            if (id > countBusStops)
            {
                var minId = _busStopsVM.ElementAt(0);
                id = id - (minId.ID - 1);
            }
            var busStopVM = _busStopsVM.ElementAt((int)id);
            if (busStopVM == null)
            {
                return HttpNotFound();
            }

            return View("Edit", busStopVM);
        }
        // POST: Authors/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BusStopViewModel busStopVM)
        {
            if (ModelState.IsValid)
            {
                var bus = db.Buses.FirstOrDefault(x => x.ID == busStopVM.BusID);                
                var busStop = bus.BusStops.FirstOrDefault(x => x.ID == busStopVM.ID);
                Mapper.Map(busStopVM, busStop);
                db.SaveChanges();
                var newBusList = repo.GetBusesFromDB();
                var newBus = newBusList.Where(x => x.BusNumber == busStopVM.BusID.ToString()).FirstOrDefault();


                return RedirectToAction("ShowRouteTable", newBus);
            }
            return View(busStopVM);
        }

        // GET: Authors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var busStop = _busStopsVM.ElementAt((int)id);
            if (busStop == null)
            {
                return HttpNotFound();
            }
            return View(busStop);
        }
    }
}