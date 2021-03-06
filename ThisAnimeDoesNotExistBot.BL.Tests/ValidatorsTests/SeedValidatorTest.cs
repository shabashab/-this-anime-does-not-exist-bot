using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.Validators;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ValidatorsTests
{
  [TestFixture]
  public class SeedValidatorTest
  {
    private ISeedValidator CreateValidator()
    {
      return new SeedValidator();   
    }

    [Test]
    [TestCase(1)]
    [TestCase(13)]
    [TestCase(348)]
    [TestCase(9087)]
    public void Validate_LessDigits_ReturnFalse(int number)
    {
      var validator = CreateValidator();

      var result = validator.Validate(number);
      
      Assert.IsFalse(result, $"{result} shouldn't be valid because it has less than 5 digits");
    }

    [Test]
    [TestCase(720181)]
    [TestCase(9012456)]
    [TestCase(12098632)]
    [TestCase(456098120)]
    [TestCase(1231098001)]
    public void Validate_MoreDigits_ReturnFalse(int number)
    {
      var validator = CreateValidator();

      var result = validator.Validate(number);
      
      Assert.IsFalse(result, $"{result} shouldn't be valid because it has more than 5 digits");
    }

    [Test]
    public void Validate_RightNumber_ReturnTrue([Random(10000, 99999, 100)] int number)
    {
      var validator = CreateValidator();

      var result = validator.Validate(number);
      
      Assert.IsTrue(result, $"{result} shoud be valid because it has exatly 5 digits");
    }
  }
}