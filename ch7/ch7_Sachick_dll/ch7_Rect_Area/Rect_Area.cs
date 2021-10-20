using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area_OP;

namespace ch7_Rect_Area
{
    class Rect_Area
    {
        static void Main(string[] args)
        {
            Console.Write("사각형 가로 입력 : ");
            int width = Convert.ToInt16(Console.ReadLine());
            Console.Write("사각형 세로 입력 : ");
            int height = Convert.ToInt16(Console.ReadLine());
            Area_Calc s = new Area_Calc(width, height);
            Print_out(s.Width, s.Height, s.Area, s.Length);
        }
        private static void Print_out(int w, int h, int sum, int len)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("가로\t세로\t면적\t둘레");
            Console.WriteLine(w + "\t" + h + "\t" + sum + "\t" + len);
            Console.WriteLine();
        }

    }
}
