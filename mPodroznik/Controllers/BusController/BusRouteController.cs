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
        private static List<BusStopViewModel> _busStopsVMList;
        private static int _busStopID;
        private static BusStopViewModel _busStopVM;
        private BusContex db = new BusContex();


        public ActionResult ShowRouteTable(BusViewModel busNum)
        {
            if (busNum.BusNumber != null)
            {
                var busList = repo.GetBusListViewModel();
                var buses = busList.Where(b => b.BusNumber == busNum.BusNumber).FirstOrDefault();
                _busStopsVMList = buses.BusStops;
            }
            var orderedBusStops = _busStopsVMList.OrderBy(x => x.BusStopOrder).ToArray();
            return View(orderedBusStops);
        }
        public ActionResult ShowRouteMap(BusViewModel busNum)
        {
            var busList = repo.GetBusListViewModel();
            var buses = busList.Where(b => b.BusNumber == busNum.BusNumber).FirstOrDefault();
            _busStopsVMList = buses.BusStops;
            var orderedBusStops = _busStopsVMList.OrderBy(x => x.BusStopOrder).ToArray();
            return View(orderedBusStops);

        }

        // GET: Authors/Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _busStopID = (int)id;
            id--;

            int countBusStops = _busStopsVMList.Count;
            if (id > countBusStops)
            {
                var minId = _busStopsVMList.ElementAt(0);
                id = id - (minId.ID - 1);
            }
            var busStopVM = _busStopsVMList.ElementAt((int)id);
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

                //in case there was a change in the busStopOrder                
                var busStopID = _busStopsVMList.FirstOrDefault(x => x.ID == _busStopID);
                if (busStopID.BusStopOrder != busStopVM.BusStopOrder)
                {
                    var busStopsToChange = bus.BusStops.Where(x => x.BusStopOrder >= busStopVM.BusStopOrder).ToList();
                    foreach (var stop in busStopsToChange)
                    {
                        if (stop.BusStopName == busStopVM.BusStopName)
                        {
                            continue;
                        }
                        ++stop.BusStopOrder;
                    }
                }

                //add in case busId changes//

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
            _busStopID = (int)id;
            id--;

            int countBusStops = _busStopsVMList.Count;
            if (id > countBusStops)
            {
                var minId = _busStopsVMList.ElementAt(0);
                id = id - (minId.ID - 1);
            }
            _busStopVM = _busStopsVMList.ElementAt((int)id);
            if (_busStopVM == null)
            {
                return HttpNotFound();
            }

            return View("Delete", _busStopVM);
        }

        // POST: Authors/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete()
        {
            var bus = db.Buses.FirstOrDefault(x => x.ID == _busStopVM.BusID);
            var busStop = bus.BusStops.FirstOrDefault(x => x.ID == _busStopVM.ID);
            bus.BusStops.Remove(busStop);

            var busStopsToChange = bus.BusStops.Where(x => x.BusStopOrder >= _busStopVM.BusStopOrder).ToList();
            foreach (var stop in busStopsToChange)
            {
                if (stop.BusStopName == _busStopVM.BusStopName)
                {
                    continue;
                }
                --stop.BusStopOrder;
            }

            db.SaveChanges();
            var newBusList = repo.GetBusesFromDB();
            var newBus = newBusList.Where(x => x.BusNumber == _busStopVM.BusID.ToString()).FirstOrDefault();

            return RedirectToAction("ShowRouteTable", newBus);
        }
    }
}