using System;
using System.Collections.Generic;
using F0.Talks.ContinuousIntegration.Text;
using Xunit;

namespace F0.Talks.ContinuousIntegration.Tests.Text
{
	public class FizzBuzzBuilderTests
	{
		[Fact]
		public void GetFizzBuzz_CountIsLessThanZero_Throws()
		{
			Assert.Throws<ArgumentOutOfRangeException>("count", () => FizzBuzzBuilder.GetFizzBuzz(0, -1));
		}

		[Fact]
		public void EnumerateFizzBuzz_CountIsLessThanZero_ThrowsImmediately()
		{
			Assert.Throws<ArgumentOutOfRangeException>("count", () => FizzBuzzBuilder.EnumerateFizzBuzz(0, -1));
		}

		[Fact]
		public void GetFizzBuzz_StartPlusCountMinusOneIsLargerThanMaxValue_Throws()
		{
			Assert.Throws<ArgumentOutOfRangeException>("count", () => FizzBuzzBuilder.GetFizzBuzz(int.MaxValue, 2));
			Assert.Throws<ArgumentOutOfRangeException>("count", () => FizzBuzzBuilder.GetFizzBuzz(2, int.MaxValue));
		}

		[Fact]
		public void EnumerateFizzBuzz_StartPlusCountMinusOneIsLargerThanMaxValue_ThrowsImmediately()
		{
			Assert.Throws<ArgumentOutOfRangeException>("count", () => FizzBuzzBuilder.EnumerateFizzBuzz(int.MaxValue, 2));
			Assert.Throws<ArgumentOutOfRangeException>("count", () => FizzBuzzBuilder.EnumerateFizzBuzz(2, int.MaxValue));
		}

		[Theory]
		[MemberData(nameof(GetFizzBuzzTestData))]
		public void GetFizzBuzz_DivisibleByThreeIsFizz_DivisibleByFiveIsBuzz_BothIsFizzBuzz_NeitherIsNumber(int start, int count, string expected)
		{
			string actual = FizzBuzzBuilder.GetFizzBuzz(start, count);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[MemberData(nameof(GetEmptyTestData))]
		public void GetFizzBuzz_NoRange_Empty(int start, int count)
		{
			string empty = FizzBuzzBuilder.GetFizzBuzz(start, count);

			Assert.Empty(empty);
		}

		[Theory]
		[MemberData(nameof(GetSeparatorTestData))]
		public void GetFizzBuzz_Separator(int start, int count, string separator, string expected)
		{
			string actual = FizzBuzzBuilder.GetFizzBuzz(start, count, separator);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[MemberData(nameof(GetEnumerableTestData))]
		public void EnumerateFizzBuzz(int start, int count, IEnumerable<string> expected)
		{
			IEnumerable<string> actual = FizzBuzzBuilder.EnumerateFizzBuzz(start, count);

			Assert.Equal(expected, actual);
		}

		public static IEnumerable<object[]> GetFizzBuzzTestData()
		{
			return new object[][]
			{
				new object[] { 1, 4, "1, 2, Fizz, 4" },
				new object[] { 4, 4, "4, Buzz, Fizz, 7" },
				new object[] { 14, 3, "14, FizzBuzz, 16" },
				new object[] { 1, 36, "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, FizzBuzz, 31, 32, Fizz, 34, Buzz, Fizz" },
			};
		}

		public static IEnumerable<object[]> GetEmptyTestData()
		{
			return new object[][]
			{
				new object[] { 0, 0 },
				new object[] { 1, 0 },
				new object[] { -1, 0 },
			};
		}

		public static IEnumerable<object[]> GetSeparatorTestData()
		{
			return new object[][]
			{
				new object[] { 1, 5, " ", "1 2 Fizz 4 Buzz" },
				new object[] { 13, 3, ";", "13;14;FizzBuzz" },
			};
		}

		public static IEnumerable<object[]> GetEnumerableTestData()
		{
			return new object[][]
			{
				new object[] { 28, 5, new string[] { "28", "29", "FizzBuzz", "31", "32" } },
				new object[] { 19, 8, new string[] { "19", "Buzz", "Fizz", "22", "23", "Fizz", "Buzz", "26" } },
				new object[] { 36, 0, Array.Empty<string>() },
			};
		}
	}
}
