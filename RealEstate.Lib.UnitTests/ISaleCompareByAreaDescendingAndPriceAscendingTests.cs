using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace RealEstate.Lib.UnitTests
{
    [TestClass]
    public class ISaleCompareByAreaDescendingAndPriceAscendingTests
    {
        [TestMethod]
        public void Compare_CompareTwoISale_ReturnValuesByAreaDescendingAndPriceAscending()
        {
            //Arrange
            List<House> sales = new List<House>
            { 
               new House(new DateTime(2025, 10, 1), 1500, 25, 3000, "Beautiful House", true, HouseType.Detached),
               new House(new DateTime(2024, 10, 1), 1000, 20, 4000, "crazy House", true, HouseType.Row)
            };
            string expected = sales[1].GetInfo(false);
            //Act
            sales.Sort(new ISaleCompareByAreaDescendingAndPriceAscending());
            //Assert
            Assert.AreEqual(expected, sales[0].GetInfo(false));
        }
    }
}