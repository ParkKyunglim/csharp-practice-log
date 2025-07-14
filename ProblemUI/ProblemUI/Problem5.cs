using System;
using System.Collections.Generic;
using System.Linq;

namespace Test0714
{
    class Problem5
    {
        public string Solve()
        {
            // 문자 배열 조합
            char[] letters = { 'A', 'B', 'C' };
            // 길이 3짜리 순열만 출력
            List<string> result = GeneratePermutations("", letters.ToList());
            return string.Join("\r\n", result);
        }
        private List<string> GeneratePermutations(string current, List<char> remaining)
        {
            if (remaining.Count == 0)
            {
                return new List<string> { current };
            }

            List<string> result = new List<string>();
            for (int i = 0; i < remaining.Count; i++)
            {
                char c = remaining[i];
                List<char> nextRemaining = new List<char>(remaining);
                nextRemaining.RemoveAt(i);
                result.AddRange(GeneratePermutations(current + c, nextRemaining));
            }
            return result;
        }
    }
}
