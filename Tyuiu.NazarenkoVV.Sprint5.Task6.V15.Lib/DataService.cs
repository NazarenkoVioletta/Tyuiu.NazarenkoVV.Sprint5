using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.NazarenkoVV.Sprint5.Task6.V15.Lib
{
    public class DataService : ISprint5Task6V15
    {
        public int LoadFromDataFile(string path)
        {
            int cnt = 0;
            string str = File.ReadAllText(path);
            str = str.ToUpper().Replace("СС", "*");
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '*')
                {
                    cnt = 5;
                }
            }
            return cnt;
        }
    }
}
