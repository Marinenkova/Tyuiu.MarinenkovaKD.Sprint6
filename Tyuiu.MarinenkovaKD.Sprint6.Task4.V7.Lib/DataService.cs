using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task4.V7.Lib
{
    public class DataService : ISprint6Task4V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            int len = Math.Abs(startValue) + Math.Abs(stopValue) + 1;
            double[] array = new double[len];
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2 != 0)
                {
                    double y = Math.Cos(x) + (Math.Cos(x) / (x + 2)) - 3 * x;
                    y = Math.Round(y, 2);
                    array[count] = y;
                    count++;
                }
                else
                {
                    double y = 0;
                    array[count] = y;
                    count++;
                }

            }
            return array;
        }
    }
}
