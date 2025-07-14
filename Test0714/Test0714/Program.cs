using System;

namespace Test0714
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문제 번호를 입력하세요 (1~5):");
            int n = int.Parse(Console.ReadLine()); // 문자열을 정수형(int)으로 변환하는 메서드

            switch (n)
            {
                case 1: Problem1.Solve(); break;
                case 2: Problem2.Solve(); break;
                case 3: Problem3.Solve(); break;
                case 4: Problem4.Solve(); break;
                case 5: Problem5.Solve(); break;
                
                default: Console.WriteLine("잘못된 번호입니다."); break;
            }
        }
    }
}