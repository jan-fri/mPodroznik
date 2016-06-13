using System.Web.Mvc;
using System.Web.Routing;

using AutoMapper;
using mPodroznik.ViewModel;
using mPodroznik.Domain.Entities;

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
