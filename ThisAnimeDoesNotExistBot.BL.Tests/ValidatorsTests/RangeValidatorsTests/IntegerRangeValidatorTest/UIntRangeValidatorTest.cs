using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.Validators;
using ThisAnimeDoesNotExistBot.BL.Validators.RangeValidators;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ValidatorsTests.RangeValidatorsTests.IntegerRangeValidatorTest
{
  [TestFixture]
  public class UIntRangeValidatorTest
  {
    private IRangeValidator<uint> _validator;

    [SetUp]
    public void Setup()
    {
      _validator = new UIntRangeValidator(); 
    }
    
    [TestCaseSource(
      typeof(UIntRangeValidatorTestCasesSource),
      nameof(UIntRangeValidatorTestCasesSource.GetHigherCases),
      new object[] {100})]
    public void Validate_ValueHigher_ReturnFalse(uint min, uint max, uint value)
    {
      _validator.MinValue = min;
      _validator.MaxValue = max;

      var result = _validator.Validate(value);
      
      Assert.IsFalse(result, $"{value} shouldn't be in range from {min} to {max}");
    }
    
    [TestCaseSource(
      typeof(UIntRangeValidatorTestCasesSource),
      nameof(UIntRangeValidatorTestCasesSource.GetLowerCases),
      new object[] {100})]
    public void Validate_ValueLower_ReturnFalse(uint min, uint max, uint value)
    {
      _validator.MinValue = min;
      _validator.MaxValue = max;

      var result = _validator.Validate(value);
      
      Assert.IsFalse(result, $"{value} shouldn't be in range from {min} to {max}");
    }
    
    [TestCaseSource(
      typeof(UIntRangeValidatorTestCasesSource),
      nameof(UIntRangeValidatorTestCasesSource.GetRightCases),
      new object[] {100})]
    public void Validate_ValueRight_ReturnTrue(uint min, uint max, uint value)
    {
      _validator.MinValue = min;
      _validator.MaxValue = max;

      var result = _validator.Validate(value); 
      Assert.IsTrue(result, $"{value} should be in range from {min} to {max}");
    }
  }
}