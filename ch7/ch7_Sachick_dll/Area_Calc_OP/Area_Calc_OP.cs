using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_OP
{
    public class Area_Calc
    {
        private int _Width;  // 키보드에서 입력
        private int _Height; // 키보드에서 입력
        private int _Area;    // 클래스에서 계산하여 초기화 - read only
        private int _Length;  // 클래스에서 계산하여 초기화 - read only
        public Area_Calc(int w, int h)// 매개변수 있는 생성자
        {
            _Width = w;
            _Height = h;
            _Area = Sum(_Width, _Height);
            _Length = Len();
        }
        public int Width
        {
            get { return _Width; }
            set { _Width = value; }
        }
        public int Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
        public int Area  // set이 없다 readonly
        {
            get { return _Area; }
        }
        public int Length   // set이 없다 readonly
        {
            get { return _Length; }
        }
        public int Sum(int w, int h)   // 사각형 넓이 계산
        {
            return (w * h);
        }

        // 사각형 둘레 구함
        public int Len()
        {
            int length = (2 * _Width) + (2 * _Height);
            return length;
        }
    }

}
