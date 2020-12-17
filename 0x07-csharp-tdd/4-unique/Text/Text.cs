using System;

namespace Text
{
    /// <summary>Represents a Str class.</summary>
    public class Str
    {
        /// <summary>Check for unique characters in a string <paramref name="s"/> and returns the index where its located that char.</summary>
        public static int UniqueChar(string s)
        {
            if (s == null)
                return -1;
                
            if (s.Length == 1)
                return 0;

            s = s.ToLower();
            int counterOfChars;

            for (int i = 0; i < s.Length - 1; i++)
            {
                counterOfChars = 0;
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (i != j)
                    {
                        if (s[i] == s[j])
                            counterOfChars += 1;
                    }
                }
                if (counterOfChars == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
