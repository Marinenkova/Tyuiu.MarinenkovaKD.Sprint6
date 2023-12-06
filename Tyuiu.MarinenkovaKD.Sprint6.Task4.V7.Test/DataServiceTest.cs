using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MarinenkovaKD.Sprint6.Task4.V7.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startStep = -5;
            int stopStep = 5;
            int len = Math.Abs(startStep) + Math.Abs(stopStep) + 1;
            double[] array = new double[len];
            array[0] = 15.19;
            array[1] = 11.67;
            array[2] = 9;
            array[3] = 0;
            array[4] = 4.08;
            array[5] = 1.5;
            array[6] = -2.28;
            array[7] = -6.52;
            array[8] = -10.19;
            array[9] = -12.76;
            array[10] = -14.68;
            double[] res = ds.GetMassFunction(startStep, stopStep);
            CollectionAssert.AreEqual(array, res);
        }
    }
}
