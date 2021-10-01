using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class Sort
    {
        static void Main(string[] args)
        {
            int[] a = new int[4] { 1, 3, 2, 4 };
            Console.WriteLine("정렬전 데이터");

            for(int i=0;i<=a.Length-1;i++)
                Console.Write("{0}\t",a[i]);

            for (int j = 0; j <= a.Length - 1; j++)
            {
                for(int i = j+1; i <= a.Length - 1; i++)
                {
                    if (a[j]<a[i])
                    {
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("정렬후 데이터");
            for (int i = 0; i <= a.Length - 1; i++)
                Console.Write("{0}\t", a[i]);
        }
    }
}
