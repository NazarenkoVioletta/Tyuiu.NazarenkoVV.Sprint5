using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NazarenkoVV.Sprint5.Task0.V25.Lib;
using System.IO;

namespace Tyuiu.NazarenkoVV.Sprint5.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData(int x)
        {
            string path = @"C:\Users\Vivobook\source\repos\Tyuiu.NazarenkoVV\Tyuiu.NazarenkoVV.Sprint5.Task0.V25\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.IsTrue(fileExist);
        }
    }
}