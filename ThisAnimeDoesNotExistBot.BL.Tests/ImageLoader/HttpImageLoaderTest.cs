using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using Moq;
using NUnit.Framework;
using ThisAnimeDoesNotExistBot.BL.ImageLoader;
using ThisAnimeDoesNotExistBot.BL.RequestService;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ImageLoader
{
  [TestFixture]
  public class HttpImageLoaderTest
  {
    private static Stream CreateEmptyImageStream(int width, int height)
    {
      var stream = new MemoryStream();
      
      Image image = new Bitmap(width, height);
      image.Save(stream, ImageFormat.Png);

      return stream;
    }

    private static IHttpRequestService CreateHttpRequestService(string contentType, HttpStatusCode statusCode,
      Stream responseStream)
    {
      var requestServiceMock = new Mock<IHttpRequestService>();

      requestServiceMock.Setup(x => x.GetResponseByUri(new Uri("https://localhost"))).Returns(() =>
      {
        var mockHttpResponse = new Mock<IHttpResponse>();

        mockHttpResponse.SetupGet(x => x.ContentType).Returns(contentType);
        mockHttpResponse.SetupGet(x => x.StatusCode).Returns(statusCode);
        mockHttpResponse.SetupGet(x => x.ResponseStream).Returns(responseStream);

        return mockHttpResponse.Object;
      });

      return requestServiceMock.Object;
    }

    private static IHttpImageLoader CreateLoader(IHttpRequestService requestService)
    {
      return new HttpImageLoader(requestService);
    }

    private static IHttpImageLoader SetUpLoader(string contentType, HttpStatusCode statusCode, Stream imageStream)
    {
      var requestService = CreateHttpRequestService(contentType, statusCode, imageStream);
      var loader = CreateLoader(requestService);

      return loader;
    }
    
    [Test]
    public void LoadByUri_IncorrectContentType_ThrowsWebException()
    {
      var loader = SetUpLoader("text/html", HttpStatusCode.OK, CreateEmptyImageStream(100, 200));

      Assert.Throws<WebException>(() => loader.LoadByUri(new Uri("https://localhost")));
    }

    [Test]
    public void LoadByUri_IncorrectStatusCode_ThrowsWebException()
    {
      var loader = SetUpLoader("image/png", HttpStatusCode.Forbidden, CreateEmptyImageStream(100, 200));
      
      Assert.Throws<WebException>(() => loader.LoadByUri(new Uri("https://localhost")));
    }

    [Test]
    public void LoadByUri_StreamNull_ThrowsNullReferenceException()
    {
      var loader = SetUpLoader("image/png", HttpStatusCode.OK, null);
      
      Assert.Throws<NullReferenceException>(() => loader.LoadByUri(new Uri("https://localhost")));
    }

    [Test]
    public void LoadByUri_StreamIncorrectContent_ThrowsArgumentException()
    {
      var loader = SetUpLoader("image/png", HttpStatusCode.OK, new MemoryStream());
      
      Assert.Throws<ArgumentException>(() => loader.LoadByUri(new Uri("https://localhost")));
    }

    [Test]
    public void LoadByUri_ImageWidth100_ReturnsImageWidth100()
    {
      const int expectedWidth = 100;
      
      var loader = SetUpLoader("image/png", HttpStatusCode.OK, CreateEmptyImageStream(expectedWidth, 100));

      var result = loader.LoadByUri(new Uri("https://localhost")).Width;
      
      Assert.AreEqual(expectedWidth, result, $"Width should be {expectedWidth} but was {result}");
    }

    [Test]
    public void LoadByUri_ImageHeight100_ReturnsImageHeight100()
    {
      const int expectedHeight = 100;
      
      var loader = SetUpLoader("image/png", HttpStatusCode.OK, CreateEmptyImageStream(100, expectedHeight));

      var result = loader.LoadByUri(new Uri("https://localhost")).Height;
      
      Assert.AreEqual(expectedHeight, result, $"Height should be {expectedHeight} but was {result}");
    }

    [Test]
    public void LoadByUri_RandomWidthAndHeight_ReturnsImageWithExactWidthAndHeight(
      [Random(0, 1024, 10)] int expectedWidth, 
      [Random(0, 1024, 10)] int expectedHeight)
    {
      var loader = SetUpLoader("image/png", HttpStatusCode.OK, CreateEmptyImageStream(expectedWidth, expectedHeight));

      var resultWidth = loader.LoadByUri(new Uri("https://localhost")).Width;
      var resultHeight= loader.LoadByUri(new Uri("https://localhost")).Height;
      
      Assert.AreEqual(expectedWidth, resultWidth, $"Width should be {expectedWidth} but was {resultWidth}");
      Assert.AreEqual(expectedHeight, resultHeight, $"Height should be {expectedHeight} but was {resultHeight}");
    }
  }
}