using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NazarenkoVV.Sprint5.Task1.V6.Lib;
using System.IO;

namespace Tyuiu.NazarenkoVV.Sprint5.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Vivobook\source\repos\Tyuiu.NazarenkoVV.Sprint5\Tyuiu.NazarenkoVV.Sprint5.Task1.V6\Tyuiu.NazarenkoVV.Sprint5.Task1.V6\bin\Debug\OutFileTestTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}