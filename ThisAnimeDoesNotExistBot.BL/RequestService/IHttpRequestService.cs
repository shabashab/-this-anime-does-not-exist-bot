using System;
using System.Net;

namespace ThisAnimeDoesNotExistBot.BL.RequestService
{
  public interface IHttpRequestService
  {
    IHttpResponse GetResponseByUri(Uri uri);
  }
}