using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.LargestPalindromeProduct
{
    public static class LargestPalindromeProductUtilities
    {
        /// <summary>
        /// Determines if the number input is a numerical palindrome.
        /// "A palindromic number reads the same both ways"
        /// </summary>
        /// <param name="num">Any positive number less than 1 million</param>
        /// <returns>True if number reads the same both ways</returns>
        public static bool IsNumericalPalindrome(int num)
        {
            var temp = num;
            var digits = new List<int>();
            while (temp / 10 != 0)
            {
                digits.Add(temp % 10);
                temp /= 10;
            }
            digits.Add(temp);
            return IsSymetric(digits);
        }

        private static bool IsSymetric<T>(List<T> list)
        {
            for (int i = 0; i < list.Count / 2; i++)
            {
                var fwdElement = list[i];
                var bwdElement = list[(list.Count - 1) - i];
                if (!fwdElement.Equals(bwdElement))
                    return false;
            }
            return true;
        }
    }
}
