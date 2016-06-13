using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using mPodroznik.Models;
using AutoMapper;
using mPodroznik.ViewModel;

namespace mPodroznik
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            Mapper.CreateMap<Bus, BusViewModel>();
            Mapper.CreateMap<BusViewModel, Bus>();
            Mapper.CreateMap<BusStop, BusStopViewModel>();
            Mapper.CreateMap<BusStopViewModel, BusStop>();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
