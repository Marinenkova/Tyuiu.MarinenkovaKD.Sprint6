using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MarinenkovaKD.Sprint6.Task1.V24.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -0.62;
            valueWaitArray[1] = -16.79;
            valueWaitArray[2] = -17.77;
            valueWaitArray[3] = -6.30;
            valueWaitArray[4] = -5.04;
            valueWaitArray[5] = -6.00;
            valueWaitArray[6] = -7.85;
            valueWaitArray[7] = -2.43;
            valueWaitArray[8] = 5.91;
            valueWaitArray[9] = 4.33;
            valueWaitArray[10] = -11.82;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
