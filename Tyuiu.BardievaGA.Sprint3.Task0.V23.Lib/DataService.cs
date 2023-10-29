using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BardievaGA.Sprint3.Task0.V23.Lib
{
    public class DataService : ISprint3Task0V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                sumSeries += Math.Pow((1 / (Math.Sin(i) + 2 * Math.Pow(value, i))), i);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
