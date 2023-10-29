using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BardievaGA.Sprint3.Task4.V10.Lib;
namespace Tyuiu.BardievaGA.Sprint3.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int startValue = -5, stopValue = 5;
            double res = dataService.Calculate(startValue, stopValue), wait = 0.014;
            Assert.AreEqual(wait, res);
        }
    }
}
