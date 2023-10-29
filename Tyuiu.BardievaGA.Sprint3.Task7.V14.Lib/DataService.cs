using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BardievaGA.Sprint3.Task7.V14.Lib
{
    public class DataService : ISprint3Task7V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            for (int x = startValue, count = 0; x <= stopValue; x++, count++) res[count] = Math.Round(2 * x - 4 + (2 * x - 1) / (Math.Sin(x) + 1), 2);
            return res;
        }
    }
}
