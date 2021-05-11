using System;
using System.Collections.Generic;
using System.Text;
using Application;
using Xunit;
using FluentAssertions;

namespace UnitTests
{
    public class WordChainTests
    {
		private readonly WordChain _wordChain;

		public WordChainTests()
        {
			var dictionary = new List<string> { "cat", "dog" };
			_wordChain = new WordChain(dictionary);
        }

		[Fact(DisplayName = "Validator -> Should Consider Valid -> Valid Words")]
		public void Should_ReturnListWithJustTheWord_When_FirstAndLastAreTheSameWord()
		{
			// Arrange
			var input = "dog";

			// Act 
            var result = _wordChain.Solver(input, input);

			// Assert
            result.Count.Should().Be(1);
            result.Should().NotBeEmpty();
            result.Should().NotBeNull();
        }
    }
}
