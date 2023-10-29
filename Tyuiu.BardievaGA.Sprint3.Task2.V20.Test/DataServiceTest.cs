using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BardievaGA.Sprint3.Task2.V20.Lib;

namespace Tyuiu.BardievaGA.Sprint3.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int value = 1;
            int startValue = 1, stopValue = 6;
            double res = dataService.GetMultiplySeries(value, startValue, stopValue), wait = 914700.940;
            Assert.AreEqual(wait, res);
        }
    }
}
