using System;
using System.Linq;


namespace Test0714
{
    class Problem3
    {
        public static string Solve()
        {
            // 공통 접두사 찾기
            // input 여러 개
            string[] words = { "apple", "apps", "ape" };

            if (words.Length == 0)
            {
                return "단어가 없습니다.";
            }

            string prefix = words[0]; // 첫번째 단어를 prefix에 할당

            foreach (string word in words) // 향상된 for문
            {
                int i = 0;
                // i가 prefix와 word 길이보다 작고, 글자가 같을 때만 i 증가
                while (i < prefix.Length && i < word.Length && prefix[i] == word[i])
                {
                    i++;
                }
                // 문자열 자르기
                prefix = prefix.Substring(0, i);

                if (prefix == "")
                {
                    break;
                }
            }
            if (prefix == "")
            {
                return "공통 접두사가 없습니다.";
            }
            else
            {
                // 문자열 보간
                return $"공통접두사 {prefix.Length}, { prefix}";
            }
        }

    }
}
