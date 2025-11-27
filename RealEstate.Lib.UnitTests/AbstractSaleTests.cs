using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace RealEstate.Lib.UnitTests
{
    [TestClass]
    public class AbstractSaleTests
    {
        [TestMethod]
        public void CompareTo_CoparesTwoHousesAndGetsThemSortedByEarliestDateAndHighestPrice_ACorrectlzSortedList()
        {
            //Arrange
            List<ISale> _sales = new List<ISale>
            {
                new House(new DateTime(2025,12,1),30000,20,300,"nice House",true,HouseType.SemiDetached),
                new House(new DateTime(2025,1,10),20000,10,400,"beatiful House",false,HouseType.Row)
            };
            var expected = _sales[1].GetInfo(true);
            //Act
            _sales.Sort();
            //Assert
            Assert.AreEqual(expected, _sales[0].GetInfo(true));
        }
    }
}
