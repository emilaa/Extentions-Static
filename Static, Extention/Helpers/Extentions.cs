using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Static__Extention.Helpers
{
    public static class Extentions
    {
        public static bool CheckString(this string str, string pattern)
        {
            return Regex.IsMatch(str, pattern);
        }
        public static int SumNumbers(this int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3 + num4;
        }
    }
}
