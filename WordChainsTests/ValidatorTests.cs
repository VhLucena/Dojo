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
			var validator = new Validator();
			
			// Act / Assert
			validator.IsValidWords(validInput);
		}

		[Fact(DisplayName = "Validator -> Should Consider Valid -> Valid Words")]
		public void Should_ConsiderValid_When_NoWordsAreProvided()
		{
			// Arrange
			var validInput = new List<string> { };
			var validator = new Validator();

			// Act / Assert
			validator.IsValidWords(validInput);
		}

		[Theory(DisplayName = "Validator -> Should Consider Valid -> Valid Words")]
        [InlineData("asdfsf")]
		public void Should_ConsiderInvalid_When_ProvidingInvalidWords(string invalidWord)
		{
			// Arrange
			var invalidWords = new List<string> { invalidWord };
			var validator = new Validator();
			
			// Act / Assert
			Assert.Throws<Exception>(() => validator.IsValidWords(invalidWords));
		}
	}
}

