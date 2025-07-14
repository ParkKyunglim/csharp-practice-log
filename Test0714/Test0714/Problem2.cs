using System;
using System.Collections.Generic; // 제네릭 컬렉션 사용

namespace Test0714
{
    public class Problem2
    {
        public static string Solve()
        {
            // 배열 내림차순
            List<int> numbers = new List<int> { 15, 3, 23, 64, 77, 46, 42, 8, 1, 100, 29, 300 };

            numbers.Sort();
            numbers.Reverse();

            string result = "내림차순 결과: ";
            result += string.Join(" ", numbers);

            return result; // return 문 필수

        }
    }
}