using AutoMapper;
using mPodroznik.Models;
using mPodroznik.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mPodroznik.HelperClass
{
    public class ViewModelRepozytory
    {
        private static List<BusViewModel> _busList;
        public void MappBusList(List<Bus> buses)
        {
            _busList = Mapper.Map<List<Bus>, List<BusViewModel>>(buses);
        }
        
        public List<BusViewModel> GetBusList()
        {
            return _busList;
        }
    }
}