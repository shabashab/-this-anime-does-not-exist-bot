using System.IO;

namespace ThisAnimeDoesNotExistBot.BL.Validators.ImageLoader
{
  public class ImageWebResponseStreamValidator : IValidator<Stream>
  {
    public bool Validate(Stream inputValue)
    {
      return inputValue.CanRead;
    }
  }
}