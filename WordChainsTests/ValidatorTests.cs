using System;
using System.Collections.Generic;
using WordChains;
using WordChains.Exceptions;
using Xunit;

namespace WordChain.UnitTests
{
	public class ValidatorTests
	{
		private readonly Validator _validator;

		public ValidatorTests()
		{
			var dictionary = new List<string>
			{
				"dog", "cat", "dot", "cot"
			};

			_validator = new Validator(dictionary);
		}

		[Fact(DisplayName = "Validator -> Should Consider Valid -> Valid Words")]
		public void Should_ConsiderValid_When_WordsAreValid()
		{
			// Arrange
			var validInput = new List<string> { "dog", "dot", "cot" };
			
			// Act / Assert
			_validator.IsValidWords(validInput);
		}

		[Fact(DisplayName = "Validator -> Should Consider Valid -> Valid Words")]
		public void Should_ConsiderValid_When_NoWordsAreProvided()
		{
			// Arrange
			var validInput = new List<string> { };

			// Act / Assert
			_validator.IsValidWords(validInput);
		}

		[Theory(DisplayName = "Validator -> Should Consider Invalid -> Providing Invalid Words")]
        [InlineData("asdfsf")]
        [InlineData("aaaaaa")]
        [InlineData("xasdff")]
        [InlineData("")]
        [InlineData(".")]
        [InlineData("?")]
		public void Should_ConsiderInvalid_When_ProvidingInvalidWords(string invalidWord)
		{
			// Arrange
			var invalidWords = new List<string> { invalidWord };
			
			// Act / Assert
			Assert.Throws<InvalidWordException>(() => _validator.IsValidWords(invalidWords));
		}
	}
}

