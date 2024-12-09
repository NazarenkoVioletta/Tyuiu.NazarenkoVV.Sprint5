using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NazarenkoVV.Sprint5.Task4.V1.Lib;
using System.IO;

namespace Tyuiu.NazarenkoVV.Sprint5.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V1.txt");
            FileInfo fileInfo = new FileInfo(path);
            double wait = -3.680;
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}