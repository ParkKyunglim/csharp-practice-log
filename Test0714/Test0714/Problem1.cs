using System;

namespace Test0714
{
    public class Problem1
    {
        public static string Solve()
        {
            // 1부터 100까지의 합 구하기
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            return $"1부터 100까지의 합: {sum}";
        }
    }
}