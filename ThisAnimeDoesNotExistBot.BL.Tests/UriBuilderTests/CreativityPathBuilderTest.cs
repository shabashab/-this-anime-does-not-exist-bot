using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.ImageUriBuilder;
using ThisAnimeDoesNotExistBot.BL.ImageUriBuilder.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Tests.UriBuilderTests
{
  [TestFixture]
  public class CreativityPathBuilderTest
  {
    private ICreativityPathBuilder _builder;
    
    [SetUp]
    public void Setup()
    {
      _builder = new CreativityPathBuilder();
    }

    [Test]
    [TestCase(3U, "/psi-0.3")]
    [TestCase(5U, "/psi-0.5")]
    [TestCase(10U, "/psi-1.0")]
    [TestCase(15U, "/psi-1.5")]
    [TestCase(20U, "/psi-2.0")]
    public void Build_ValidCreativityLevel_ValidString(uint creativityLevel, string expected)
    {
      var result = _builder.Build(creativityLevel);
      
      Assert.AreEqual(expected, result, $"{result} should be equal to {expected}");
    }
  }
}