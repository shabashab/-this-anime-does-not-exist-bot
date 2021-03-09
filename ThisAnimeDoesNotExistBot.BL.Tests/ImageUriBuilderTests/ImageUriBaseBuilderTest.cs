using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.ImageUriBuilder;
using ThisAnimeDoesNotExistBot.BL.ImageUriBuilder.Interfaces;
using ThisAnimeDoesNotExistBot.BL.Types;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ImageUriBuilderTests
{
  [TestFixture]
  public class ImageUriBaseBuilderTest
  {
    private IImageUriBaseBuilder _builder;

    [SetUp]
    public void Setup()
    {
      _builder = new ImageUriBaseBuilder();
    }

    [Test]
    [TestCase("https://google.com", "/search", "https://google.com/search")]
    [TestCase("https://localhost", "/local", "https://localhost/local")]
    public void Build_ValidHostName_ValidBaseUri(string hostName, string domain, string expected)
    {
      var result = _builder.Build(new WebPagePath(hostName, domain));
      
      Assert.AreEqual(expected, result, $"{result} should be {expected}");
    }
  }
}