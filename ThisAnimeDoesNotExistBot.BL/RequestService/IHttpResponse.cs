using System.IO;
using System.Net;

namespace ThisAnimeDoesNotExistBot.BL.RequestService
{
  public interface IHttpResponse
  {
    Stream ResponseStream { get; }
    HttpStatusCode StatusCode { get; }
    string ContentType { get; }
  }
}