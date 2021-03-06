using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.Validators;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ValidatorsTests
{
  [TestFixture]
  public class CreativityLevelValidatorTest
  {
    private ICreativityLevelValidator CreateValidator()
    {
      return new CreativityLevelValidator();
    }

    [Test]
    public void Validate_HigherValue_ReturnFalse([Random(20, int.MaxValue, 100)] int value)
    {
      var validator = CreateValidator();

      var result = validator.Validate(value);
      
      Assert.IsFalse(result, $"{result} shouldn't be valid because it is higher than 20");
    }
    
    
    [Test]
    public void Validate_LowerValue_ReturnFalse([Range(0, 2)] int value)
    {
      var validator = CreateValidator();

      var result = validator.Validate(value);
      
      Assert.IsFalse(result, $"{result} shouldn't be valid because it is lower than 3");
    }
    
    
    [Test]
    public void Validate_RightValue_ReturnTrue([Range(3, 20)] int value)
    {
      var validator = CreateValidator();

      var result = validator.Validate(value);
      
      Assert.IsTrue(result, $"{value} should be valid because it is in range between 3 and 20");
    }
  }
}