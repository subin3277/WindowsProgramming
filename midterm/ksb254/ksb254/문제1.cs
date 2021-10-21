using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksb254
{
    class 문제1
    {
        static void Main(string[] args)
        {
            int dis = 0;
            Console.Write("택시로 이동할 거리(KM)를 정수로 입력하세요 : ");
            dis = Convert.ToInt32(Console.ReadLine());

            Taxi taxi = new Taxi(dis);
            Console.WriteLine("이동 거리는 {0} KM는 {1} Mile 이고",dis, taxi.MileTransform());
            Console.WriteLine("택시요금은 {0}원 이다.", taxi.Money());
            
        }
    }

    class Taxi : ICalc
    {
        private int _Distance;
        public Taxi(int distance)
        {
            this.Distance = distance;
        }

        public int Distance
        {
            get { return _Distance; }
            set { _Distance = value; }
        }
        public int Money()
        {
            int won = Distance*2200;
            return won;
        }
        public double MileTransform()
        {
            double mile = Distance / 1.6;
            return mile;
        }
    }

    public interface ICalc
    {
        int Money();
        double MileTransform();
    }
}
