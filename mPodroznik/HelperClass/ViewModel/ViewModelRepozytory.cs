using AutoMapper;
using mPodroznik.Domain.Entities;
using mPodroznik.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace mPodroznik.HelperClass.ViewModel
{
    public class ViewModelRepozytory
    {
       // private static Bus _bus;
        //private static BusStop _busStop;
        //private static BusViewModel _busVM;
        //private static BusStopViewModel _busStopVM;
        private static List<BusViewModel> _busListVM;
        //private static List<BusStopViewModel> _busStopListVM;

        public List<BusViewModel> GetBusesFromDB()
        {
            using (var context = new BusContex())
            {
                var buses = context.Buses.ToList();

                MappBusListToViewModel(buses);
                return GetBusListViewModel();               
            }
        }

        public void MappBusListToViewModel(List<Bus> buses)
        {
            _busListVM = Mapper.Map<List<Bus>, List<BusViewModel>>(buses);
        }
        public List<BusViewModel> GetBusListViewModel()
        {
            return _busListVM;
        }

        //public void MappBusToViewModel(Bus bus)
        //{
        //    _busVM = Mapper.Map<Bus, BusViewModel>(bus);
        //}
        //public void MappBusVMtoBus(BusViewModel bus)
        //{
        //    _bus = Mapper.Map<BusViewModel, Bus>(bus);
        //}

        //public void MappBusStopToViewModel(BusStop busStop)
        //{
        //    _busStopVM = Mapper.Map<BusStop, BusStopViewModel>(busStop);
        //}
        //public void MappBusStopVMtoBusStop(BusStopViewModel bus)
        //{
        //    _busStop = Mapper.Map<BusStopViewModel, BusStop>(bus);
        //}


        //public void MappBusStopListToViewModel(List<BusStop> busStops)
        //{
        //    _busStopListVM = Mapper.Map<List<BusStop>, List<BusStopViewModel>>(busStops);
        //}


        //public Bus GetBus()
        //{
        //    return _bus;
        //}
        //public BusStop GetBusStop()
        //{
        //    return _busStop;
        //}
        //public BusViewModel GetBusViewModel()
        //{
        //    return _busVM;
        //}
        //public BusStopViewModel GetBusStopViewModel()
        //{
        //    return _busStopVM;
        //}

        //public List<BusStopViewModel> GetBusStopListViewModel()
        //{
        //    return _busStopListVM;
        //}
    }
}