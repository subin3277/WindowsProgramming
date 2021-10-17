using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7
{
    class 부모
    {
        public void Say()
        {
            Console.WriteLine("부모가 말하다");
        }
        public void Hi()
        {
            Console.WriteLine("부모가 인사하다.");
        }
        public virtual void Run()
        {
            Console.WriteLine("부모가 달리다");
        }
    }
    class 자식 : 부모
    {
        public void Say()
        {
            Console.WriteLine("자식이 말하다.");
        }
        public new void Hi()
        {
            Console.WriteLine("자식이 인사하다.");
        }
        public override void Run()
        {
            Console.WriteLine("자식이 달리다");
        }
    }
    class Class1
    {
        
    }
}
