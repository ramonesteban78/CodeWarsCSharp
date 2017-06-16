using System;
using System.Text;
namespace CodeWarsCSharp
{
    public class Diamond
    {
		public static string print(int n)
		{
            if ((n % 2 == 0) || (n < 0))
                return null;
            StringBuilder diamond = new StringBuilder();
            for (int i = 1; i <= n; i=i+2)
            {
                diamond.AppendLine($"{new string(' ', (n - i)/2)}{new string('*',i)}");
            }
			for (int i = n - 2; i >= 1; i=i-2)
			{
				diamond.AppendLine($"{new string(' ', (n - i)/2)}{new string('*', i)}");
			}
            return diamond.ToString();
		}
    }
}
