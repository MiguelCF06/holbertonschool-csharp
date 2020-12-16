using System;
using System.Collections.Generic;
using System.Linq;

namespace Text
{
    /// <summary>Represents a Str class.</summary>
    public class Str
    {
        /// <summary>Check if a passed string <paramref name="s" /> is palindrome or not. If it is returns true otherwise returns false.</summary>
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0)
                return true;

            string replacedStr = String.Join("", s.Where(char.IsLetterOrDigit));
            string reversedStr = string.Empty;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversedStr += s[i].ToString();
            }

            string replacedReversedStr = String.Join("", reversedStr.Where(char.IsLetterOrDigit));

            if (replacedReversedStr.ToLower() == replacedStr.ToLower())
                return true;
            else
                return false;
        }
    }
}
