using System;
using System.Net;

namespace ThisAnimeDoesNotExistBot.BL.RequestService
{
  public class HttpRequestService : IHttpRequestService
  {
    private static WebRequest CreateRequestWithUri(Uri uri)
    {
      var request = WebRequest.Create(uri);
      request.Credentials = CredentialCache.DefaultCredentials;

      return request;
    }
    
    private static HttpWebResponse GetResponse(WebRequest request)
    {
      var response = request.GetResponse();
      var isHttp = response is HttpWebResponse;
      if(isHttp == false)
        throw new WebException("Response should be http");
      return (HttpWebResponse)response;
    }
    
    public IHttpResponse GetResponseByUri(Uri uri)
    {
      var request = CreateRequestWithUri(uri);
      var webResponse = GetResponse(request);
      var httpResponse = new HttpResponse(webResponse);
      return httpResponse;
    }
  }
}