using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BardievaGA.Sprint3.Task1.V6.Lib;
namespace Tyuiu.BardievaGA.Sprint3.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int value = 4;
            int startValue = 1, stopValue = 10;
            double res = dataService.GetSumSeries(value, startValue, stopValue), wait = -389_102.250;
            Assert.AreEqual(wait, res);
        }
    }
}
