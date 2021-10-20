using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumin_DLL
{
    public class Calculator
    {
        public static int NAI(string a)
        {
            int year = Convert.ToInt32(a.Substring(0, 2));
            int nai = 0;
            if (year >= 22)
                nai = 122 - year;
            else
                nai = 22 - year;
            return nai;
        }
        public static string TYPE(string a)
        {
            int type = Convert.ToInt32(a.Substring(6, 1));
            if ((type == 1) || (type == 3))
                return "남자";
            else
                return "여자";
        }
        public static int YEAR(string a)
        {
            int year = Convert.ToInt32(a.Substring(0, 2));
            return year;
        }
        public static int MONTH(string a)
        {
            int month = Convert.ToInt32(a.Substring(2, 2));
            return month;
        }
        public static int DAY(string a)
        {
            int day = Convert.ToInt32(a.Substring(4, 2));
            return day;
        }
       
    }
}
