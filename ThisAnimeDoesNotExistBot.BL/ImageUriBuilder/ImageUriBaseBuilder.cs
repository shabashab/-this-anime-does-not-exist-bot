using System.Text;
using ThisAnimeDoesNotExistBot.BL.ImageUriBuilder.Interfaces;
using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.ImageUriBuilder
{
  public class ImageUriBaseBuilder : IImageUriBaseBuilder
  {
    public string Build(IWebPagePath basePath)
    {
      var uriBaseBuilder = new StringBuilder();

      uriBaseBuilder.Append(basePath.HostName);
      uriBaseBuilder.Append(basePath.Domain);

      return uriBaseBuilder.ToString();
    }
  }
}