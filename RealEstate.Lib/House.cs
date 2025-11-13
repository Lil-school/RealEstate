using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Lib
{
    internal class House : AbstractSale
    {
        bool _hasGarden;
        HouseType _houseType;
        public House(DateTime dateTime, int buyingPrice, int fee, int livingArea, string description, bool hasGarden, HouseType houseType): base(dateTime, buyingPrice, fee, livingArea, description)
        {
            _hasGarden = hasGarden;
            _houseType = houseType;
        }
        public House(int buyingPrice, int livingArea):base(DateTime.Now, buyingPrice, 0, livingArea, "")
        { }
        public override string GetInfo(bool detailed)
        {
            if (detailed)
            {
                return $"Available from: {AvailDate.ToShortDateString()}, Living Area: {LivingArea} sqm, Price: {Price} USD, Description: {_descpription}";
            }
                
            return $"Available from: {AvailDate.ToShortDateString()}, Living Area: {LivingArea} sqm, Price: {Price} USD";
        }
    }
}
