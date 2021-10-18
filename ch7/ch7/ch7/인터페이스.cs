using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7
{
    public interface ISO
    {
        void Run();
    }
    public abstract class KS
    {
        public abstract void Back();
    }
    public class Hundai : KS
    {
        public override void Back()
        {
            Console.WriteLine("후진");
        }
    }
    public class Car : Hundai, ISO
    {
        public void Run()
        {
            Console.WriteLine("전진");
        }
    }
    class 인터페이스
    {
        public static void Main()
        {
            Car sonata = new Car();
            sonata.Run();
            sonata.Back();
        }
    }
}
