using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MarinenkovaKD.Sprint6.Task7.V15.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void File()
        {
            string openedFile = @"C:\Users\Я твой-ты моя\Desktop\InPutFileTask7V15.csv";
            FileInfo file = new FileInfo(openedFile);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}
