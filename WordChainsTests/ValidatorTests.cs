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

		[Fact(DisplayName = "Validator -> Should Consider Valid -> Valid Words")]
		public void Should_ConsiderValid_When_WordsAreValid()
		{
			// Arrange
			var validInput = new List<string> { "dog", "dot", "cot" };
			
			// Act / Assert
			Validator.IsValidWords(validInput);
		}

		[Fact(DisplayName = "Validator -> Should Consider Valid -> Valid Words")]
		public void Should_ConsiderValid_When_NoWordsAreProvided()
		{
			// Arrange
			var validInput = new List<string> { };
			
			// Act / Assert
			Validator.IsValidWords(validInput);
		}

		[Theory(DisplayName = "Validator -> Should Consider Valid -> Valid Words")]
        [InlineData([ "", "" ])]
		public void Should_ConsiderInvalid_When_ProvidingInvalidWords(List<string> invalidWord)
		{
			Validator.IsValidWords(invalidWord);
		}
	}
}

