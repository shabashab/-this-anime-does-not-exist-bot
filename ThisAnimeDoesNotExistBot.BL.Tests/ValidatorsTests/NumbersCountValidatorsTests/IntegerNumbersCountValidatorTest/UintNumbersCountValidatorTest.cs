using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.Validators.NumbersCountValidators;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ValidatorsTests.NumbersCountValidatorsTests.IntegerNumbersCountValidatorTest
{

  [TestFixture]
  public class UintNumbersCountValidatorTest
  {
    private INumbersCountValidator<uint> _validator;

    [SetUp]
    public void SetUp()
    {
      _validator = new UIntNumbersCountValidator();
    }
    
    [Test]
    [TestCaseSource(
      typeof(UIntNubmersCountValidatorTestCasesSource),
      nameof(UIntNubmersCountValidatorTestCasesSource.GetHigherCases),
      new object[] {100})]
    public void Validate_ValueNumbersCountHigherRandomCases_ReturnFalse(uint numbersCount, uint value)
    {
      _validator.ExpectedCount = numbersCount;
      
      var result = _validator.Validate(value);
      Assert.IsFalse(result, $"{value} should not be {numbersCount} number long");
    }


    [Test]
    [TestCaseSource(
      typeof(UIntNubmersCountValidatorTestCasesSource),
      nameof(UIntNubmersCountValidatorTestCasesSource.GetLowerCases),
      new object[] {100})]
    public void Validate_ValueNumbersCountLowerRandomCases_ReturnFalse(uint numbersCount, uint value)
    {
      _validator.ExpectedCount = numbersCount;

      var result = _validator.Validate(value);
      Assert.IsFalse(result, $"{value} should not be {numbersCount} number long");
    }

    [Test]
    [TestCaseSource(
      typeof(UIntNubmersCountValidatorTestCasesSource),
      nameof(UIntNubmersCountValidatorTestCasesSource.GetRightCases),
      new object[] {100})] 
    public void Validate_ValueNumbersCountCorrect_ReturnTrue(uint numbersCount, uint value)
    {
      _validator.ExpectedCount = numbersCount;

      var result = _validator.Validate(value);
      Assert.IsTrue(result, $"{value} should be {numbersCount} number long");
    }
  }
}