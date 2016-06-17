using AutoMapper;
using mPodroznik.Domain.Entities;
using mPodroznik.ViewModel;
using System.Collections.Generic;

namespace mPodroznik.HelperClass.ViewModel
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