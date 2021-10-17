using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7
{
    class 아빠
    {
        protected string name = "김아빠";
        protected int age = 60;
        protected int money = 10000;
        protected string add = "송도동 111번지 아빠주소";
        
    }
    class 아들 : 아빠
    {
        public 아들()
        {
            this.name = "김아들";
            this.age = 17;
        }
        public void PrintInfo()
        {
            Console.WriteLine("저는 {0}입니다.",this.name);
            Console.WriteLine("제 나이는 {0}입니다.", this.age);
            Console.WriteLine("상속된 돈 {0}원 입니다.",this.money);
            Console.WriteLine("상속된 주소는 {0}입니다.",this.add);
        }
    }
    class 상속
    {
        static void Main(string[] args)
        {
            아들 철수 = new 아들();
            철수.PrintInfo();
        }
    }
}
