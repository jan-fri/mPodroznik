using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mPodroznik.Models;
using mPodroznik.ViewModel;
using AutoMapper;
using mPodroznik.HelperClass;

namespace mPodroznik.Controllers
{
    public class HomeController : Controller
    {
        ViewModelRepozytory repo = new ViewModelRepozytory();
        public ActionResult Index()
        {
            using (var context = new BusContex())
            {
                var buses = context.Buses.ToList();

                repo.MappBusList(buses);
                var busList = repo.GetBusList();
                return View(busList);
            }       
        }

        [HttpPost]
        public ActionResult Index(string id)
        {
            return View();
        }
    }
}