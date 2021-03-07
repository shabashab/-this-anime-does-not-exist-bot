using System;
using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.Validators;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ValidatorsTests
{
  [TestFixture]
  public class HostNameValidatorTest
  {
    private IValidator<string> _validator;

    [SetUp]
    public void Setup()
    {
      _validator = new HostNameValidator(); 
    }
    
    [Test]
    public void Validate_IncorrectHostName_ReturnFalse()
    {
      const string incorrectHostName = "localhost";

      var result = _validator.Validate(incorrectHostName);

      Assert.IsFalse(result, $"{incorrectHostName} shouldn't be valid because it doesn't have https://");
    }


    [Test]
    public void Validate_CorrectHostName_ReturnTrue()
    {
      const string correctHostName = "https://localhost";

      var result = _validator.Validate(correctHostName);
      
      Assert.IsTrue(result, $"{correctHostName} should be valid");
    }
  }
}