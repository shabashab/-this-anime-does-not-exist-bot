using System;
using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.Validators;

namespace ThisAnimeDoesNotExistBot.BL.Tests
{
  class InvalidGeneratorParameters : IGeneratorParameters
  {
    public int Seed => 45;
    public int CreativityLevel => 100;
  }
  
  [TestFixture]
  public class ImageUriBuilderTest
  {
    private IUriBuilder CreateBuilder(int seed, int creativityLevel, string hostName)
    {
      return new ImageUriBuilder(new GeneratorParameters(seed, creativityLevel), hostName); 
    }

    [Test]
    public void BuildUri_ValidGeneratorParametersValidHostName_ReturnValidUri()
    {
      const string hostName = "https://localhost";
      const int seed = 12098;
      const int creativityLevel = 15;
      
      var builder = CreateBuilder(seed, creativityLevel, hostName);

      var expected = "https://localhost/results/psi-1.5/seed12098.png";
      
      var actual = builder.BuildUri();
      
      
      Assert.AreEqual(expected, actual.ToString(), $"{expected} and ${actual} should be equal");
    }

    [Test]
    public void Constructor_ValidGeneratorParametersInvalidHostName_ThrowArgumentException()
    {
      const string invalidHostName = "localhost";
      const int seed = 12431;
      const int creativityLevel = 15;

      Assert.Throws<ArgumentException>(() => CreateBuilder(seed, creativityLevel, invalidHostName));
    }

    [Test]
    public void Constructor_InvalidGeneratorParametersValidHostName_ThrowArgumentException()
    {
      const string hostName = "https://localhost";
      var parameters = new InvalidGeneratorParameters();

      Assert.Throws<ArgumentException>(() => new ImageUriBuilder(parameters, hostName));
    }
  }
  
}