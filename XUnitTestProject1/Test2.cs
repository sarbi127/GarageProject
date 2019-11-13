using System;
using System.Collections.Generic;
using System.Text;
using GarageProject;
using Xunit;

namespace XUnitTestProject1
{
    class Test2
    {
        public void RemoveTest()
        {
            // arrange
            var garage = new Garage<Vehicle>(10);

            // act
            var result = garage.Remove(new Bicycle("Bicycle", "11", "red", 2, 1));

            // assert
            Assert.True(result);

        }
    }
}
