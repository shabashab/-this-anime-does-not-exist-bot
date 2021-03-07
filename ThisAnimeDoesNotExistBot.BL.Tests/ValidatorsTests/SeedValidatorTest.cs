using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.Validators;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ValidatorsTests
{
  [TestFixture]
  public class SeedValidatorTest
  {
    private IValidator<uint> _validator;

    [SetUp]
    public void Setup()
    {
      _validator = new SeedValidator(); 
    }

    [Test]
    [TestCase(1U)]
    [TestCase(13U)]
    [TestCase(348U)]
    [TestCase(9087U)]
    public void Validate_LessDigits_ReturnFalse(uint number)
    {
      var result = _validator.Validate(number);
      
      Assert.IsFalse(result, $"{result} shouldn't be valid because it has less than 5 digits");
    }

    [Test]
    [TestCase(720181U)]
    [TestCase(9012456U)]
    [TestCase(12098632U)]
    [TestCase(456098120U)]
    [TestCase(1231098001U)]
    public void Validate_MoreDigits_ReturnFalse(uint number)
    {
      var result = _validator.Validate(number);
      
      Assert.IsFalse(result, $"{result} shouldn't be valid because it has more than 5 digits");
    }

    [Test]
    public void Validate_RightNumber_ReturnTrue([Random(10000U, 99999U, 100)] uint number)
    {
      var result = _validator.Validate(number);
      
      Assert.IsTrue(result, $"{result} shoud be valid because it has exatly 5 digits");
    }
  }
}