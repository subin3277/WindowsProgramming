using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6
{
    class mbc
    {
        private string name;
        private int age;
        public mbc(string irum) //매개 생성자
        {
            this.name = irum;
        }
        public void Print()
        {
            Console.WriteLine("이름은 {0}",name);
        }
        public mbc(int nayi)
        {
            this.age = nayi;
        }
        public void Out()
        {
            Console.WriteLine("나이는 {0}",age);
        }
        public mbc(string irum, int nayi)
        {
            this.name = irum; this.age = nayi;
        }
        public void Output()
        {
            Console.WriteLine("이름은 {0}, 나이는 {1}",name,age);
        }
    }
    class 매개생성자
    {
        static void Main(string[] args)
        {
            //mbc k2 = new mbc();
            //k2.Print("MBC");

            mbc k2 = new mbc("홍길동");
            k2.Print();
            mbc k3 = new mbc(77);
            k3.Out();
            mbc k4 = new mbc("강감찬", 877);
            k4.Output();
        }
    }
}
