using System;
using System.Collections.Generic;
using System.Text;
using Application;

namespace UnitTests
{
    public class WordChainTests
    {
		private readonly WordChain _wordChain;

		public WordChainTests()
        {
			var dictionary = List<string> { "cat", "dog" };
			_wordChain = new WordChain();
        }

		[Fact(DisplayName = "Validator -> Should Consider Valid -> Valid Words")]
		public void Should_ReturnListWithJustTheWord_When_FirstAndLastAreTheSameWord()
		{
			// Arrange
			var input = "dog";

			// Act / Assert
			_validator.IsValidWords(validInput);
		}
	}
}
