using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.NazarenkoVV.Sprint5.Task4.V1.Lib
{
    public class DataService : ISprint5Task4V1
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace(".", ",");
            double x = Convert.ToDouble(strX);
            double res = Math.Round(((1 / (Math.Cos(x) + x) - 4.12 * x)), 3);
            return res;
        }
    }
}
