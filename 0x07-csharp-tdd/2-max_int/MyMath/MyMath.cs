using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary>Represents the Operations class.</summary>
    public class Operations
    {
        /// <summary>Takes as argument a list <paramref name="nums"/> and returns the max integer in the list.</summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count <= 0 || nums == null)
                return 0;
            return nums.Max();
        }
    }
}
