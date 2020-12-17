using System;

namespace Text
{
    public class Str
    {
        public static int CamelCase(string s)
        {
            if (s == null)
                return 0;

            int counterOfWords = 0;

            for (int i = 0; i < s.Length; i++)
            {
                counterOfWords = 1;
                for (int j = 0; j < s.Length; j++)
                {
                    if (i != j)
                    {
                        if (Char.IsUpper(s[j]))
                        {
                            counterOfWords += 1;
                        }
                    }
                }
            }
            return counterOfWords;
        }
    }
}
