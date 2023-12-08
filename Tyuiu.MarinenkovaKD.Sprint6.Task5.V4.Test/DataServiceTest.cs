﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MarinenkovaKD.Sprint6.Task5.V4.Lib;
using System.IO;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Я твой-ты моя\source\repos\Tyuiu.MarinenkovaKD.Sprint6\Tyuiu.MarinenkovaKD.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
