using Xunit;
using System;
using CodeWarsCSharp;
using System.Text;

namespace CodeWarsCSharpTests
{
    public class Tests
    {
        [Fact]
		public void AreTheySameTest()
		{
			int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
			int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
			bool r = AreTheySame.comp(a, b); // True
            Assert.True(r);
		}

        [Fact]
		public void DiamondTest1()
		{
			var expected = new StringBuilder();
			expected.Append(" *\n");
			expected.Append("***\n");
			expected.Append(" *\n");

			Assert.Equal(expected.ToString(), Diamond.print(3));
		}

        [Fact]
		public void DiamondTest2()
		{
			var expected = new StringBuilder();
			expected.Append("  *\n");
			expected.Append(" ***\n");
			expected.Append("*****\n");
			expected.Append(" ***\n");
			expected.Append("  *\n");

			Assert.Equal(expected.ToString(), Diamond.print(5));
		}

        [Fact]
		public void VowelCountTest()
		{
            Assert.Equal(5, Kata.GetVowelCount("abracadabra"));
		}
    }
}
