using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NazarenkoVV.Sprint5.Task2.V30.Lib;
using System.IO;

namespace Tyuiu.NazarenkoVV.Sprint5.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Vivobook\source\repos\Tyuiu.NazarenkoVV.Sprint5\Tyuiu.NazarenkoVV.Sprint5.Task2.V30\bin\Debug\OutFileTestTask2.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExists);
        }
    }
}