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

            s = s.ToLower();
            int counterOfChars;

            for (int i = 0; i < s.Length; i++)
            {
                counterOfChars = 0;
                for (int j = 0; j < s.Length; j++)
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
