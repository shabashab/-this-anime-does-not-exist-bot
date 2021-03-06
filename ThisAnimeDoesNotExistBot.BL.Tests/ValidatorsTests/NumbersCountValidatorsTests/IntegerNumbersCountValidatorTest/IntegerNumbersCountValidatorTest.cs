using System;
using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.Validators.NumbersCountValidators.IntegerNumbersCountValidator;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ValidatorsTests.NumbersCountValidatorsTests.IntegerNumbersCountValidatorTest
{

  [TestFixture]
  public class IntegerNumbersCountValidatorTest
  {
    private IntegerNumbersCountValidator CreateValidator(int numbersCount)
    {
      return new IntegerNumbersCountValidator(numbersCount);
    }

    [Test]
    public void Constructor_NumbersCountMoreThan10_ThrowArgumentException(
      [Random(11, int.MaxValue, 10)] int number)
    {
      Assert.Throws<ArgumentException>(() => CreateValidator(number));
    }

    [Test]
    [TestCaseSource(
      typeof(IntegerNumbersCountValidatorTestCasesSource),
      nameof(IntegerNumbersCountValidatorTestCasesSource.GetHigherCases),
      new object[] {100})]
    public void Validate_ValueNumbersCountHigherRandomCases_ReturnFalse(int numbersCount, int value)
    {
      var validator = CreateValidator(numbersCount);

      var result = validator.Validate(value);
      Assert.IsFalse(result, $"{value} should not be {numbersCount} number long");
    }


    [Test]
    [TestCaseSource(
      typeof(IntegerNumbersCountValidatorTestCasesSource),
      nameof(IntegerNumbersCountValidatorTestCasesSource.GetLowerCases),
      new object[] {100})]
    public void Validate_ValueNumbersCountLowerRandomCases_ReturnFalse(int numbersCount, int value)
    {
      var validator = CreateValidator(numbersCount);

      var result = validator.Validate(value);
      Assert.IsFalse(result, $"{value} should not be {numbersCount} number long");
    }

    [Test]
    [TestCaseSource(
      typeof(IntegerNumbersCountValidatorTestCasesSource),
      nameof(IntegerNumbersCountValidatorTestCasesSource.GetRightCases),
      new object[] {100})] 
  public void Validate_ValueNumbersCountCorrect_ReturnTrue(int numbersCount, int value)
    {
      var validator = CreateValidator(numbersCount);

      var result = validator.Validate(value);
      Assert.IsTrue(result, $"{value} should be {numbersCount} number long");
    }
  }
}