using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class 형변환
    {
        static void Main(string[] args)
        {
            string s = "123";
            float f = 321;
            Console.WriteLine(Convert.ToInt32(s)+(int)f);
        }
    }
}
