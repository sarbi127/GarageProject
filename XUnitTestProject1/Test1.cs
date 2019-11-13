using GarageProject;
using System;
using Xunit;


namespace XUnitTestProject1
{
    public class Test1
    {
        [Fact]
        public void AddTest()
        {
            // arrange
            var garage = new Garage<Vehicle>(10);

            // act
            var result = garage.Add(new Bicycle("Bicycle", "11", "red", 2, 1));

            // assert
            Assert.True(result);

        }

      
    }

    

 }
