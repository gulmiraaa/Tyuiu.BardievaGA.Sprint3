using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BardievaGA.Sprint3.Task3.V28.Lib;
namespace Tyuiu.BardievaGA.Sprint3.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string str = "f35hyt t4j 3gkg45";
            char chr = 'r';
            string res = dataService.ReplaceNumOnChar(str, chr), wait = "frrhyt trj rgkgrr";
            Assert.AreEqual(res, wait);
        }
    }
}
