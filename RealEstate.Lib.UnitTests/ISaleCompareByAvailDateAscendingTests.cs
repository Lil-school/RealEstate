using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace RealEstate.Lib.UnitTests
{
    [TestClass]
    public class ISaleCompareByAvailDateAscendingTests
    {
        [TestMethod]
        public void ISaleCompareByAvailDateAscending_ListSortedByAvailDate_ASortedList()
        {
            //Arrange
            List<House> sales = new List<House>
            {
                new House(new DateTime(2026,4,1), 4000, 200, 300,"Address 1",false,HouseType.Detached),
                new House(new DateTime(2024,6,15), 3500, 300, 150,"Address 2",true,HouseType.SemiDetached),
                new House(new DateTime(2023,1,10), 4500, 250, 200,"Address 3",false,HouseType.Row)
            };
            //Act
            var expected = sales[2].AvailDate;
            sales.Sort(new ISaleCompareByAvailDateAscending());
            //Assert
            Assert.AreEqual(expected, sales[0].AvailDate);
        }
    }
}
