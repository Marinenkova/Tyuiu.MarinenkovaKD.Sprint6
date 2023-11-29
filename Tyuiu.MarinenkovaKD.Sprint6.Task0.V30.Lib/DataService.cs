using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task0.V30.Lib
{
    public class DataService : ISprint6Task0V30
    {
        public double Calculate(int x)
        {
            double res = ((double)x * Math.Sqrt((double)x + 3));
            return Math.Round(res, 3);
        }
    }
}
