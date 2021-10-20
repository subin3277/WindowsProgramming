using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 김수빈_가위바위보
{
    public class GBB
    {
        public static string Res(int com, int me)
        {
            //가위 : 1, 바위 :2, 보:3
            //승 : 1, 패 : 2, 비김 : 3
            int result = 0;
            if(com == 1)
            {
                if (me == 1)
                    result = 3;
                else if (me == 2)
                    result = 1;
                else
                    result = 2;
            }
            else if (com == 2)
            {
                if (me == 1)
                    result = 2;
                else if (me == 2)
                    result = 3;
                else
                    result = 1;
            }
            else
            {
                if (me == 1)
                    result = 1;
                else if (me == 2)
                    result = 2;
                else
                    result = 3;
            }
            if (result == 1)
                return "내가 승";
            else if (result == 2)
                return "내가 패";
            else
                return "서로비김";
        }
    }
}
