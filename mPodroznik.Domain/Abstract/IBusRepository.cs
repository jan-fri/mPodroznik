using mPodroznik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPodroznik.Domain.Abstract
{
    public interface IBusRepository
    {
        IEnumerable<BusStop> BusStops { get; set; }
    }
}
