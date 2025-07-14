using System;
using System.Collections.Generic;
using System.Linq;

namespace Test0714
{
    class Problem5
    {
        public static void Solve()
        {
            // 문자 배열 조합
            char[] letters = { 'A', 'B', 'C' };
            // 길이 3짜리 순열만 출력
            GeneratePermutations("", letters.ToList());
        }
        static void GeneratePermutations(string current, List<char> remaining)
        {
            if (remaining.Count == 0)
            {
                Console.WriteLine(current);
                return;
            }

            for (int i = 0; i < remaining.Count; i++)
            {
                // 선택할 문자
                char c = remaining[i];
                // 선택 문자를 뺀 나머지 리스트 생성
                List<char> nextRemaining = new List<char>(remaining);
                // 중복 방지를 위해 이미 쓴 문자는 제거
                nextRemaining.RemoveAt(i);

                // 다음 재귀 호출
                GeneratePermutations(current + c, nextRemaining);
            }
        }
    }
}
