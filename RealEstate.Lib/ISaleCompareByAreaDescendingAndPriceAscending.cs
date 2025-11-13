using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Lib
{
    internal class ISaleCompareByAreaDescendingAndPriceAscending : IComparer<ISale>
    {
        public int Compare(ISale firstSale, ISale secondSale)
        {
            int result = firstSale.LivingArea.CompareTo(secondSale.LivingArea);
            if (result == 0) 
            {
                return firstSale.Price.CompareTo(secondSale.LivingArea);
            }
            return result;
        }
    }
}
