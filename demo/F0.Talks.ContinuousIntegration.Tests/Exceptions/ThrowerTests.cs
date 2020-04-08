using System;
using F0.Talks.ContinuousIntegration.Exceptions;
using Xunit;

namespace F0.Talks.ContinuousIntegration.Tests.Exceptions
{
	public class ThrowerTests
	{
		[Fact]
		public void Throw_Throws()
		{
			Assert.Throws<InvalidOperationException>(() => Thrower.Throw(new InvalidOperationException()));
		}
	}
}
