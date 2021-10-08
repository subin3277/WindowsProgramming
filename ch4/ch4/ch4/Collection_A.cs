using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class Collection_A
    {
        static void Main(string[] args)
        {
            ArrayList AL = new ArrayList();
            AL.Add(123);
            AL.Add("Hello");
            AL.Add(DateTime.Now);
            AL.Add(123.45);

            AL.Insert(2, "Insert Data");
            AL.Remove(AL[3]);

            for(int i=0;i<AL.Count;i++)
                Console.WriteLine(AL[i]);
        }
    }
}
