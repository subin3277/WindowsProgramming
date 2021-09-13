using System;
class Program_Memory
{
    static int num1 = 1;  // 전역 변수 : 데이터 영역에 저장
    static int num2 = 2;  // 전역 변수 : 데이터 영역에 저장
                          // Main 이 끝날 때까지 유지
    static void Main(string[] args)
    {
        int arg = 10;  // 지역젼수 : 스택영역에 저장했다가
                       //  Main 이 끝날 때까지 유지
        func1(arg);  // 10은 main() 내에서만 유효
        func2(arg);
    }
    static void func1(int arg1)
    {
        arg1 = arg1 + num1; //11을 스택에 저장했다가 func1 벗어나면서 소멸됨.
        Console.WriteLine(arg1);  // num1은 전역변수임
    }
    static void func2(int arg2)
    {
        arg2 = arg2 + num2; //  12를 스택에 저장했다가 func2 벗어나면서 소멸됨.
        Console.WriteLine(arg2);
    }
}

