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
        public int Compare(ISale firstSale, ISale secondSale)   // -1= secondSale ist kleiner 1= SecondSale ist bigger CompareTo immer descending sortiert
        {
            int result = secondSale.LivingArea.CompareTo(firstSale.LivingArea);     // descending
            if (result == 0) 
            {
                return firstSale.Price.CompareTo(secondSale.Price);            // ascending
            }
            return result;
        }
    }
}
