using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Lib
{
    public class RealEstateCatalogue
    {
        string _city;
        int[] _zipCode;
        List<ISale> _sales;
        public IComparer<ISale> Comparer
        {
            private get;
            set;
        }
        RealEstateCatalogue(string city, string zipCode)
        {
            _city = city;
            for(int i = 0; i < zipCode.Length-1;i++)
            {
                _zipCode[i] = int.Parse(zipCode.Substring(i, 1));
            }
        }
        RealEstateCatalogue(string city, int zipCode):this(city, zipCode.ToString())
        {
        }
        public void AddSale(ISale sale)
        {
            _sales.Add(sale);
        }
        public IList<ISale> GetAvailableSales()
        {
            IList<ISale> availableSales = new List<ISale>();
            foreach (var sale in _sales)
            {
                if(sale.IsAvailable())
                {
                    availableSales.Add(sale);
                }
            }
            return availableSales;
        }
        public IList<ISale> GetAvailableSales(DateTime dateTime)
        {
            IList<ISale> availableSales = new List<ISale>();
            foreach (var sale in _sales)
            {
                if (sale.IsAvailable(dateTime))
                {
                    availableSales.Add(sale);
                }
            }
            return availableSales;
        }

    }
}
