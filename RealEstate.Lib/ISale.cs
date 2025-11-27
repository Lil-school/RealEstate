using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Lib
{
    public interface ISale : IComparable<ISale>
    {
        DateTime AvailDate { get; }
        int Price { get; }
        int LivingArea { get; }
        bool IsAvailable();
        bool IsAvailable(DateTime date);
        string GetInfo(bool detailed);
        // Explicitly declare to make contract clear (optional because of IComparable<ISale>)
        new int CompareTo(ISale other);
    }
}
