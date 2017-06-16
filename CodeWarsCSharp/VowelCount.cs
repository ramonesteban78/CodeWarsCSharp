using System;
using System.Linq;
namespace CodeWarsCSharp
{
    public static class Kata
    {
		public static int GetVowelCount(string str)
		{
			int vowelCount = 0;

            if (!string.IsNullOrEmpty(str))
            {
                return str.Count(x => "aeiou".Contains(x));
            }
			return vowelCount;
		}
    }
}
