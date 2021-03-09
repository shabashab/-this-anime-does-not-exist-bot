using System.IO;
using System.Net;

namespace ThisAnimeDoesNotExistBot.BL.RequestService
{
  public class HttpResponse : IHttpResponse
  {
    private readonly HttpWebResponse _webResponse;

    public Stream ResponseStream => _webResponse.GetResponseStream();
    public HttpStatusCode StatusCode => _webResponse.StatusCode;
    public string ContentType => _webResponse.ContentType;

    public HttpResponse(HttpWebResponse webResponse)
    {
      _webResponse = webResponse;
    }
  }
}