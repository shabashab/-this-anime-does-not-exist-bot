using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.ImageUriBuilder;
using ThisAnimeDoesNotExistBot.BL.ImageUriBuilder.Interfaces;
using ThisAnimeDoesNotExistBot.BL.Types;

namespace ThisAnimeDoesNotExistBot.BL.Tests.UriBuilderTests
{
  [TestFixture]
  public class ImageUriBuilderTest
  {
    private IImageUriBuilder _builder;
    
    [SetUp]
    public void Setup()
    {
      _builder = new ImageUriBuilder.ImageUriBuilder(
        new ImageUriBaseBuilder(), new CreativityPathBuilder(), new SeedPathBuilder());
    }

    [Test]
    [TestCase("https://localhost", "/results", 15U, 12345U, "https://localhost/results/psi-1.5/seed12345.png")]
    [TestCase("https://localhost", "/data", 3U, 90890U, "https://localhost/data/psi-0.3/seed90890.png")]
    [TestCase("https://localhost", "/info", 12U, 43531U, "https://localhost/info/psi-1.2/seed43531.png")]
    [TestCase("https://localhost", "/values", 20U, 56432U, "https://localhost/values/psi-2.0/seed56432.png")]
    [TestCase("https://thisanimedoesnotexist.ai", "/results", 10U, 34212U, "https://thisanimedoesnotexist.ai/results/psi-1.0/seed34212.png")]
    public void Build_ValidData_ValidResult(string hostName, string domain, uint creativity, uint seed, string expected)
    {
      var result = _builder.Build(new GeneratorParameters(seed, creativity), new WebPagePath(hostName, domain)).ToString();
      
      Assert.AreEqual(expected, result, $"{result} should be {expected}");
    }
  }
}