using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7
{
    abstract class Computer
    {
        public void Graphic()
        {
            Console.WriteLine("일반메소드 호출");
        }
        public virtual void Bye()
        {
            Console.WriteLine("메인에서 Graphic 카드를 사다.");
        }
        public abstract void Network();
    }

    class NewComputer : Computer
    {
        public override void Bye()
        {
            Console.WriteLine("상속해서 가상메소드 구현 후 사용");
        }
        public override void Network()
        {
            Console.WriteLine("Network 재정의 OK");
        }
    }
    class 추상클래스
    {
        static void Main(string[] args)
        {
            Computer c = new NewComputer();

            c.Graphic();
            c.Network();

            c.Bye();
        }
    }
}
