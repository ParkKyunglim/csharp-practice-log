using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0714
{
    class Problem4
    {
        public static string Solve()
        {
            // 정수 배열 원소를 2칸씩 앞으로 이동
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = 2; // 앞으로 두 칸 이동

            int[] rotated = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                // 음수 방지, 배열 범위 조정
                int newIndex = (i - n + arr.Length) % arr.Length;
                rotated[newIndex] = arr[i];
            }

            string result = "";

            foreach (int num in rotated)
            {
                result += $"{num} ";
            }

            return result;
        }
    }
}
