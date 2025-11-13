    using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RealEstate.Lib
{
    internal abstract class AbstractSale : ISale
    {
        int _buyingPrice;
        int _fee;
        protected bool _isSold;
        protected string _descpription;

        public AbstractSale(DateTime dateTime, int buyingPrice, int fee, int livingArea, string description)
        {
            AvailDate = dateTime;
            _buyingPrice = buyingPrice;
            _fee = fee;
            LivingArea = livingArea;
            _descpription = description;
        }

        public DateTime AvailDate { get; }

        public int LivingArea { get; }

        public virtual int Price { get { return _buyingPrice + _fee; } }
        abstract public string GetInfo(bool detailed);
        public int CompareTo(ISale sale)    
        {
            int result = this.AvailDate.CompareTo(sale.AvailDate);
            if(result == 0) { result=this.Price.CompareTo(sale.Price); }
            return result;
        }
        public bool IsAvailable()
        {
            if (!_isSold && DateTime.Now >= AvailDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAvailable(DateTime date)
        {
            if (AvailDate <= date && !_isSold)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
