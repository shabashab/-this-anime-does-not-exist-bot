using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.ImageUriBuilder;
using ThisAnimeDoesNotExistBot.BL.ImageUriBuilder.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Tests.UriBuilderTests
{
  [TestFixture]
  public class SeedPathBuilderTest
  {
    private ISeedPathBuilder _builder;

    [SetUp]
    public void Setup()
    {
      _builder = new SeedPathBuilder(); 
    }

    [Test]
    [TestCase(98214U, "/seed98214.png")]
    [TestCase(12546U, "/seed12546.png")]
    [TestCase(81254U, "/seed81254.png")]
    [TestCase(74352U, "/seed74352.png")]
    [TestCase(90124U, "/seed90124.png")]
    public void Build_ValidSeed_ValidResult(uint seed, string expected)
    {
      var result = _builder.Build(seed);
      
      Assert.AreEqual(expected, result, $"{result} should be {expected}");
    }
  }
}