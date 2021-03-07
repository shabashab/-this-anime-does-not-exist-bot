using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.Validators;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ValidatorsTests
{
  [TestFixture]
  public class CreativityLevelValidatorTest
  {
    private IValidator<uint> _validator;

    [SetUp]
    public void Setup()
    {
      _validator = new CreativityLevelValidator(); 
    }

    [Test]
    public void Validate_HigherValue_ReturnFalse([Random(20U, uint.MaxValue, 100)] uint value)
    {
      var result = _validator.Validate(value);
      
      Assert.IsFalse(result, $"{result} shouldn't be valid because it is higher than 20");
    }
    
    
    [Test]
    public void Validate_LowerValue_ReturnFalse([Range(0U, 2U)] uint value)
    {
      var result = _validator.Validate(value);
      
      Assert.IsFalse(result, $"{result} shouldn't be valid because it is lower than 3");
    }
    
    
    [Test]
    public void Validate_RightValue_ReturnTrue([Range(3U, 20U)] uint value)
    {
      var result = _validator.Validate(value);
      
      Assert.IsTrue(result, $"{value} should be valid because it is in range between 3 and 20");
    }
  }
}