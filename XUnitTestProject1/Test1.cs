using GarageProject;
using System.Collections.Generic;
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

        [Fact]
        public void RemoveTest()
        {
            // arrange
            var garage = new Garage<Vehicle>(10);
            garage.Add(new Bicycle("Bicycle", "11", "red", 2, 1));

            // act
            var result = garage.Remove(new Bicycle("Bicycle", "11", "red", 2, 1));

            // assert
            Assert.True(result);

        }

        [Fact]
        public void CapacityTest()
        {
            // arrange
            int expect = 10;
            var garage = new Garage<Vehicle>(10);

            // act
            var result = garage.capacity;

            // assert
            Assert.Equal(expect,result);

        }

        [Fact]
        public void CountTest()
        {
            // arrange
            var expect = 1;
            var garage= new Garage<Vehicle>(10);
            garage.Add(new Cars("Car", "112AB", "red", 4, 12));
            
            // act
            var result = garage.Count;

            // assert
            Assert.Equal(expect, result);

        }

    }
  
 }
