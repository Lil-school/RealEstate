using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Lib
{
    internal class ISaleCompareByAvailDateAscending : IComparer<ISale>
    {
        public int Compare(ISale firstSale, ISale secondSale)
        {
            int result = firstSale.AvailDate.CompareTo(secondSale.AvailDate); //ascending
            return result;
        }
    }
}
