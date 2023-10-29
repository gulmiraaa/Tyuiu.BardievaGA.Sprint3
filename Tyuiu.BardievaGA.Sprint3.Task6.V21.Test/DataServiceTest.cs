using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BardievaGA.Sprint3.Task6.V21.Lib;
namespace Tyuiu.BardievaGA.Sprint3.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int startValue = 19, stopValue = 30, res = dataService.GetSumTheDivisors(startValue, stopValue), wait = 485;
            Assert.AreEqual(wait, res);
        }
    }
}
