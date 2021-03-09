using System.Net;
using ThisAnimeDoesNotExistBot.BL.RequestService;

namespace ThisAnimeDoesNotExistBot.BL.Validators.ImageLoader
{
  public class ImageHttpResponseValidator : IValidator<IHttpResponse>
  {
    private bool ValidateContentType(IHttpResponse response)
    {
      return response.ContentType.StartsWith("image");
    }

    private bool ValidateStatusCode(IHttpResponse response)
    {
      return response.StatusCode == HttpStatusCode.OK;
    }
    
    public bool Validate(IHttpResponse inputValue)
    {
      if (ValidateStatusCode(inputValue) == false) return false;
      if (ValidateContentType(inputValue) == false) return false;

      return true;
    }
    
  }
}