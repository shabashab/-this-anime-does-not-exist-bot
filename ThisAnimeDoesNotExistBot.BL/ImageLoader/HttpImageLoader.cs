using System;
using System.Drawing;
using System.IO;
using System.Net;
using ThisAnimeDoesNotExistBot.BL.RequestService;
using ThisAnimeDoesNotExistBot.BL.Validators;
using ThisAnimeDoesNotExistBot.BL.Validators.ImageLoader;

namespace ThisAnimeDoesNotExistBot.BL.ImageLoader
{
  public class HttpImageLoader : IHttpImageLoader
  {
    private readonly IHttpRequestService _requestService;
    private readonly IValidator<IHttpResponse> _responseValidator;
    private readonly IValidator<Stream> _responseStreamValidator;
     
    public HttpImageLoader(IHttpRequestService requestService = null, IValidator<IHttpResponse> responseValidator = null, IValidator<Stream> responseStreamValidator = null)
    {
      _responseValidator = responseValidator ?? new ImageHttpResponseValidator();
      _responseStreamValidator = responseStreamValidator ?? new ImageWebResponseStreamValidator();
      _requestService = requestService ?? new HttpRequestService();
    }

    private void ValidateResponse(IHttpResponse response)
    {
      bool isValid = _responseValidator.Validate(response);
      if(isValid == false)
        throw new WebException("Response is not valid");
    }
    private void ValidateResponseStream(Stream stream)
    {
      var isResponseStreamValid = _responseStreamValidator.Validate(stream);
      
      if(isResponseStreamValid == false)
        throw new WebException("Response stream is invalid");
    }
    private static Image CreateImageFromStream(Stream stream)
    {
      if(stream == null)
        throw new NullReferenceException("Response stream can't be null");

      var resultImage = Image.FromStream(stream);
      return resultImage;
    }
    private Image CreateImageFromResponse(IHttpResponse response)
    {
      ValidateResponseStream(response.ResponseStream);
      return CreateImageFromStream(response.ResponseStream);
    }
    
    public Image LoadByUri(Uri uri)
    {
      var response = _requestService.GetResponseByUri(uri);

      ValidateResponse(response);

      var result = CreateImageFromResponse(response);
      return result;
    }
  }
}