using System;
using System.Collections.Generic;
using WordChains;
using Xunit;

namespace WordChain.UnitTests
{
	public class ValidatorTests
	{
		public ValidatorTests()
		{
		}

		[Fact]
		public void Should()
		{
			var validInput = new List<string> { "dog", "dot", "cot" };
			Validator.IsValidWords(validInput);
		}
	}
}

