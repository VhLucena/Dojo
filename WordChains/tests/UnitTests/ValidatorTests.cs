using System.Collections.Generic;
using Application;
using Application.Exceptions;
using Xunit;

namespace UnitTests
{
	public class IsValidWordTests
	{
		private readonly Validator _validator;

		public IsValidWordTests()
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
			var validInput = new List<string> { "dog", "cot", "dot" };

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
	public class IsValidChangesTests
	{
		private readonly Validator _validator;
		public IsValidChangesTests()
		{
			var dictionary = new List<string>
				{
					"dog", "cat", "dot", "cot"
				};

			_validator = new Validator(dictionary);
		}

		[Fact(DisplayName = "Validator -> Should Consider Valid -> Providing Two Valid Words")]
		public void Should_ConsiderValid_When_ProvidingOneValidChange()
		{
			// Arrange
			var validChanges = new List<string> { "cat", "cot" };

			// Act / Assert
			_validator.IsValidChanges(validChanges);
		}

		[Fact(DisplayName = "Validator -> Should Consider Valid -> Providing No Changes")]
		public void Should_ConsiderValid_When_ProvidingNoChanges()
		{
			// Arrange
			var noChanges = new List<string> { "cat" };

			// Act / Assert
			_validator.IsValidChanges(noChanges);
		}

		[Fact(DisplayName = "Validator -> Should Consider Invalid -> Providing One Invalid Change")]
		public void Should_ConsiderInvalid_When_ProvidingOneInvalidChange()
		{
			// Arrange
			var invalidChanges = new List<string> { "cat", "dog" };

			// Act / Assert
			Assert.Throws<InvalidChangeException>(() => _validator.IsValidChanges(invalidChanges));
		}

		[Fact(DisplayName = "Validator -> Should Consider Valid -> Providing Two Valid Changes")]
		public void Should_ConsiderValid_When_ProvidingTwoValidChanges()
		{
			// Arrange
			var validChanges = new List<string> { "cat", "cot", "cog" };

			// Act / Assert
			_validator.IsValidChanges(validChanges);
		}

		[Fact(DisplayName = "Validator -> Should Consider Invalid -> First Word Is Bigger Than Second")]
		public void Should_ConsiderInvalid_When_FirstWordIsBiggerThanSecond()
		{
			// Arrange
			var invalidChanges = new List<string> { "doghouse", "dog" };

			// Act / Assert
			Assert.Throws<InvalidChangeException>(() => _validator.IsValidChanges(invalidChanges));
		}

		[Fact(DisplayName = "Validator -> Should Consider Invalid -> First Word Is Smaller Than Second")]
		public void Should_ConsiderInvalid_When_FirstWordIsSmallerThanSecond()
		{
			// Arrange
			var invalidChanges = new List<string> { "dog", "doghouse" };

			// Act / Assert
			Assert.Throws<InvalidChangeException>(() => _validator.IsValidChanges(invalidChanges));
		}
	}

	public class ConstructorTests
    {
		[Fact(DisplayName = "Should Throw When Provided Null Dictionary")]
		public void Should_Throw_When_ProvidedNullDictionary()
        {
			// Arrange / Act / Assert
			Assert.Throws<InvalidDictionaryException>(() => new Validator(null));
        }

		[Fact(DisplayName = "Should Work When Provided Empty Dictionary")]
		public void Should_Work_When_ProvidedEmptyDictionary()
		{
			// Arrange
			var emptyDictionary = new List<string> { };

			// Act / Assert
			new Validator(emptyDictionary);
		}

		[Fact(DisplayName = "Should Work When Provided Not Empty Dictionary")]
		public void Should_Work_When_ProvidedNotEmptyDictionary()
		{
			// Arrange
			var dictionary = new List<string> { "dog" };

			// Act / Assert
			new Validator(dictionary);
		}
	}
}

