using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.NazarenkoVV.Sprint5.Task0.V25.Lib
{
    public class DataService : ISprint5Task0V25
    {
        public string SaveToFileTextData(int x)
        {
            string Path = $@"{Directory.GetCurrentDirectory()}/OutPutFileTask0.txt";
            double y = Math.Round((3 * Math.Pow(x, 4) + 1) / Math.Pow(x, 3), 3);
            File.WriteAllText(Path, Convert.ToString(y));
            return Path;
        }
    }
}
        
        