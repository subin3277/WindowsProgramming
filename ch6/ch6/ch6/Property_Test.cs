using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6
{
    //class Triangle_1
    //{
    //    private int _Width;
    //    private int _Height;
    //    private int _Area;

    //    public int Width
    //    {
    //        get { return _Width; }
    //        set { _Width = value; }
    //    }
    //    public int Height
    //    {
    //        get { return _Height; }
    //        set { _Height = value; }
    //    }
    //    public int Area
    //    {
    //        get { return (Width * Height) / 2; }
    //    }
    //}
    //class Property_Test
    //{
    //    static void Main(string[] args)
    //    {
    //        Triangle_1 t1 = new Triangle_1();
    //        t1.Width = 10;
    //        t1.Height = 20;
    //        Console.WriteLine("삼각형 1의 밑변{0}과 높이{1} 면적은{2}",t1.Width,t1.Height,t1.Area);
    //    }
    //}
    
    
    // 8단계 자동속성 구현
    class Triangle_2
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area
        {
            get { return(Width * Height) / 2; }
        }
    }
    class Property_Test
    {
        static void Main(string[] args)
        {
            Console.Write("삼각형의 밑변의 길이를 입력하시오. : ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("삼각형의 높이를 입력하시오. : ");
            int b = Convert.ToInt16(Console.ReadLine());
            Triangle_2 t2 = new Triangle_2();
            t2.Width = a; t2.Height = b;
            Console.WriteLine();
            Console.WriteLine("삼각형의 밑변{0}과 높이{1}의 면적은 : {2} 이다  ",
            t2.Width, t2.Height, t2.Area);

        }
    }
}
