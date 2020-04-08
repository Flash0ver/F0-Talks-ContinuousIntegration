using System;

namespace Snippets
{
	internal static class Check
	{
		public static LogicalChecker That(bool actual)
		{
			return new LogicalChecker(actual);
		}

		public static EqualityChecker<T> That<T>(T actual)
		{
			return new EqualityChecker<T>(actual);
		}
	}

	internal class LogicalChecker
	{
		private readonly bool actual;

		public LogicalChecker(bool actual)
		{
			this.actual = actual;
		}

		public void IsTrue()
		{
			if (actual)
			{
				Checker.Pass();
			}
			else
			{
				Checker.Fail(true, actual);
			}
		}

		public void IsFalse()
		{
			if (!actual)
			{
				Checker.Pass();
			}
			else
			{
				Checker.Fail(false, actual);
			}
		}
	}

	internal class EqualityChecker<T>
	{
		private readonly T actual;

		public EqualityChecker(T actual)
		{
			this.actual = actual;
		}

		public void Equal(IEquatable<T> expected)
		{
			if (expected.Equals(actual))
			{
				Checker.Pass();
			}
			else
			{
				Checker.Fail(expected, actual);
			}
		}
	}

	internal static class Checker
	{
		public static void Pass()
		{
			Console.Write("✅ ");
			Console.WriteLine($"Test passed.");
		}

		public static void Fail(object expected, object actual)
		{
			Console.Write("❌ ");
			Console.WriteLine($"Expected to be '{expected}', but actually was '{actual}'.");
		}
	}
}
