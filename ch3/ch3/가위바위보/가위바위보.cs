using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가위바위보_dll
{
    public class 가위바위보
    {
        private int _Comnum;
        private int _Mynum;
        private string _Result;
        

        public 가위바위보(int comnum, int mynum)
        {
            _Comnum = comnum;
            _Mynum = mynum;
            _Result = check_w_l(_Comnum, _Mynum);
        }
        public string Result
        {
            get { return _Result; }
            set { _Result = value; }
        }
        public int Comnum
        {
            get { return _Comnum; }
            set { _Comnum = value; }
        }
        public int Mynum
        {
            get { return _Mynum; }
            set { _Mynum = value; }
        }
        
        public string check_w_l(int comnum, int mynum)
        {
            if (comnum == 1)
            {
                if (mynum == 1)
                    return "서로 비김";
                else if (mynum == 2)
                    return "이김";
                else
                    return "짐";
            }
            else if (comnum == 2)
            {
                if (mynum == 1)
                    return "짐";
                else if (mynum == 2)
                    return "서로 비김";
                else
                    return "이김";
            }
            else
            {
                if (mynum == 1)
                    return "이김";
                else if (mynum == 2)
                    return "짐";

                else
                    return "서로 비김";

            }
        }
    }
}
