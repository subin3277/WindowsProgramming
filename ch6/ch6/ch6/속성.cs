using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6
{
    //class 속성
    //{
    //    public static void Main(string[] args)
    //    {
    //        string name = "절차지향방법";
    //        int age = 20;
    //        Print(name, age);
    //    }

    //    private static void Print(string name, int age)
    //    {
    //        Console.WriteLine("이름 : {0}, 나이 : {1}", name, age);
    //    }
    //}

    public class saram
    {
        //private string name;
        //private int age;

        //public saram(string n, int a)
        //{
        //    this.name = n; this.age = a;
        //}
        //public void Print()
        //{
        //    Console.WriteLine("이름은 {0}, 나이는 {1}",name,age);
        //}

        //public string GetName()
        //{
        //    return this.name;
        //}
        //public int GetAge()
        //{
        //    return this.age;
        //}
        //public void SetName(string value)
        //{
        //    this.name = value;
        //}
        //public void SetAge(int value)
        //{
        //    this.age = value;
        //}

        //private string _Name;
        //private int _Age;

        //public string Name
        //{
        //    get { return _Name; }
        //    set { _Name = value; }
        //}
        //public int Age
        //{
        //    get { return _Age; }
        //    set { _Age = value; }
        //}
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class 속성
    {
        public static void Main(string[] args)
        {
            //saram a = new saram();
            //a.name = "구조체 a";
            //a.age = 11;
            //a.Print("클래스 A", 111);

            //saram b = new saram();
            //b.name = "구조체 b";
            //b.age = 33;
            //b.Print("클래스 B", 222);

            //saram c = new saram("강감찬", 888);
            //c.Print();

            //saram c = new saram();
            //c.SetName("강감이");
            //c.SetAge(888);
            //Print(c.GetName(), c.GetAge());

            saram c = new saram();
            c.Name = "강감찬이다.";
            c.Age = 889;
            Print(c.Name, c.Age);
            
        }

        private static void Print(string name, int age)
        {
            Console.WriteLine("이름 {0}, 나이 {1}", name,age);
        }
    }
}
