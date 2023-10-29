using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BardievaGA.Sprint3.Task0.V23.Lib;
namespace Tyuiu.BardievaGA.Sprint3.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            double value = 1.5;
            int startValue = 1, stopValue = 10;
            double res = dataService.GetSumSeries(value, startValue, stopValue), wait = 0.298;
            Assert.AreEqual(wait, res);
        }
    }
}
