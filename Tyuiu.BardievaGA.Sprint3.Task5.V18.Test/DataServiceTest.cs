using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BardievaGA.Sprint3.Task5.V18.Lib;

namespace Tyuiu.BardievaGA.Sprint3.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int x = 5, startValue1 = 1, startValue2 = 1, stopValue1 = 3, stopValue2 = 11;
            double res = dataService.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2), wait = 768.361;
            Assert.AreEqual(wait, res);

        }
    }
}
