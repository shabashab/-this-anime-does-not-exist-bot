using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.Validators;
using ThisAnimeDoesNotExistBot.BL.Validators.RangeValidators;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ValidatorsTests.RangeValidatorsTests.IntegerRangeValidatorTest
{
  [TestFixture]
  public class IntegerRangeValidatorTest
  {
    private IValidator<int> CreateValidator(int min, int max)
    {
      return new IntegerRangeValidator(min, max);
    }
    
    [TestCaseSource(
      typeof(IntegerRangeValidatorTestCasesSource),
      nameof(IntegerRangeValidatorTestCasesSource.GetHigherCases),
      new object[] {100})]
    public void Validate_ValueHigher_ReturnFalse(int min, int max, int value)
    {
      var validator = CreateValidator(min, max);

      var result = validator.Validate(value);
      
      Assert.IsFalse(result, $"{result} shouldn't be in range from {min} to {max}");
    }
    
    [TestCaseSource(
      typeof(IntegerRangeValidatorTestCasesSource),
      nameof(IntegerRangeValidatorTestCasesSource.GetLowerCases),
      new object[] {100})]
    public void Validate_ValueLower_ReturnFalse(int min, int max, int value)
    {
      var validator = CreateValidator(min, max);

      var result = validator.Validate(value);
      
      Assert.IsFalse(result, $"{result} shouldn't be in range from {min} to {max}");
    }
    
    [TestCaseSource(
      typeof(IntegerRangeValidatorTestCasesSource),
      nameof(IntegerRangeValidatorTestCasesSource.GetRightCases),
      new object[] {100})]
    public void Validate_ValueRight_ReturnTrue(int min, int max, int value)
    {
      var validator = CreateValidator(min, max);

      var result = validator.Validate(value);
      
      Assert.IsTrue(result, $"{result} should be in range from {min} to {max}");
    }
  }
}