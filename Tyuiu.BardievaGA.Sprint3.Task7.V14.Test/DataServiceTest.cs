using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BardievaGA.Sprint3.Task7.V14.Lib;
namespace Tyuiu.BardievaGA.Sprint3.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int startValue = -5, stopValue = 5;
            double[] WaitRes = new double[stopValue - startValue + 1];
            WaitRes[0] = -19.62;
            WaitRes[1] = -17.12;
            WaitRes[2] = -18.15;
            WaitRes[3] = -63.13;
            WaitRes[4] = -24.92;
            WaitRes[5] = -5.0;
            WaitRes[6] = -1.46;
            WaitRes[7] = 1.57;
            WaitRes[8] = 6.38;
            WaitRes[9] = 32.78;
            WaitRes[10] = 225.11;
            double[] res = new double[stopValue - startValue + 1];
            res = dataService.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, WaitRes);
        }
    }
}
