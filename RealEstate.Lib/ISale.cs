using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Lib
{
    public interface ISale
    {
        DateTime AvailDate { get; }
        int LivingArea { get; }
        int Price { get; }
        string GetInfo(bool detailed);
        bool IsAvailable();
        bool IsAvailable(DateTime date);

    }
}
